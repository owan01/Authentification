using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAuthentification
{
    public partial class LiveAuthForm : Form
    {
        #region Variables
        int testid = 0;
        private VideoCapture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        private Mat frame = new Mat();
        CascadeClassifier classifier = new CascadeClassifier(@"C:\haarcascad\haarcascade.xml");
        private bool faceDetectionEnabled = true;
        private bool EnableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        List<string> PersonsNames = new List<string>();
        #endregion

        public LiveAuthForm()
        {
            InitializeComponent();
        }

        private void LiveAuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void LiveAuthForm_Load(object sender, EventArgs e)
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
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

            //Detection du visage : Etape 2
            if (faceDetectionEnabled)
            {
                //Conversion en gris de l'image BGR
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(grayImage, grayImage);
                Rectangle[] faces = classifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                if (faces.Length > 0)
                {
                    int faceId = 0;
                    foreach (var face in faces)
                    {
                        // Rectangle autour de la face detectée 
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 2);

                        //ajout de la personne detectée à la base de données : à Implémenter 
                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;
                        ////picDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                        ////picDetected.Image = resultImage.ToBitmap();
                        if (EnableSaveImage)
                        {
                            //We will create a directory if does not exists!
                            string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                            if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);
                            //we will save 10 images with delay a second for each image 
                            //to avoid hang GUI we will create a new task
                            Task.Factory.StartNew(() =>
                            {
                                for (int i = 0; i < 10; i++)
                                {
                                    //resize the image then saving it
                                    resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\owan_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                    Thread.Sleep(1000);
                                }
                            });

                        }
                        /*
                        EnableSaveImage = false;
                        if (btnAddPerson.InvokeRequired)
                        {
                            btnAddPerson.Invoke(new ThreadStart(delegate
                            {
                                btnAddPerson.Enabled = true;
                            }));
                        }*/
                        if (isTrained)
                        {
                            Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                            CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                            var result = recognizer.Predict(grayFaceResult);
                            Debug.WriteLine(result.Label + "a été reperés sur l'image");
                            //pictureBox1.Image = grayFaceResult.Bitmap;
                            //pictureBox2.Image = TrainedFaces[result.Label].Bitmap;
                            //Debug.WriteLine(result.Label + ". " + result.Distance);
                            //Here results found known faces
                            if (result.Label != -1 && result.Distance < 2000)
                            {
                                CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                    FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                            }
                            //here results did not found any know faces
                            else
                            {
                                CvInvoke.PutText(currentFrame, "Absent de la BDD", new Point(face.X - 2, face.Y - 2),
                                    FontFace.HersheyComplex, 1.0, new Bgr(Color.Yellow).MCvScalar);
                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                                Debug.WriteLine("Aucune figure connue n'est présent sur la scène");

                            }
                        }
                    }
                }

            }
            //injection de la video dans la pictureBox : picCapture
            picCapture.Image = currentFrame.ToBitmap();

            //suppression des frames pour éviter la consommation de la mémoire
            if (currentFrame != null)
                currentFrame.Dispose();
        }

        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 7000;       //TrainedFaces.Clear();
            //PersonsLabes.Clear();
            //PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    Image<Gray, Byte>[] Faces = TrainedFaces.ToArray();
                    VectorOfMat vectorOfMat = new VectorOfMat();
                    vectorOfMat.Push(Faces);
                    int[] labels = PersonsLabes.ToArray();
                    VectorOfInt vectorOfInt = new VectorOfInt();
                    vectorOfInt.Push(labels);
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(vectorOfMat, vectorOfInt);
                    isTrained = true;
                    Debug.WriteLine(ImagesCount);
                    Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception e)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + e.Message);
                return false;
            }

        }

        private void btnTrained_Click(object sender, EventArgs e)
        {
            isTrained = true;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            EnableSaveImage = true;
        }

        private void btnDetection_Click(object sender, EventArgs e)
        {
            faceDetectionEnabled = true;
        }

        private void btnRecognition_Click(object sender, EventArgs e)
        {

        }
    }
}
