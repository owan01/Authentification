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
    public partial class UserManager : Form
    {
        private string tableName = null;
        private static string Commandtext;
        public UserManager()
        {
            InitializeComponent();
            btnSearchUser.PerformClick();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            DataBaseManager DBM = new DataBaseManager();
            //Commandtext = "SELECT * FROM"+tableName+ "WHERE Prenom LIKE '%" + searchBox.Text + "%'";
            Commandtext = "SELECT * FROM User";
            DBM.RemplirGridView(Commandtext, userGridView);
        }

        private void UserManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            rootAccessForm rootAccessForm = new rootAccessForm();
            rootAccessForm.Show();
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            DataBaseManager DBM = new DataBaseManager();
            Commandtext = "SELECT * FROM User";
            DBM.RemplirGridView(Commandtext, userGridView);
        }
    }
}
