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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            this.Text = "Agent: " + KontrolerKI.agent.ToString();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientView().ShowDialog();
            this.Show();
        }

        private void insurancePolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PolicyView().ShowDialog();
            this.Show();
        }
    }
}
