using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAuthentification
{
    public partial class NewStudentForm : Form
    {
        private string NomEtudiant;
        private string PostNomEtudiant;
        private string PreNomEtudiant;
        private string IdEtudiant;
        private Bitmap ProfileEtudiant = null;
        private VideoCapture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        private Mat frame = new Mat();
        #region Constructeur de la classe
        public NewStudentForm()
        {
            InitializeComponent();
        }
        #endregion Constructeur de la classe

        #region Evenements sur le formulaire
        //les evenements sur les composants doivent être ici
        

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Capture de la Vidéo
            Capture();
            //Sauvegarde des images dans un dossiers
        }

        private void NewStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClose();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            if (txtNomEtudiant.Text != String.Empty)
            {
                ResetComponent();
            }
            else
            {
                OnClose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSave();
            ResetComponent();
        }
        #endregion Evenements sur le formulaire
        #region Méthodes de la classe
        //Fermeture de la fenêtre
        public void OnClose()
        {
            Form frm = new rootAccessForm();
            frm.Show();
            this.Hide();
        }
        //Sauvegarde d'information dans la BDD
        public void OnSave()
        {
            NomEtudiant= txtNomEtudiant.Text;
            PostNomEtudiant = txtPostNomEtudiant.Text;
            PreNomEtudiant = txtPrenomEtudiant.Text;
            DataBaseManager dbm = new DataBaseManager();
            DateTime dt = DateTime.Now;
            IdEtudiant = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString() + dt.Millisecond.ToString();
            ProfileEtudiant = (Bitmap)picProfile.Image;
            byte[] Profile = ImageToByte(ProfileEtudiant);
            dbm.AddNewStudent(NomEtudiant, PostNomEtudiant, PreNomEtudiant, IdEtudiant, Profile);
            MessageBox.Show("L'étudiant  " + PreNomEtudiant + "  a été créé avec succès", "Réussi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Réinitialisation des zones de texte après l'enregistrement
        public void ResetComponent()
        {
            txtNomEtudiant.Text = String.Empty;
            txtPostNomEtudiant.Text = String.Empty;
            txtPrenomEtudiant.Text = string.Empty;
        }
        //Conversion de l'image en Byte pour sauvegarde dans le champ Blob de la BDD
        public byte[] ImageToByte(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                return ms.ToArray();
            }

        }
        public void Capture()
        {
            if (videoCapture != null)
            {
                videoCapture.Dispose();
            }
            videoCapture = new VideoCapture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            //capture de la video : Etape 1
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(picProfile.Width, picProfile.Height, Inter.Cubic);
            //injection de la video dans la pictureBox : picProfile
            picProfile.Image = currentFrame.ToBitmap();
            //suppression des frames pour éviter la consommation de la mémoire
            if (currentFrame != null)
                currentFrame.Dispose();
        }
        #endregion Méthodes de la classe
    }
}
