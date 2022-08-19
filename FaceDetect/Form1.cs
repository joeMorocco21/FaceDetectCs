using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;

namespace FaceDetect
{
    public partial class Form1 : Form
    {
        #region Variables
        private  Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool faceDetectEnable = false;
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        Image<Bgr,Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonLabs = new List<int>();
        bool enableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += ProccessFrame;
            videoCapture.Start();
        }

        private void ProccessFrame(object sender, EventArgs e)
        {
            //Video Capture
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, byte>().Resize(picCam.Width, picCam.Height, Inter.Cubic);
                //Face Detection
                if (faceDetectEnable)
                {
                    //Convert from Bgr to Gray Image
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                    //Enhance image to get better result
                    CvInvoke.EqualizeHist(grayImage, grayImage);
                    Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                    //if faces detected
                    if (faces.Length > 0)
                    {
                        //Draw square around each faces
                        foreach (var face in faces)
                        {
                            CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Yellow).MCvScalar, 2);
                            //Assign the face to the picture Box face picCapture
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            picCapture.SizeMode = PictureBoxSizeMode.StretchImage;
                            picCapture.Image = resultImage.Bitmap;

                            if (enableSaveImage)
                            {
                                //we will create a directory if does not exists
                                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);
                                Task.Factory.StartNew(() =>
                                {
                                    for (int i = 0; i < 10; i++)
                                    {
                                    //resize the image then saving it
                                    resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + textPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                    Thread.Sleep(1000);
                                        
                                    }
                                });

                            }
                            enableSaveImage = false;
                            if(PersonBtn.InvokeRequired)
                            {
                                PersonBtn.Invoke(new ThreadStart(delegate
                                {
                                    PersonBtn.Enabled = true;
                                }));
                            }
                            //Recognize the face
                            if(isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                picBox1.Image = grayFaceResult.Bitmap;
                                picBox2.Image = TrainedFaces[result.Label].Bitmap;
                                Debug.WriteLine(result.Label+". "+result.Distance);
                            if (result.Label != -1 && result.Distance < 2000)
                            {
                                CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2), FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                            }
                            //result did not found any know faces
                            else
                            {
                                CvInvoke.PutText(currentFrame, "I DONT KNOW YOU SORRY :(", new Point(face.X - 2, face.Y - 2), FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                            }
                            }
                        }
                    }
                }

                //render video capture into the picture box picCapture

                picCam.Image = currentFrame.Bitmap;
            }
       

        private void button2_Click(object sender, EventArgs e)
        {
            faceDetectEnable = true;
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void PersonBtn_Click(object sender, EventArgs e)
        {
            
            PersonBtn.Enabled = false;
            enableSaveImage = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            PersonBtn.Enabled=true;
            enableSaveImage = false;
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            TrainImageFromDir();
        }
        private bool TrainImageFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 7000;
            TrainedFaces.Clear();
            PersonLabs.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string [] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, Byte> TrainedImage = new Image<Gray, Byte>(file);
                    CvInvoke.EqualizeHist(TrainedImage, TrainedImage);
                    TrainedFaces.Add(TrainedImage);
                    PersonLabs.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " +name);
                }
                if (TrainedFaces.Count() > 0)
                {
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonLabs.ToArray());
                    isTrained = true;
                    return true;
                }
                else
                {
                    isTrained=false;
                    return false;
                }
            }
            catch (Exception ex)
            {

                isTrained = false;
                MessageBox.Show("Error in Train Images" + ex.Message);
                return false;
            }
            
        }

        private void webCamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void activationDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
