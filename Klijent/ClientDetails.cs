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
    public partial class ClientDetails : Form
    {
        public ClientDetails()
        {
            InitializeComponent();
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
            gbCompany.Location = gbPerson.Location;

            KontrolerKI.LoadClient(txtAddP, txtAdrC, txtFN, txtJMBG, txtLN, txtMail, txtName, txtPhone, txtPIB, txtRegNo, gbCompany, gbPerson);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.UpdateClient(txtAddP, txtAdrC, txtFN, txtJMBG, txtLN, txtMail, txtName, txtPhone, txtPIB, txtRegNo)) this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.DeleteClient()) this.Close();
        }
    }
}
