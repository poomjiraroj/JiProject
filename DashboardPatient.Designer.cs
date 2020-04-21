namespace TricuslabSoftware
{
    partial class DashboardPatient
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
            this.components = new System.ComponentModel.Container();
            this.lbPatient = new System.Windows.Forms.Label();
            this.lbDept = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.panelPulse = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBPM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbBID = new System.Windows.Forms.Label();
            this.lbPhy = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDiag = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbBP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbHt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbBW = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerRe = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.lbSetting = new System.Windows.Forms.Label();
            this.panelPulse.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPatient
            // 
            this.lbPatient.AutoSize = true;
            this.lbPatient.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.lbPatient.Location = new System.Drawing.Point(100, 62);
            this.lbPatient.Name = "lbPatient";
            this.lbPatient.Size = new System.Drawing.Size(136, 54);
            this.lbPatient.TabIndex = 0;
            this.lbPatient.Text = "Patient";
            // 
            // lbDept
            // 
            this.lbDept.AutoSize = true;
            this.lbDept.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbDept.Location = new System.Drawing.Point(104, 116);
            this.lbDept.Name = "lbDept";
            this.lbDept.Size = new System.Drawing.Size(52, 28);
            this.lbDept.TabIndex = 1;
            this.lbDept.Text = "Dept";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI Semilight", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(850, 94);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(89, 45);
            this.lbTime.TabIndex = 45;
            this.lbTime.Text = "Time";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(1222, 761);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(46, 30);
            this.lbExit.TabIndex = 46;
            this.lbExit.Text = "Exit";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // panelPulse
            // 
            this.panelPulse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.panelPulse.Controls.Add(this.label5);
            this.panelPulse.Controls.Add(this.label3);
            this.panelPulse.Controls.Add(this.lbStatus);
            this.panelPulse.Controls.Add(this.label1);
            this.panelPulse.Controls.Add(this.lbBPM);
            this.panelPulse.Location = new System.Drawing.Point(109, 188);
            this.panelPulse.Name = "panelPulse";
            this.panelPulse.Size = new System.Drawing.Size(267, 456);
            this.panelPulse.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "PULSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "STATUS";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 35F);
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(253)))), ((int)(((byte)(55)))));
            this.lbStatus.Location = new System.Drawing.Point(16, 301);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(177, 62);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "STATUS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "BPM";
            // 
            // lbBPM
            // 
            this.lbBPM.AutoSize = true;
            this.lbBPM.Font = new System.Drawing.Font("Segoe UI Semilight", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.lbBPM.Location = new System.Drawing.Point(3, 69);
            this.lbBPM.Name = "lbBPM";
            this.lbBPM.Size = new System.Drawing.Size(172, 142);
            this.lbBPM.TabIndex = 0;
            this.lbBPM.Text = "00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.lbBID);
            this.panel1.Controls.Add(this.lbPhy);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbDiag);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbBP);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbTemp);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbHt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbBW);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(436, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 456);
            this.panel1.TabIndex = 48;
            // 
            // lbBID
            // 
            this.lbBID.AutoSize = true;
            this.lbBID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBID.Location = new System.Drawing.Point(26, 14);
            this.lbBID.Name = "lbBID";
            this.lbBID.Size = new System.Drawing.Size(58, 37);
            this.lbBID.TabIndex = 17;
            this.lbBID.Text = "BID";
            // 
            // lbPhy
            // 
            this.lbPhy.AutoSize = true;
            this.lbPhy.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhy.Location = new System.Drawing.Point(25, 374);
            this.lbPhy.Name = "lbPhy";
            this.lbPhy.Size = new System.Drawing.Size(33, 45);
            this.lbPhy.TabIndex = 16;
            this.lbPhy.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 47);
            this.label10.TabIndex = 15;
            this.label10.Text = "Physician";
            // 
            // lbDiag
            // 
            this.lbDiag.AutoSize = true;
            this.lbDiag.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiag.Location = new System.Drawing.Point(25, 252);
            this.lbDiag.Name = "lbDiag";
            this.lbDiag.Size = new System.Drawing.Size(33, 45);
            this.lbDiag.TabIndex = 14;
            this.lbDiag.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 47);
            this.label8.TabIndex = 13;
            this.label8.Text = "Diagnosis";
            // 
            // lbBP
            // 
            this.lbBP.AutoSize = true;
            this.lbBP.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBP.Location = new System.Drawing.Point(559, 122);
            this.lbBP.Name = "lbBP";
            this.lbBP.Size = new System.Drawing.Size(106, 45);
            this.lbBP.TabIndex = 12;
            this.lbBP.Text = "00/00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "BP";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.Location = new System.Drawing.Point(383, 120);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(56, 45);
            this.lbTemp.TabIndex = 10;
            this.lbTemp.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "T";
            // 
            // lbHt
            // 
            this.lbHt.AutoSize = true;
            this.lbHt.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHt.Location = new System.Drawing.Point(237, 120);
            this.lbHt.Name = "lbHt";
            this.lbHt.Size = new System.Drawing.Size(56, 45);
            this.lbHt.TabIndex = 8;
            this.lbHt.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ht";
            // 
            // lbBW
            // 
            this.lbBW.AutoSize = true;
            this.lbBW.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBW.Location = new System.Drawing.Point(89, 120);
            this.lbBW.Name = "lbBW";
            this.lbBW.Size = new System.Drawing.Size(56, 45);
            this.lbBW.TabIndex = 6;
            this.lbBW.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "BW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vital Sign";
            // 
            // TimerRe
            // 
            this.TimerRe.Interval = 6000;
            this.TimerRe.Tick += new System.EventHandler(this.TimerRe_Tick);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM3";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // lbSetting
            // 
            this.lbSetting.AutoSize = true;
            this.lbSetting.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetting.Location = new System.Drawing.Point(105, 768);
            this.lbSetting.Name = "lbSetting";
            this.lbSetting.Size = new System.Drawing.Size(58, 21);
            this.lbSetting.TabIndex = 49;
            this.lbSetting.Text = "Setting";
            this.lbSetting.Click += new System.EventHandler(this.lbSetting_Click);
            // 
            // DashboardPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.lbSetting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPulse);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDept);
            this.Controls.Add(this.lbPatient);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardPatient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPulse.ResumeLayout(false);
            this.panelPulse.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPatient;
        private System.Windows.Forms.Label lbDept;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Panel panelPulse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBPM;
        private System.Windows.Forms.Label lbBP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbHt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbBW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPhy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbDiag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer TimerRe;
        private System.Windows.Forms.Label lbBID;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label lbSetting;
    }
}