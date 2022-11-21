using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FaceAuthentification
{
    class DataBaseManager
    {
        public string tableName = null;
        private static MainForm mainForm;
        //Ajout d'un nouvel utilisateur dans la table UserTab
        public void AddNewUser(string pNom, string pPostnom, string pPrenom, string pNumeroNat, string pLogin, string pPassword)
        {
            using (IDbConnection myconnection = new SQLiteConnection(@"Data Source=.\FaceAuth.db;Version=3;"))
            {
                myconnection.Open();
                //Gestion des doublons
                SQLiteCommand myCommand;
                myCommand = new SQLiteCommand("SELECT COUNT (*) FROM user WHERE Login=@userName", (SQLiteConnection)myconnection);
                myCommand.Parameters.AddWithValue("@userName", pLogin);
                int compteur = int.Parse(myCommand.ExecuteScalar().ToString());
                myCommand.Parameters.Clear();
                if (compteur > 0)
                {
                    MessageBox.Show("L'utilisateur que vous essayez de créer existe déjà", "Erreurs des Données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Ajout d'un nouvel utilisateur
                    myCommand = new SQLiteCommand("INSERT INTO User (Login, PassWord, UserInit, Nom, PostNom, Prenom, NumNat, UserID) VALUES (@userName, @userPassword, @userInit, @userNom, @userPostNom, @userPrenom, @userNumNat, @userID)", (SQLiteConnection)myconnection);
                    myCommand.Parameters.AddWithValue("@userName", pLogin);
                    myCommand.Parameters.AddWithValue("@userPassword", pPassword);
                    myCommand.Parameters.AddWithValue("@userInit", DateTime.Now.ToShortDateString());
                    myCommand.Parameters.AddWithValue("@userNom", pNom);
                    myCommand.Parameters.AddWithValue("@userPostNom", pPostnom);
                    myCommand.Parameters.AddWithValue("@userPrenom", pPrenom);
                    myCommand.Parameters.AddWithValue("@userNumNat", pNumeroNat);
                    myCommand.Parameters.AddWithValue("@userID", getSetUserID());
                    myCommand.ExecuteNonQuery();
                    myCommand.Parameters.Clear();
                    DialogResult dialogResult = MessageBox.Show("l'Utilisateur"+pPrenom+ "a été créé avec succès", "Réussi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        Form form = new frmAuth();
                        form.Show();
                    }
                }
                myconnection.Close();
            }
        }
        public void AddNewStudent(string pNomEtudiant, string pPostNomEtudiant, string pPreNomEtudiant, string pIdEtudiant, Byte[] pProfile)
        {
            using (IDbConnection myconnection = new SQLiteConnection(@"Data Source=.\FaceAuth.db;Version=3;"))
            {
                myconnection.Open();
                //Gestion des doublons
                SQLiteCommand myCommand;
                myCommand = new SQLiteCommand("SELECT COUNT (*) FROM Etudiant WHERE Nom=@Nom AND PostNom=@PostNom AND PreNom=@PreNom", (SQLiteConnection)myconnection);
                myCommand.Parameters.AddWithValue("@Nom", pNomEtudiant);
                myCommand.Parameters.AddWithValue("@PostNom", pPostNomEtudiant);
                myCommand.Parameters.AddWithValue("@PreNom", pPreNomEtudiant);
                int compteur = int.Parse(myCommand.ExecuteScalar().ToString());
                myCommand.Parameters.Clear();
                if (compteur > 0)
                {
                    MessageBox.Show("L'utilisateur que vous essayez de créer existe déjà", "Erreurs des Données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Ajout d'un nouvel utilisateur
                    myCommand = new SQLiteCommand("INSERT INTO Etudiant (Nom, PostNom, PreNom, IdEtudiant, Profile) VALUES (@Nom, @PostNom, @PreNom, @IdEtudiant, @Profile)", (SQLiteConnection)myconnection);
                    myCommand.Parameters.AddWithValue("@Nom", pNomEtudiant);
                    myCommand.Parameters.AddWithValue("@PostNom", pPostNomEtudiant);
                    myCommand.Parameters.AddWithValue("@PreNom", pPreNomEtudiant);
                    myCommand.Parameters.AddWithValue("@IdEtudiant", pIdEtudiant);
                    myCommand.Parameters.AddWithValue("@Profile", pProfile);
                    myCommand.ExecuteNonQuery();
                    myCommand.Parameters.Clear();
                }
                myconnection.Close();
            }
        }

        //Vérification de la validité des données de connexion
        public void CheckIfUserIsValid(string pLogin, string pPassword)
        {
            using (IDbConnection myconnection = new SQLiteConnection(@"Data Source=.\FaceAuth.db;Version=3;"))
            {
                myconnection.Open();
                //Vérification de la validité de l'utilisateur
                SQLiteCommand myCommand;
                myCommand = new SQLiteCommand("SELECT COUNT (*) FROM user WHERE Login=@userName AND PassWord=@passWord", (SQLiteConnection)myconnection);
                myCommand.Parameters.AddWithValue("@userName", pLogin);
                myCommand.Parameters.AddWithValue("@passWord", pPassword);
                int compteur = int.Parse(myCommand.ExecuteScalar().ToString());
                myCommand.Parameters.Clear();
                myconnection.Close();
                if (compteur > 0)
                {
                    mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Les données entrées sont invalides, \n Voulez-vous créer un nouvel utilisateur", "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        Form form = new NewUserForm();
                        form.ShowDialog();
                    }
                    else if (dialog==DialogResult.No)
                    {
                        Form frm = new frmAuth();
                        frm.Show();
                    }
                }
            }
            
        }
        public string getSetUserID()
        {
            DateTime dt = DateTime.Now;
            string userID=dt.Year.ToString()+dt.Month.ToString()+dt.Day.ToString()+dt.Hour.ToString()+dt.Minute.ToString()+dt.Second.ToString()+dt.Millisecond.ToString();
            return userID;
        }
        public void DeleteUser(string pUserID)
        {
            using (IDbConnection myconnection = new SQLiteConnection(@"Data Source=.\FaceAuth.db;Version=3;"))
            {
                myconnection.Open();
                SQLiteCommand myCommand;
                myCommand = new SQLiteCommand("DELETE FROM user WHERE UserID=@userID", (SQLiteConnection)myconnection);
                myCommand.Parameters.AddWithValue("@userID", pUserID);
                myCommand.ExecuteNonQuery();
                myCommand.Parameters.Clear();
                myconnection.Close();
            }
        }
        public void RemplirGridView(String myCommandText, DataGridView myDataGridView)
        {
            //Chargement des enregistrement de la base de données dans la dataGridView
            SQLiteConnection myConnection = new SQLiteConnection(@"Data Source=.\FaceAuth.db;Version=3;");
            SQLiteCommand myCommand = new SQLiteCommand();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter();
            DataSet myDataSet = new DataSet();
            myConnection.Open();
            myCommand.Connection = myConnection;
            myCommand.CommandText = myCommandText;
            myDataAdapter.SelectCommand = myCommand;
            myDataAdapter.Fill(myDataSet, "DataTable");
            MainForm myMainForm = new MainForm();
            myDataGridView.DataSource = myDataSet.Tables["DataTable"];
            myConnection.Close();
        }
    }
}
