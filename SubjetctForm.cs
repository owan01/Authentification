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
    public partial class SubjetctForm : Form
    {
        #region Constructeur
        public SubjetctForm()
        {
            InitializeComponent();
        }
        #endregion Constructeur 
        //---------------------------------------------------
        #region Evenement sur les composants 
        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent();
        }

        private void lblNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent();
        }
        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            DataBaseManager dbm = new DataBaseManager();
            dbm.tableName = "Etudiant";
            UserManager userManager = new UserManager();
            string commandText = "SELECT * FROM Etudiant WHERE Prenom LIKE '%" + userManager.searchBox.Text + "%'";
            dbm.RemplirGridView(commandText, userManager.userGridView);
            userManager.Show();
            this.Hide();
        }

        private void lblManageStudent_Click(object sender, EventArgs e)
        {

        }
        #endregion Evenements sur les composants 
        //----------------------------------------
        #region Méthodes de la classe 
        public void NewStudent()
        {
            Form frm = new NewStudentForm();
            frm.Show();
            this.Hide();

        }
        public void ManageStudent()
        {
            //Gestion d'étudiants présents sur la base de données 
            
        }
        #endregion Méthodes de la classe 

        
    }
}
