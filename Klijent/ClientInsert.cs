using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class ClientInsert : Form
    {
        public ClientInsert()
        {
            InitializeComponent();
        }

        private void ClientInsert_Load(object sender, EventArgs e)
        {
            gbCompany.Location = gbPerson.Location;
            if (rbCompany.Checked) gbCompany.Visible = true;
            if (rbPerson.Checked) gbPerson.Visible = true;
        }

        private void rbPerson_CheckedChanged(object sender, EventArgs e)
        {            
                gbPerson.Visible = true;
                gbCompany.Visible = false;          
        }

        private void rbCompany_CheckedChanged(object sender, EventArgs e)
        {
            gbPerson.Visible = false;
            gbCompany.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.AddClient(txtAddP,txtAdrC,txtFN,txtJMBG,txtLN,txtMail,txtName,txtPhone,txtPIB,txtRegNo,rbPerson)) this.Close();
        }
    }
}
