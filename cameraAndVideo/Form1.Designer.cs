namespace cameraAndVideo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_manual = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_automatic = new System.Windows.Forms.RadioButton();
            this.button_startSurv = new System.Windows.Forms.Button();
            this.button_stopSurv = new System.Windows.Forms.Button();
            this.comboBox_startHours = new System.Windows.Forms.ComboBox();
            this.comboBox_startMinutes = new System.Windows.Forms.ComboBox();
            this.label_colonStart = new System.Windows.Forms.Label();
            this.label_automaticStart = new System.Windows.Forms.Label();
            this.label_automaticStop = new System.Windows.Forms.Label();
            this.label_colonStop = new System.Windows.Forms.Label();
            this.comboBox_stopMinutes = new System.Windows.Forms.ComboBox();
            this.comboBox_stopHours = new System.Windows.Forms.ComboBox();
            this.label_survStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "VOYEUR";
            // 
            // radioButton_manual
            // 
            this.radioButton_manual.AutoSize = true;
            this.radioButton_manual.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_manual.Location = new System.Drawing.Point(6, 31);
            this.radioButton_manual.Name = "radioButton_manual";
            this.radioButton_manual.Size = new System.Drawing.Size(79, 26);
            this.radioButton_manual.TabIndex = 4;
            this.radioButton_manual.TabStop = true;
            this.radioButton_manual.Text = "manual";
            this.radioButton_manual.UseVisualStyleBackColor = true;
            this.radioButton_manual.CheckedChanged += new System.EventHandler(this.radioButton_manual_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_automatic);
            this.groupBox1.Controls.Add(this.radioButton_manual);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(689, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operating mode:";
            // 
            // radioButton_automatic
            // 
            this.radioButton_automatic.AutoSize = true;
            this.radioButton_automatic.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_automatic.Location = new System.Drawing.Point(6, 63);
            this.radioButton_automatic.Name = "radioButton_automatic";
            this.radioButton_automatic.Size = new System.Drawing.Size(97, 26);
            this.radioButton_automatic.TabIndex = 6;
            this.radioButton_automatic.TabStop = true;
            this.radioButton_automatic.Text = "automatic";
            this.radioButton_automatic.UseVisualStyleBackColor = true;
            this.radioButton_automatic.CheckedChanged += new System.EventHandler(this.radioButton_automatic_CheckedChanged);
            // 
            // button_startSurv
            // 
            this.button_startSurv.BackColor = System.Drawing.Color.Snow;
            this.button_startSurv.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startSurv.Location = new System.Drawing.Point(675, 243);
            this.button_startSurv.Name = "button_startSurv";
            this.button_startSurv.Size = new System.Drawing.Size(99, 50);
            this.button_startSurv.TabIndex = 6;
            this.button_startSurv.Text = "Start video surveillance";
            this.button_startSurv.UseVisualStyleBackColor = false;
            this.button_startSurv.Click += new System.EventHandler(this.button_startSurv_Click);
            // 
            // button_stopSurv
            // 
            this.button_stopSurv.BackColor = System.Drawing.Color.Snow;
            this.button_stopSurv.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopSurv.Location = new System.Drawing.Point(806, 243);
            this.button_stopSurv.Name = "button_stopSurv";
            this.button_stopSurv.Size = new System.Drawing.Size(99, 50);
            this.button_stopSurv.TabIndex = 7;
            this.button_stopSurv.Text = "Stop video surveillance";
            this.button_stopSurv.UseVisualStyleBackColor = false;
            this.button_stopSurv.Click += new System.EventHandler(this.button_stopSurv_Click);
            // 
            // comboBox_startHours
            // 
            this.comboBox_startHours.FormattingEnabled = true;
            this.comboBox_startHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_startHours.Location = new System.Drawing.Point(675, 358);
            this.comboBox_startHours.Name = "comboBox_startHours";
            this.comboBox_startHours.Size = new System.Drawing.Size(47, 21);
            this.comboBox_startHours.TabIndex = 8;
            // 
            // comboBox_startMinutes
            // 
            this.comboBox_startMinutes.FormattingEnabled = true;
            this.comboBox_startMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_startMinutes.Location = new System.Drawing.Point(749, 358);
            this.comboBox_startMinutes.Name = "comboBox_startMinutes";
            this.comboBox_startMinutes.Size = new System.Drawing.Size(47, 21);
            this.comboBox_startMinutes.TabIndex = 9;
            // 
            // label_colonStart
            // 
            this.label_colonStart.AutoSize = true;
            this.label_colonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_colonStart.Location = new System.Drawing.Point(728, 355);
            this.label_colonStart.Name = "label_colonStart";
            this.label_colonStart.Size = new System.Drawing.Size(15, 24);
            this.label_colonStart.TabIndex = 10;
            this.label_colonStart.Text = ":";
            // 
            // label_automaticStart
            // 
            this.label_automaticStart.AutoSize = true;
            this.label_automaticStart.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_automaticStart.Location = new System.Drawing.Point(671, 333);
            this.label_automaticStart.Name = "label_automaticStart";
            this.label_automaticStart.Size = new System.Drawing.Size(84, 22);
            this.label_automaticStart.TabIndex = 11;
            this.label_automaticStart.Text = "Start time:";
            // 
            // label_automaticStop
            // 
            this.label_automaticStop.AutoSize = true;
            this.label_automaticStop.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_automaticStop.Location = new System.Drawing.Point(671, 403);
            this.label_automaticStop.Name = "label_automaticStop";
            this.label_automaticStop.Size = new System.Drawing.Size(80, 22);
            this.label_automaticStop.TabIndex = 15;
            this.label_automaticStop.Text = "Stop time:";
            // 
            // label_colonStop
            // 
            this.label_colonStop.AutoSize = true;
            this.label_colonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_colonStop.Location = new System.Drawing.Point(728, 425);
            this.label_colonStop.Name = "label_colonStop";
            this.label_colonStop.Size = new System.Drawing.Size(15, 24);
            this.label_colonStop.TabIndex = 14;
            this.label_colonStop.Text = ":";
            // 
            // comboBox_stopMinutes
            // 
            this.comboBox_stopMinutes.FormattingEnabled = true;
            this.comboBox_stopMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_stopMinutes.Location = new System.Drawing.Point(749, 428);
            this.comboBox_stopMinutes.Name = "comboBox_stopMinutes";
            this.comboBox_stopMinutes.Size = new System.Drawing.Size(47, 21);
            this.comboBox_stopMinutes.TabIndex = 13;
            // 
            // comboBox_stopHours
            // 
            this.comboBox_stopHours.FormattingEnabled = true;
            this.comboBox_stopHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_stopHours.Location = new System.Drawing.Point(675, 428);
            this.comboBox_stopHours.Name = "comboBox_stopHours";
            this.comboBox_stopHours.Size = new System.Drawing.Size(47, 21);
            this.comboBox_stopHours.TabIndex = 12;
            // 
            // label_survStatus
            // 
            this.label_survStatus.AutoSize = true;
            this.label_survStatus.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_survStatus.ForeColor = System.Drawing.Color.Red;
            this.label_survStatus.Location = new System.Drawing.Point(718, 527);
            this.label_survStatus.Name = "label_survStatus";
            this.label_survStatus.Size = new System.Drawing.Size(150, 25);
            this.label_survStatus.TabIndex = 16;
            this.label_survStatus.Text = "Surveillance OFF!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(931, 563);
            this.Controls.Add(this.label_survStatus);
            this.Controls.Add(this.label_automaticStop);
            this.Controls.Add(this.label_colonStop);
            this.Controls.Add(this.comboBox_stopMinutes);
            this.Controls.Add(this.comboBox_stopHours);
            this.Controls.Add(this.label_automaticStart);
            this.Controls.Add(this.label_colonStart);
            this.Controls.Add(this.comboBox_startMinutes);
            this.Controls.Add(this.comboBox_startHours);
            this.Controls.Add(this.button_stopSurv);
            this.Controls.Add(this.button_startSurv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Voyeur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_manual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_automatic;
        private System.Windows.Forms.Button button_startSurv;
        private System.Windows.Forms.Button button_stopSurv;
        private System.Windows.Forms.ComboBox comboBox_startHours;
        private System.Windows.Forms.ComboBox comboBox_startMinutes;
        private System.Windows.Forms.Label label_colonStart;
        private System.Windows.Forms.Label label_automaticStart;
        private System.Windows.Forms.Label label_automaticStop;
        private System.Windows.Forms.Label label_colonStop;
        private System.Windows.Forms.ComboBox comboBox_stopMinutes;
        private System.Windows.Forms.ComboBox comboBox_stopHours;
        private System.Windows.Forms.Label label_survStatus;
    }
}

