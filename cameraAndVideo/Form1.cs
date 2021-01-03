using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace cameraAndVideo
{
    public partial class Form1 : Form
    {
        VideoCapture capture;
        VideoWriter writer;

        DateTime dateTime;
        DateTime dateTime_finish;
        int frameCount = 0;
        System.Threading.Timer timer;

        bool setupFinished = false;

        bool recordingEnabled = false;
        private int framesRecorded;
        private int maxFrames;
        string destinationPath = @"D:\Google_drive\Visual Studio - programi\EMGU CV\";
        int videoNumber = 0;
        double fps = 0;



        Mat m = new Mat();
        Mat last_m = new Mat();



        Image<Gray, byte> currentFrame;
        Image<Gray, byte> lastFrame;
        Image<Gray, byte> diffFrame;

        bool firstFrame = true;


        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(destinationPath);

        }



        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                capture = new Emgu.CV.VideoCapture(0);
            }
            //capture.ImageGrabbed += Capture_ImageGrabbed;              
            capture.Start();

            dateTime = DateTime.Now;
            dateTime_finish = dateTime.AddMilliseconds(10000);
            frameCount = 0;

            timer = new System.Threading.Timer(new TimerCallback(TickTimer), null, 1000, 200);

        }

        private void TickTimer(object state)
        {
            int moves;
            frameCount++;

            if (DateTime.Now > dateTime_finish && setupFinished == false)
            {
                setupFinished = true;
                //fps = (double)frameCount / (double)10;
            }


            try
            {
                if (firstFrame)
                {
                    capture.Read(m);
                    pictureBox1.Image = m.ToBitmap();
                    firstFrame = false;
                    last_m = m.Clone();
                }
                else
                {
                    capture.Read(m);


                    currentFrame = m.ToImage<Gray, byte>();
                    lastFrame = last_m.ToImage<Gray, byte>();

                    pictureBox1.Image = currentFrame.ToBitmap();

                    diffFrame = currentFrame.AbsDiff(lastFrame);
                    moves = 0;
                    for (int i = 0; i < diffFrame.Rows; i += 10)
                    {
                        for (int j = 0; j < diffFrame.Cols; j += 10)
                        {
                            if (diffFrame.Data[i, j, 0] > 25)
                            {
                                moves++;
                            }
                        }
                    }
                    Console.WriteLine(moves.ToString());

                    // moves = diffFrame.CountNonzero()[0];
                    Console.WriteLine(moves);

                    if ((moves > 20) && (recordingEnabled == false) && (DateTime.Now > dateTime_finish))
                    {
                        recordingEnabled = true;
                        maxFrames = 100;
                        framesRecorded = 0;
                    }
                    if ((moves > 20) && (recordingEnabled == true) && (framesRecorded > (maxFrames - 40)))
                    {
                        maxFrames += 40;
                        Console.WriteLine("Dodano 40 okvira!!");
                    }


                    //pictureBox2.Image = diffFrame.ToBitmap();

                    last_m = m.Clone();
                }

                if ((recordingEnabled == true) && (DateTime.Now > dateTime_finish))
                {

                    if (writer == null)
                    {
                        int fourcc = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FourCC));
                        int width = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth));
                        int height = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight));
                        writer = new VideoWriter(destinationPath + "recorded" + (videoNumber + 1).ToString() + ".mp4", fourcc, 5, new Size(width, height), false);
                        videoNumber++;
                    }
                    writer.Write(m);
                    framesRecorded++;
                    if (framesRecorded >= maxFrames)
                    {
                        framesRecorded = 0;
                        recordingEnabled = false;
                        writer.Dispose();
                        writer = null;
                    }

                }

            }
            catch (Exception ex)
            {
            }
        }

        


        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recordingEnabled = false;
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            timer.Dispose();
            timer = null;
            if (capture != null)
            {
                capture.Dispose();
                capture = null;
            }
            if (writer.IsOpened)
            {
                writer.Dispose();
                writer = null;
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Pause();
            }
        }

        private void startRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                return;
            }

            if (writer == null)
            {
                int fourcc = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FourCC));
                int width = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth));
                int height = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight));
                writer = new VideoWriter(destinationPath, fourcc, fps, new Size(width, height), false);
            }
            recordingEnabled = true;
        }

        private void stopRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writer.Dispose();
            writer = null;
            recordingEnabled = false;
        }
    }
}
