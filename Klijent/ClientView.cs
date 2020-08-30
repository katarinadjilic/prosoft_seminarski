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
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientInsert().ShowDialog();
            this.Show();
            txtFilter_TextChanged(sender, e);
        }

        private void ClientPregled_Load(object sender, EventArgs e)
        {
            KontrolerKI.GetLIstClients(dataGridView1, rbPerson, txtFilter);
        }

        private void rbPerson_CheckedChanged(object sender, EventArgs e)
        {
            KontrolerKI.GetLIstClients(dataGridView1, rbPerson, txtFilter);
        }

        private void rbCompany_CheckedChanged(object sender, EventArgs e)
        {
            KontrolerKI.GetLIstClients(dataGridView1, rbPerson, txtFilter);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            KontrolerKI.GetLIstClients(dataGridView1, rbPerson, txtFilter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.SelectClient(dataGridView1))
            {
                this.Hide();
                new ClientDetails().ShowDialog();
                this.Show();
                txtFilter_TextChanged(sender, e);
            }
        }
    }
}
