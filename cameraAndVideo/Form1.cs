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
using System.Data.SQLite;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace cameraAndVideo
{
    public partial class Form1 : Form
    {
        VideoCapture capture;
        VideoWriter writer;
        

        private SQLiteConnection conn;

        DateTime dateTime;
        DateTime dateTime_finish;
        int frameCount = 0;
        System.Threading.Timer timer;

        

        bool setupFinished = false;

        bool recordingEnabled = false;
        private int maxFrames;
        string destinationPath = @"D:\VIDEO\";
        int videoNumber = 0;
        double fps = 0;

        bool manualSurveillanceOn = false;
        bool autoSurveillanceOn = false;

        int framesRecorded = 0;

        Time autoStartTime= new Time(0,0);
        Time autoStopTime = new Time(0,10);


        DateTime motionStartTime = new DateTime();
        DateTime motionEndTime = new DateTime();

        Mat m = new Mat();
        Mat last_m = new Mat();



        Image<Gray, byte> currentFrame;
        Image<Gray, byte> lastFrame;
        Image<Gray, byte> diffFrame;

        bool firstFrame = true;

        private bool autoSurvSettingsValid = false;
        private bool autoSurvMatchingTime = false;

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(destinationPath);            
            showOperatingMode(0);
            setSurvStatus(0);
            this.conn = Database.GetInstance();
            getAutoSurvSettings();
            startCapturingVideo();
        }

        private void getAutoSurvSettings()
        {
            try
            {
                string sql = "select * from AutoSurvSettings";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                DataTable dataTable = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(dataTable);
                conn.Close();

                comboBox_startHours.Text = dataTable.Rows[0]["hours"].ToString();
                comboBox_startMinutes.Text = dataTable.Rows[0]["minutes"].ToString();
                comboBox_stopHours.Text = dataTable.Rows[1]["hours"].ToString();
                comboBox_stopMinutes.Text = dataTable.Rows[1]["minutes"].ToString();

                autoStartTime.Hours = int.Parse(dataTable.Rows[0]["hours"].ToString());
                autoStartTime.Minutes = int.Parse(dataTable.Rows[0]["minutes"].ToString());
                autoStopTime.Hours = int.Parse(dataTable.Rows[1]["hours"].ToString());
                autoStopTime.Minutes = int.Parse(dataTable.Rows[1]["minutes"].ToString());               


                autoSurvSettingsValid = true;
            }
            catch(Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message, "Database error!");
            }           
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
            if(mode == 0)   //manual
            {
                button_startSurv.Show();
                button_stopSurv.Show();
                label_survStatus.Show();

                label_automaticStart.Hide();
                label_automaticStop.Hide();
                label_colonStart.Hide();
                label_colonStop.Hide();
                comboBox_startHours.Hide();
                comboBox_startMinutes.Hide();
                comboBox_stopHours.Hide();
                comboBox_stopMinutes.Hide();
                button_saveChanges.Hide();
            }
            else if(mode == 1)  //automatic
            {
                button_startSurv.Hide();
                button_stopSurv.Hide();
                label_survStatus.Hide();

                label_automaticStart.Show();
                label_automaticStop.Show();
                label_colonStart.Show();
                label_colonStop.Show();
                comboBox_startHours.Show();
                comboBox_startMinutes.Show();
                comboBox_stopHours.Show();
                comboBox_stopMinutes.Show();
                button_saveChanges.Show();
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
                   // Console.WriteLine(moves.ToString());


                    //recording
                    if(manualSurveillanceOn)
                    {
                        if ((moves > 20) && (recordingEnabled == false) && (DateTime.Now > dateTime_finish))
                        {
                            recordingEnabled = true;
                            maxFrames = 80;
                            framesRecorded = 0;
                            motionStartTime = DateTime.Now;
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
                                writer = new VideoWriter(destinationPath + "rec" + motionStartTime.Year.ToString() + motionStartTime.Month.ToString() + motionStartTime.Day.ToString() + motionStartTime.Hour.ToString() + motionStartTime.Minute.ToString() + motionStartTime.Second.ToString() + ".mp4", fourcc, 8, new Size(width, height), false);
                                videoNumber++;
                            }
                            writer.Write(m);
                            framesRecorded++;
                            if(framesRecorded >= maxFrames)
                            {
                                framesRecorded = 0;
                                recordingEnabled = false;
                                motionEndTime = DateTime.Now;
                                Thread thread = new Thread(saveMotionData);
                                thread.Start();
                                writer.Dispose();
                                writer = null;
                            }
                        }
                    }                
                    else if (autoSurveillanceOn)
                    {
                       if(DateTime.Now.Hour == autoStartTime.Hours && DateTime.Now.Minute == autoStartTime.Minutes && autoSurvMatchingTime == false)
                       {
                            //setSurvStatus(1);
                            //label_survStatus.Text = "Surveillance ON!";
                            //label_survStatus.ForeColor = Color.Green;
                            autoSurvMatchingTime = true;
                            
                       }
                       if(DateTime.Now.Hour == autoStopTime.Hours && DateTime.Now.Minute == autoStopTime.Minutes && autoSurvMatchingTime == true)
                        {
                            autoSurvMatchingTime = false;
                            //setSurvStatus(0);
                            //label_survStatus.Text = "Surveillance OFF!";
                            //label_survStatus.ForeColor = Color.Red;
                        }
                       if(autoSurvMatchingTime == true)
                        {
                            if ((moves > 20) && (recordingEnabled == false) && (DateTime.Now > dateTime_finish))
                            {
                                recordingEnabled = true;
                                maxFrames = 80;
                                framesRecorded = 0;
                                motionStartTime = DateTime.Now;
                            }
                            if ((moves > 20) && (recordingEnabled == true) && (framesRecorded > (maxFrames - 20)))
                            {
                                maxFrames += 20;
                                Console.WriteLine("Dodano 20 okvira!!");
                            }
                            if (recordingEnabled && (DateTime.Now > dateTime_finish))
                            {
                                if (writer == null)
                                {
                                    int fourcc = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FourCC));
                                    int width = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth));
                                    int height = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight));
                                    writer = new VideoWriter(destinationPath + "rec" + motionStartTime.Year.ToString() + motionStartTime.Month.ToString() + motionStartTime.Day.ToString() + motionStartTime.Hour.ToString() + motionStartTime.Minute.ToString() + motionStartTime.Second.ToString() + ".mp4", fourcc, 8, new Size(width, height), false);
                                    videoNumber++;
                                }
                                writer.Write(m);
                                framesRecorded++;
                                if (framesRecorded >= maxFrames)
                                {
                                    framesRecorded = 0;
                                    recordingEnabled = false;
                                    motionEndTime = DateTime.Now;
                                    Thread thread = new Thread(saveMotionData);
                                    thread.Start();
                                    writer.Dispose();
                                    writer = null;
                                }
                            }
                        }
                    }
                    else
                    {
                        if(recordingEnabled)
                        {
                            motionEndTime = DateTime.Now;
                            Thread thread = new Thread(saveMotionData);
                            thread.Start();
                        }
                        if (writer.IsOpened)
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

        private void saveMotionData()
        {
            try
            {
                string sql = "insert into RecordData (id, startTime, endTime, fileName) values('" + Guid.NewGuid().ToString() + "', @starttime, @endtime, 'rec" + motionStartTime.Year.ToString() + motionStartTime.Month.ToString() + motionStartTime.Day.ToString() + motionStartTime.Hour.ToString() + motionStartTime.Minute.ToString() + motionStartTime.Second.ToString() + "')";

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.Add(new SQLiteParameter("@starttime", motionStartTime));
                command.Parameters.Add(new SQLiteParameter("@endtime", motionEndTime));
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message, "Database error!");
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
            recordingEnabled = false;
            showOperatingMode(0);
            manualSurveillanceOn = false;
            autoSurveillanceOn = false;
            setSurvStatus(0);
        }

        private void radioButton_automatic_CheckedChanged(object sender, EventArgs e)
        {
            recordingEnabled = false;
            showOperatingMode(1);
            manualSurveillanceOn = false;
            autoSurvMatchingTime = false;
            setSurvStatus(0);
            getAutoSurvSettings();
            if(autoSurvSettingsValid)
            {
                autoSurveillanceOn = true;
            }
            else
            {
                MessageBox.Show("Enter auto video surveillance parameters then re enter automatic mode!", "Warning!");
            }
        }

        private void button_startSurv_Click(object sender, EventArgs e)
        {
            setSurvStatus(1);
            manualSurveillanceOn = true;
            recordingEnabled = false;
        }

        private void button_stopSurv_Click(object sender, EventArgs e)
        {
            setSurvStatus(0);
            manualSurveillanceOn = false;
            recordingEnabled = false;
        }

        private void button_saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //delete all
                string sql = "delete from AutoSurvSettings";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();

                command.Dispose();


                //insert
                string sql1 = "insert into AutoSurvSettings (id, hours, minutes) values(0, " + comboBox_startHours.Text + ", " + comboBox_startMinutes.Text + ");";
                string sql2 = "insert into AutoSurvSettings (id, hours, minutes) values(1, " + comboBox_stopHours.Text + ", " + comboBox_stopMinutes.Text + ");";
                SQLiteCommand command1 = new SQLiteCommand(sql1, conn);
                SQLiteCommand command2 = new SQLiteCommand(sql2, conn);

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                conn.Close();

                getAutoSurvSettings();
            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message, "Database error!");               
            }
        }

        private void button_listRecords_Click(object sender, EventArgs e)
        {
            if(manualSurveillanceOn == false && autoSurvMatchingTime == false)
            {
                new FormData().Show();
            }
        }

        private void button_clearRecords_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from RecordData";

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if(conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message, "Database error!");
            }        
        }
    }
}
