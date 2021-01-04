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
        private int maxFrames;
        string destinationPath = @"D:\Google_drive\Visual Studio - programi\EMGU CV\";
        int videoNumber = 0;
        double fps = 0;

        bool surveillanceOn = false;

        int framesRecorded = 0;



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
            showOperatingMode(0);
            setSurvStatus(0);
            startCapturingVideo();
        }

        private void setSurvStatus(int status)
        {
            if(status == 0)
            {
                label_survStatus.Text = "Surveillance OFF!";
                label_survStatus.ForeColor = Color.Red;
            }
            else if(status == 1)
            {
                label_survStatus.Text = "Surveillance ON!";
                label_survStatus.ForeColor = Color.Green;
            }
            else
            {

            }
        }

        private void showOperatingMode(int mode)
        {
            if(mode == 0)
            {
                button_startSurv.Show();
                button_stopSurv.Show();

                label_automaticStart.Hide();
                label_automaticStop.Hide();
                label_colonStart.Hide();
                label_colonStop.Hide();
                comboBox_startHours.Hide();
                comboBox_startMinutes.Hide();
                comboBox_stopHours.Hide();
                comboBox_stopMinutes.Hide();
            }
            else if(mode == 1)
            {
                button_startSurv.Hide();
                button_stopSurv.Hide();

                label_automaticStart.Show();
                label_automaticStop.Show();
                label_colonStart.Show();
                label_colonStop.Show();
                comboBox_startHours.Show();
                comboBox_startMinutes.Show();
                comboBox_stopHours.Show();
                comboBox_stopMinutes.Show();
            }
            else
            {

            }
        }

        private void startCapturingVideo()
        {
            if (capture == null)
            {
                capture = new Emgu.CV.VideoCapture(0);
            }

            capture.Start();

            dateTime = DateTime.Now;
            dateTime_finish = dateTime.AddMilliseconds(10000);
            frameCount = 0;

            timer = new System.Threading.Timer(new TimerCallback(TickTimer), null, 1000, 125);
        }


        private void TickTimer(object state)
        {
            int moves;
            if (DateTime.Now > dateTime_finish && setupFinished == false)
            {
                setupFinished = true;       
            }

            try
            {
                if(firstFrame)
                {
                    capture.Read(m);
                    pictureBox1.Image = m.ToBitmap();
                    firstFrame = false;
                    last_m = m.Clone();
                }
                else
                {
                    //capturing and difference
                    capture.Read(m);
                    currentFrame = m.ToImage<Gray, byte>();
                    lastFrame = last_m.ToImage<Gray, byte>();
                    last_m = m.Clone();                 

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


                    //recording
                    if(surveillanceOn)
                    {
                        if ((moves > 20) && (recordingEnabled == false) && (DateTime.Now > dateTime_finish))
                        {
                            recordingEnabled = true;
                            maxFrames = 80;
                            framesRecorded = 0;
                        }
                        if ((moves > 20) && (recordingEnabled == true) && (framesRecorded > (maxFrames - 20)))
                        {
                            maxFrames += 20;
                            Console.WriteLine("Dodano 20 okvira!!");
                        }
                        if(recordingEnabled && (DateTime.Now > dateTime_finish))
                        {
                            if(writer == null)
                            {
                                int fourcc = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FourCC));
                                int width = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth));
                                int height = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight));
                                writer = new VideoWriter(destinationPath + "recorded" + (videoNumber + 1).ToString() + ".mp4", fourcc, 8, new Size(width, height), false);
                                videoNumber++;
                            }
                            writer.Write(m);
                            framesRecorded++;
                            if(framesRecorded >= maxFrames)
                            {
                                framesRecorded = 0;
                                recordingEnabled = false;
                                writer.Dispose();
                                writer = null;
                            }
                        }
                    }
                    else
                    {
                        if(writer.IsOpened)
                        {
                            framesRecorded = 0;
                            recordingEnabled = false;
                            writer.Dispose();
                            writer = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                capture.Stop();
                capture.Dispose();
            }
            catch (Exception ex)
            {

            }
            
        }

        private void radioButton_manual_CheckedChanged(object sender, EventArgs e)
        {
            showOperatingMode(0);
        }

        private void radioButton_automatic_CheckedChanged(object sender, EventArgs e)
        {
            showOperatingMode(1);
        }

        private void button_startSurv_Click(object sender, EventArgs e)
        {
            setSurvStatus(1);
            surveillanceOn = true;
        }

        private void button_stopSurv_Click(object sender, EventArgs e)
        {
            setSurvStatus(0);
            surveillanceOn = false;
        }
    }
}
