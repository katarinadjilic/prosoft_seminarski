using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormaServer : Form
    {
        Server s;
        public FormaServer()
        {
            InitializeComponent();
        }

        private void FormaServer_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                lblStatus.Text = "Server is running on port 20000!";
                lblStatus.ForeColor = Color.Green;
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.listaTokova.Count > 0)
            {
                MessageBox.Show("Server can't be stopped!\nTher are clients.");
                return;
            }

            if (s.zaustaviServer())
            {
                lblStatus.Text = "Server is not running!";
                lblStatus.ForeColor = Color.Red;
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }

        }
    }
}
