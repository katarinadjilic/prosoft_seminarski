using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KontrolerKI
    {
        public static Komunikacija komunikacija;
        public static Agent agent;
        public static Company company;
        public static Person person;
        public static InsurancePolicy policy;

        public static bool PoveziSeNaServer()
        {
            if (komunikacija == null) komunikacija = new Komunikacija();
            return komunikacija.poveziSeNaServer();           
        }

        //Insurance Policy
        internal static void LoadPolicy(DateTimePicker dtpExp, DateTimePicker dtpFrom, TextBox txtClient, DataGridView dataGridView1, TextBox txtValue)
        {
            dtpExp.Value = policy.ExpDate;
            dtpFrom.Value = policy.DateFrom;
            txtClient.Text =policy.Client.ToString();
            dataGridView1.DataSource = policy.ItemList;
            txtValue.Text = policy.Value.ToString("N02");
        }

        internal static bool UpdatePolicy(DateTimePicker dtpExp, DateTimePicker dtpFrom)
        {
            policy.DateFrom = dtpFrom.Value;
            policy.ExpDate = dtpExp.Value;

            if (policy.DateFrom >= policy.ExpDate)
            {
                MessageBox.Show("Policy dates not valid!");
                return false;
            }

            policy.Agent = agent;
          
            Object rez = komunikacija.UpdatePolicy(policy);

            if (rez == null)
            {
                MessageBox.Show("Sistem can't update policy.");
                return false;
            }
            else
            {
                MessageBox.Show("Successfully updated policy.");
                return true;
            }
        }

        internal static bool DeletePolicy()
        {
            Object rez = komunikacija.DeletePolicy(policy);
            Object rez2 = null;
            if (rez2 == null)
            {
                MessageBox.Show("System cant't delete policy.");
                return false;
            }
            else
            {
                MessageBox.Show("Successfully deleted policy.");
                return true;
            }
        }

        internal static void CreatePolicy(DataGridView dataGridView1)
        {
            policy = new InsurancePolicy();
            dataGridView1.DataSource = policy.ItemList;
        }

        internal static void FillComboType(ComboBox cmbItem)
        {
            cmbItem.Items.Clear();
            foreach (InsuranceType t in komunikacija.GetListInsTypes() as List<InsuranceType>)
            {
                cmbItem.Items.Add(t);
            }

            cmbItem.Text = "Select type...";
        }

        internal static void AddItem(ComboBox cmbItem, TextBox txtDesc, TextBox txtValue)
        {
            try
            {
                PolicyItem pi = new PolicyItem();
                pi.OrdNumber = policy.ItemList.Count + 1;
                pi.Type = cmbItem.SelectedItem as InsuranceType;
                pi.Description = txtDesc.Text;
                pi.Ammount = pi.Type.PricePremium;
                pi.Date = DateTime.Now;

                policy.Value += pi.Ammount;
                txtValue.Text = policy.Value.ToString("N02");

                policy.ItemList.Add(pi);


            }
            catch (Exception)
            {

                
            }
        }

        internal static bool PolicyDetails(DataGridView dataGridView1)
        {
            try
            {
                policy = dataGridView1.CurrentRow.DataBoundItem as InsurancePolicy;

                policy = komunikacija.SelectPolicy(policy) as InsurancePolicy;

                if (policy == null)
                {
                    MessageBox.Show("System can't find policy");
                    return false;
                }
                else
                {
                    MessageBox.Show("Successfully find policy.");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Select policy.");
                return false;
            }
        }

        internal static bool SavePolicy(DateTimePicker dtpExp, DateTimePicker dtpFrom, ComboBox cmbClient)
        {
            policy.DateFrom = dtpFrom.Value;
            policy.ExpDate = dtpExp.Value;

            if (policy.DateFrom >= policy.ExpDate)
            {
                MessageBox.Show("Policy dates not valid.");
                return false;
            }

            policy.Agent = agent;
            policy.Client = cmbClient.SelectedItem as Client;

            if (policy.Client == null)
            {
                MessageBox.Show("Select client.");
                return false;
            }


            Object rez = komunikacija.AddPolicy(policy);

            if (rez == null)
            {
                MessageBox.Show("Sistem cant't add insurance policy.");
                return false;
            }
            else
            {
                MessageBox.Show("Successfully added insularce policy.");
                return true;
            }
        }

        internal static void DeleteItem(DataGridView dataGridView1, TextBox txtValue)
        {
            try
            {
                PolicyItem pi = dataGridView1.CurrentRow.DataBoundItem as PolicyItem;
                policy.ItemList.Remove(pi);
                policy.Value -= pi.Ammount;
                txtValue.Text = policy.Value.ToString("N02");

                int i = 1;
                foreach (PolicyItem p in policy.ItemList)
                {
                    p.OrdNumber = i;
                    i++;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No item selected!");
            }
        }

        internal static void FillComboClient(ComboBox cmbClient, RadioButton rbPerson)
        {
            cmbClient.Items.Clear();

            if (rbPerson.Checked)
            {               
                foreach (Person t in komunikacija.GetListClients(new Person()) as List<Person>)
                {
                    cmbClient.Items.Add(t);
                }
            }
            else
            {               
                foreach (Company t in komunikacija.GetListClients(new Company()) as List<Company>)
                {
                    cmbClient.Items.Add(t);
                }
            }

          
           

            cmbClient.Text = "Select client...";
        }

        internal static void LoadClient(TextBox txtAddP, TextBox txtAdrC, TextBox txtFN, TextBox txtJMBG, TextBox txtLN, TextBox txtMail, TextBox txtName, TextBox txtPhone, TextBox txtPIB, TextBox txtRegNo, GroupBox gbCompany, GroupBox gbPerson)
        {
            if (person != null)
            {
                gbPerson.Visible = true;

                txtAddP.Text = person.Address;
                txtFN.Text = person.FirstName;
                txtLN.Text = person.LastName;
                txtMail.Text = person.Email;
                txtPhone.Text = person.Phone;
                txtJMBG.Text = person.Jmbg;
            }

            if (company != null)
            {
                gbCompany.Visible = true;

                txtAdrC.Text = company.Address;
                txtName.Text = company.Name;
                txtPIB.Text = company.Pib;
                txtRegNo.Text = company.RegistrationNo;
            }
        }

        internal static void SearchPolicy(DataGridView dataGridView1, DateTimePicker dtpDateFrom, DateTimePicker dtpDateTO)
        {
            policy = new InsurancePolicy();
            policy.USLOV = " Cast(DateFrom as date) > cast( '"+dtpDateFrom.Value.ToString("yyyy-MM-dd")+ "' as date ) and  Cast(DateFrom as date) < cast( '" + dtpDateTO.Value.ToString("yyyy-MM-dd") + "' as date ) and  Cast(ExpitarionDate as date) > cast( '" + dtpDateFrom.Value.ToString("yyyy-MM-dd") + "' as date ) and  Cast(ExpitarionDate as date) < cast( '" + dtpDateTO.Value.ToString("yyyy-MM-dd") + "' as date )";

            dataGridView1.DataSource = komunikacija.SearchPolicy(policy);
            //MessageBox.Show("System successfully find policies.");
        }

        //Client
        internal static bool DeleteClient()
        {
            Object rez = null;
            Client c = null;

            if (person != null)
            {
                c= new Client() { ClientID = person.ClientID };               


            }
            if (company != null)
            {
                c = new Client() { ClientID = company.ClientID };           
             
            }

            rez = komunikacija.DeleteClient(c);

            if (rez == null)
            {
                MessageBox.Show("System can't delete client.");
                return false;
            }
            else
            {
                MessageBox.Show("Successfully deleted client.");
                return true;
            }
        }

        internal static bool UpdateClient(TextBox txtAddP, TextBox txtAdrC, TextBox txtFN, TextBox txtJMBG, TextBox txtLN, TextBox txtMail, TextBox txtName, TextBox txtPhone, TextBox txtPIB, TextBox txtRegNo)
        {
            Object rez = null;
            if (person != null)
            {
                Person p = new Person() { ClientID=person.ClientID};
                p.Address = txtAddP.Text;
                p.Email = txtMail.Text;
                p.FirstName = txtFN.Text;
                p.LastName = txtLN.Text;
                p.Phone = txtPhone.Text;
                p.Jmbg = txtJMBG.Text;

                if (string.IsNullOrEmpty(p.FirstName))
                {
                    MessageBox.Show("Name is required.");
                    txtFN.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(p.LastName))
                {
                    MessageBox.Show("Last name is required.");
                    txtLN.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(p.Jmbg))
                {
                    MessageBox.Show("JMBG is required.");
                    txtJMBG.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(p.Email))
                {
                    MessageBox.Show("Email is required.");
                    txtMail.Focus();
                    return false;
                }

                if (!p.Email.Contains("@"))
                {
                    MessageBox.Show("Email not valid.");
                    txtMail.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(p.Phone))
                {
                    MessageBox.Show("Phone is requred.");
                    txtPhone.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(p.Address))
                {
                    MessageBox.Show("Address is required.");
                    txtAddP.Focus();
                    return false;
                }

                rez = komunikacija.UpdateClient(p);

            }
            if(company!=null)
            {
                Company c = new Company() { ClientID=company.ClientID};
                c.Address = txtAdrC.Text;
                c.Name = txtName.Text;
                c.Pib = txtPIB.Text;
                c.RegistrationNo = txtRegNo.Text;

                if(string.IsNullOrEmpty(c.Name))
                {
                    MessageBox.Show("Name is required.");
                    txtName.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(c.Pib))
                {
                    MessageBox.Show("PIB is required.");
                    txtPIB.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(c.RegistrationNo))
                {
                    MessageBox.Show("Registration number is required.");
                    txtRegNo.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(c.Address))
                {
                    MessageBox.Show("Address is required.");
                    txtAdrC.Focus();
                    return false;
                }

                rez = komunikacija.UpdateClient(c);

            }

            if (rez == null)
            {
                MessageBox.Show("System can't update client.");
                return false;
            }
            else
            {
                MessageBox.Show("Successfully updated client.");
                return true;
            }

          
        }

        internal static bool Login(TextBox txtUser, TextBox txtPass)
        {
            agent = new Agent();
            agent.Username = txtUser.Text;
            agent.Password = txtPass.Text;
            agent = (Agent)komunikacija.findAgent(agent);

            if (agent == null)
            {
                MessageBox.Show("Sistem can't find agent with this username and password.");
                return false;
            }
            else
            {
                MessageBox.Show("Successfully log in.");
                return true;
            }
        }

        internal static bool AddClient(TextBox txtAddP, TextBox txtAdrC, TextBox txtFN, TextBox txtJMBG, TextBox txtLN, TextBox txtMail, TextBox txtName, TextBox txtPhone, TextBox txtPIB, TextBox txtRegNo, RadioButton rbPerson)
        {
            Object rez = null;
           
            if (rbPerson.Checked)
            {
                Person p = new Person();
                p.Address = txtAddP.Text;
                p.Email = txtMail.Text;
                p.FirstName = txtFN.Text;
                p.LastName = txtLN.Text;
                p.Phone = txtPhone.Text;
                p.Jmbg = txtJMBG.Text;

                if (string.IsNullOrEmpty(p.FirstName))
                {
                    MessageBox.Show("Name is required.");
                    txtFN.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(p.LastName))
                {
                    MessageBox.Show("Last name is required.");
                    txtLN.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(p.Jmbg))
                {
                    MessageBox.Show("JMBG is required.");
                    txtJMBG.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(p.Email))
                {
                    MessageBox.Show("Email is required.");
                    txtMail.Focus();
                    return false;
                }

                if (!p.Email.Contains("@"))
                {
                    MessageBox.Show("Email not valid.");
                    txtMail.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(p.Phone))
                {
                    MessageBox.Show("Phone is requred.");
                    txtPhone.Focus();
                    return false;
                }


                if (string.IsNullOrEmpty(p.Address))
                {
                    MessageBox.Show("Address is required.");
                    txtAddP.Focus();
                    return false;
                }

                rez = komunikacija.AddClient(p);

            }
            else
            {
                Company c = new Company();
                c.Address = txtAdrC.Text;
                c.Name = txtName.Text;
                c.Pib = txtPIB.Text;
                c.RegistrationNo = txtRegNo.Text;
              
                if (string.IsNullOrEmpty(c.Name))
                {
                    MessageBox.Show("Name is required.");
                    txtName.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(c.Pib))
                {
                    MessageBox.Show("PIB is required.");
                    txtPIB.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(c.RegistrationNo))
                {
                    MessageBox.Show("Registration number is required.");
                    txtRegNo.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(c.Address))
                {
                    MessageBox.Show("Address is required.");
                    txtAdrC.Focus();
                    return false;
                }

                rez = komunikacija.AddClient(c);

            }

            if (rez == null)
            {
                MessageBox.Show("Sistem can't add client.");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem successfully added client.");
                return true;
            }
        }

        internal static bool SelectClient(DataGridView dataGridView1)
        {
            try
            {
                Client c = dataGridView1.CurrentRow.DataBoundItem as Client;
                c = komunikacija.SelectClient(c)as Client;

                person = c as Person;
                company = c as Company;


                if (person == null && company == null)
                {
                    MessageBox.Show("Sistem can't get selected client.");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem selected client.");
                    return true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Select client.");
                return false;
            }
        }

        internal static void GetLIstClients(DataGridView dataGridView1, RadioButton rbPerson, TextBox txtFilter)
        {

            try
            {
                if (rbPerson.Checked)
                {
                    if (string.IsNullOrEmpty(txtFilter.Text))
                    {
                        dataGridView1.DataSource = komunikacija.GetListClients(new Person());
                    }
                    else
                    {
                        Person p = new Person();
                        p.USLOV = " FirstName like '" + txtFilter.Text + "%' or LastName like '" + txtFilter.Text + "%'";
                        dataGridView1.DataSource = komunikacija.SearchClients(p);
                    }
                }
                else
                {

                    if (string.IsNullOrEmpty(txtFilter.Text))
                    {
                        dataGridView1.DataSource = komunikacija.GetListClients(new Company());
                    }
                    else
                    {
                        Company c = new Company();
                        c.USLOV = " Name like '" + txtFilter.Text + "%' or PIB like '" + txtFilter.Text + "%'";
                        dataGridView1.DataSource = komunikacija.SearchClients(c);
                    }
                }
                if(dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("System can't find clients.");
                }
                else
                {
                    //MessageBox.Show("System successfully find clients.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem can't get client.");
            }
        }
    }
}
