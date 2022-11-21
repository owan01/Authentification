using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAuthentification
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ActiveTab(TabPage tabPage)
        {
           //Vérifier cette méthode
        }

        private void btnLiveAuth_Click(object sender, EventArgs e)
        {
            LiveAuthForm liveAuthForm = new LiveAuthForm();
            liveAuthForm.Show();
            this.Hide();
        }

        private void btnManualAuth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirect to Manual Auth");
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redict to records list");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LiveAuthForm liveAuthForm = new LiveAuthForm();
            liveAuthForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirect to manual Auth");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirect to records");
        }

        private void espaceAdministrateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new rootAccessForm();
            frm.Show();
            this.Hide();
        }

        private void guideDutilisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Most implement user guide access !");
        }

        private void rapportDeBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Must implement Bug Report !");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
