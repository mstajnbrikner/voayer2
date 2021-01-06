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
            this.button_saveChanges = new System.Windows.Forms.Button();
            this.button_listRecords = new System.Windows.Forms.Button();
            this.button_clearRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(16, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 591);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "VOYEUR";
            // 
            // radioButton_manual
            // 
            this.radioButton_manual.AutoSize = true;
            this.radioButton_manual.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_manual.Location = new System.Drawing.Point(8, 38);
            this.radioButton_manual.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_manual.Name = "radioButton_manual";
            this.radioButton_manual.Size = new System.Drawing.Size(96, 32);
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
            this.groupBox1.Location = new System.Drawing.Point(919, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(272, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operating mode:";
            // 
            // radioButton_automatic
            // 
            this.radioButton_automatic.AutoSize = true;
            this.radioButton_automatic.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_automatic.Location = new System.Drawing.Point(8, 78);
            this.radioButton_automatic.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_automatic.Name = "radioButton_automatic";
            this.radioButton_automatic.Size = new System.Drawing.Size(119, 32);
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
            this.button_startSurv.Location = new System.Drawing.Point(900, 299);
            this.button_startSurv.Margin = new System.Windows.Forms.Padding(4);
            this.button_startSurv.Name = "button_startSurv";
            this.button_startSurv.Size = new System.Drawing.Size(132, 62);
            this.button_startSurv.TabIndex = 6;
            this.button_startSurv.Text = "Start video surveillance";
            this.button_startSurv.UseVisualStyleBackColor = false;
            this.button_startSurv.Click += new System.EventHandler(this.button_startSurv_Click);
            // 
            // button_stopSurv
            // 
            this.button_stopSurv.BackColor = System.Drawing.Color.Snow;
            this.button_stopSurv.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopSurv.Location = new System.Drawing.Point(1075, 299);
            this.button_stopSurv.Margin = new System.Windows.Forms.Padding(4);
            this.button_stopSurv.Name = "button_stopSurv";
            this.button_stopSurv.Size = new System.Drawing.Size(132, 62);
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
            this.comboBox_startHours.Location = new System.Drawing.Point(971, 292);
            this.comboBox_startHours.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_startHours.Name = "comboBox_startHours";
            this.comboBox_startHours.Size = new System.Drawing.Size(61, 24);
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
            this.comboBox_startMinutes.Location = new System.Drawing.Point(1070, 292);
            this.comboBox_startMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_startMinutes.Name = "comboBox_startMinutes";
            this.comboBox_startMinutes.Size = new System.Drawing.Size(61, 24);
            this.comboBox_startMinutes.TabIndex = 9;
            // 
            // label_colonStart
            // 
            this.label_colonStart.AutoSize = true;
            this.label_colonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_colonStart.Location = new System.Drawing.Point(1042, 288);
            this.label_colonStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_colonStart.Name = "label_colonStart";
            this.label_colonStart.Size = new System.Drawing.Size(19, 29);
            this.label_colonStart.TabIndex = 10;
            this.label_colonStart.Text = ":";
            // 
            // label_automaticStart
            // 
            this.label_automaticStart.AutoSize = true;
            this.label_automaticStart.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_automaticStart.Location = new System.Drawing.Point(966, 261);
            this.label_automaticStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_automaticStart.Name = "label_automaticStart";
            this.label_automaticStart.Size = new System.Drawing.Size(104, 28);
            this.label_automaticStart.TabIndex = 11;
            this.label_automaticStart.Text = "Start time:";
            // 
            // label_automaticStop
            // 
            this.label_automaticStop.AutoSize = true;
            this.label_automaticStop.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_automaticStop.Location = new System.Drawing.Point(966, 347);
            this.label_automaticStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_automaticStop.Name = "label_automaticStop";
            this.label_automaticStop.Size = new System.Drawing.Size(100, 28);
            this.label_automaticStop.TabIndex = 15;
            this.label_automaticStop.Text = "Stop time:";
            // 
            // label_colonStop
            // 
            this.label_colonStop.AutoSize = true;
            this.label_colonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_colonStop.Location = new System.Drawing.Point(1042, 374);
            this.label_colonStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_colonStop.Name = "label_colonStop";
            this.label_colonStop.Size = new System.Drawing.Size(19, 29);
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
            this.comboBox_stopMinutes.Location = new System.Drawing.Point(1070, 378);
            this.comboBox_stopMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_stopMinutes.Name = "comboBox_stopMinutes";
            this.comboBox_stopMinutes.Size = new System.Drawing.Size(61, 24);
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
            this.comboBox_stopHours.Location = new System.Drawing.Point(971, 378);
            this.comboBox_stopHours.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_stopHours.Name = "comboBox_stopHours";
            this.comboBox_stopHours.Size = new System.Drawing.Size(61, 24);
            this.comboBox_stopHours.TabIndex = 12;
            // 
            // label_survStatus
            // 
            this.label_survStatus.AutoSize = true;
            this.label_survStatus.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_survStatus.ForeColor = System.Drawing.Color.Red;
            this.label_survStatus.Location = new System.Drawing.Point(965, 405);
            this.label_survStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_survStatus.Name = "label_survStatus";
            this.label_survStatus.Size = new System.Drawing.Size(190, 33);
            this.label_survStatus.TabIndex = 16;
            this.label_survStatus.Text = "Surveillance OFF!";
            // 
            // button_saveChanges
            // 
            this.button_saveChanges.BackColor = System.Drawing.Color.Snow;
            this.button_saveChanges.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveChanges.Location = new System.Drawing.Point(987, 425);
            this.button_saveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.button_saveChanges.Name = "button_saveChanges";
            this.button_saveChanges.Size = new System.Drawing.Size(132, 62);
            this.button_saveChanges.TabIndex = 17;
            this.button_saveChanges.Text = "Save changes";
            this.button_saveChanges.UseVisualStyleBackColor = false;
            this.button_saveChanges.Click += new System.EventHandler(this.button_saveChanges_Click);
            // 
            // button_listRecords
            // 
            this.button_listRecords.BackColor = System.Drawing.Color.Snow;
            this.button_listRecords.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_listRecords.Location = new System.Drawing.Point(900, 618);
            this.button_listRecords.Margin = new System.Windows.Forms.Padding(4);
            this.button_listRecords.Name = "button_listRecords";
            this.button_listRecords.Size = new System.Drawing.Size(132, 62);
            this.button_listRecords.TabIndex = 18;
            this.button_listRecords.Text = "LIST RECORDS";
            this.button_listRecords.UseVisualStyleBackColor = false;
            this.button_listRecords.Click += new System.EventHandler(this.button_listRecords_Click);
            // 
            // button_clearRecords
            // 
            this.button_clearRecords.BackColor = System.Drawing.Color.Snow;
            this.button_clearRecords.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearRecords.Location = new System.Drawing.Point(1087, 618);
            this.button_clearRecords.Margin = new System.Windows.Forms.Padding(4);
            this.button_clearRecords.Name = "button_clearRecords";
            this.button_clearRecords.Size = new System.Drawing.Size(132, 62);
            this.button_clearRecords.TabIndex = 19;
            this.button_clearRecords.Text = "CLEAR RECORDS";
            this.button_clearRecords.UseVisualStyleBackColor = false;
            this.button_clearRecords.Click += new System.EventHandler(this.button_clearRecords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1241, 693);
            this.Controls.Add(this.button_clearRecords);
            this.Controls.Add(this.button_listRecords);
            this.Controls.Add(this.button_saveChanges);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button_saveChanges;
        private System.Windows.Forms.Button button_listRecords;
        private System.Windows.Forms.Button button_clearRecords;
    }
}

