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
    public partial class rootAccessForm : Form
    {
        
        public rootAccessForm()
        {
            InitializeComponent();
        }

        private void btnRecordManager_Click(object sender, EventArgs e)
        {
            Form frm = new SubjetctForm();
            frm.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Must implement Settings !");
        }

        private void btnLogReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Must implement Events report manager ! ");
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Must implement Doc Historique ! ");
        }

        private void rootAccessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = new MainForm();
            frm.Show();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }
        private void btnUsersAccounts_Click_1(object sender, EventArgs e)
        {
            string tableName = "User";
            DataBaseManager dbm = new DataBaseManager();
            dbm.tableName = tableName;
            UserManager userManager = new UserManager();
            string commandText = "SELECT * FROM User WHERE Prenom LIKE '%" + userManager.searchBox.Text + "%'";
            dbm.RemplirGridView(commandText, userManager.userGridView);
            userManager.Show();
            this.Hide();
        }

        private void btnPrintReport_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Must Implement Docs Printers");
        }

        private void lblPrintReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Must Implement Docs Printers");
        }
    }
}
