using System;
using System.Windows.Forms;

namespace FaceAuthentification
{
    public partial class NewUserForm : Form
    {
        private string Nom;
        private string Postnom;
        private string Prenom;
        private string NumeroNat;
        private string Login;
        private string Password;
        private Boolean isValid = false;
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Form frm = new frmAuth();
            frm.Show();
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "OWAN")
            {
                GetFormValues();
                CheckValuesValidity();
                DataBaseManager dbm = new DataBaseManager();
                dbm.AddNewUser(Nom, Postnom, Prenom, NumeroNat, Login, Password);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas autorisé à créer un nouvel utilisateur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
        private void GetFormValues()
        {
            this.Nom = txtNom.Text.ToUpper();
            this.Postnom = txtPostNom.Text.ToUpper();
            this.Prenom = txtPrenom.Text.ToUpper();
            this.NumeroNat = txtNumNat.Text.ToUpper();
            this.Login = txtLogin.Text.ToUpper();
            this.Password = txtPassword.Text.ToUpper();
        }
        private void CheckValuesValidity()
        {/*
            foreach (Control ctrl in GboxIdentite.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    if (ctrl.Text.Length < 5)
                    {
                        MessageBox.Show("Asuurez-vous d'avoir entré des données valides !");
                        isValid = false;
                    }
                    else
                    {
                        isValid = true;
                    }
                }
            }
            foreach (Control control in GboxConnectionData.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (control.Text.Length < 5)
                    {
                        MessageBox.Show("Asuurez-vous d'avoir entré des données valides !");
                        isValid = false;
                    }
                    else
                    {
                        isValid = true;
                    }
                }
            }*/

        }
    }
}
