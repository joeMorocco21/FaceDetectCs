using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        List<Image<Gray, Byte>> TrainedFace = new List<Image<Gray, byte>>();
        List<int> PersonLabs = new List<int>();
        private bool enableSaveImage = false;
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
            if(faceDetectEnable)
            {
                //Convert from Bgr to Gray Image
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                //Enhance image to get better result
                CvInvoke.EqualizeHist(grayImage, grayImage);
                Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage,1.1,3,Size.Empty, Size.Empty);
                //if faces detected
                if(faces.Length > 0)
                {
                    //Draw square around each faces
                    foreach(var face in faces)
                    {
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Yellow).MCvScalar, 2);
                        //Assign the face to the picture Box face picCapture
                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;
                        picCapture.SizeMode = PictureBoxSizeMode.StretchImage;
                        picCapture.Image = resultImage.Bitmap;

                        if(enableSaveImage)
                        {
                            //we will create a directory if does not exists
                            string path = Directory.GetCurrentDirectory() + @"\TrainedImages";

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
            saveBtn.Enabled = true;
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

        }
    }
}
