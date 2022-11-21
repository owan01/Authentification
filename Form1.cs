using System;
using System.Windows.Forms;

namespace FaceAuthentification
{
    public partial class frmAuth : Form
    {
        private static NewUserForm newUserForm;
        public frmAuth()
        {
            InitializeComponent();

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            newUserForm = new NewUserForm();
            newUserForm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            
            if(txtLogin.Text!=string.Empty  && txtPassword.Text!=string.Empty)
            {
               
                DataBaseManager dbm = new DataBaseManager();
                dbm.CheckIfUserIsValid(login, password);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Le Login et mot de passe doivent tous les deux être renseignés !", "Désolé !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        
    }
}
