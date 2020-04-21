namespace TricuslabSoftware
{
    partial class BPMsetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSetting = new System.Windows.Forms.Label();
            this.lbBID = new System.Windows.Forms.Label();
            this.txtHighPR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHighPRSA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLowPRSA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLowPR = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.lbSetting);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lbSetting
            // 
            this.lbSetting.AutoSize = true;
            this.lbSetting.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetting.ForeColor = System.Drawing.Color.White;
            this.lbSetting.Location = new System.Drawing.Point(196, 9);
            this.lbSetting.Name = "lbSetting";
            this.lbSetting.Size = new System.Drawing.Size(101, 37);
            this.lbSetting.TabIndex = 50;
            this.lbSetting.Text = "Setting";
            // 
            // lbBID
            // 
            this.lbBID.AutoSize = true;
            this.lbBID.Location = new System.Drawing.Point(12, 64);
            this.lbBID.Name = "lbBID";
            this.lbBID.Size = new System.Drawing.Size(38, 17);
            this.lbBID.TabIndex = 1;
            this.lbBID.Text = "lbBID";
            // 
            // txtHighPR
            // 
            this.txtHighPR.Location = new System.Drawing.Point(114, 104);
            this.txtHighPR.Name = "txtHighPR";
            this.txtHighPR.Size = new System.Drawing.Size(145, 25);
            this.txtHighPR.TabIndex = 2;
            this.txtHighPR.Text = "120";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "High Pulse rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stay Alert High";
            // 
            // txtHighPRSA
            // 
            this.txtHighPRSA.Location = new System.Drawing.Point(114, 135);
            this.txtHighPRSA.Name = "txtHighPRSA";
            this.txtHighPRSA.Size = new System.Drawing.Size(145, 25);
            this.txtHighPRSA.TabIndex = 4;
            this.txtHighPRSA.Text = "110";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stay Alert Low";
            // 
            // txtLowPRSA
            // 
            this.txtLowPRSA.Location = new System.Drawing.Point(114, 166);
            this.txtLowPRSA.Name = "txtLowPRSA";
            this.txtLowPRSA.Size = new System.Drawing.Size(145, 25);
            this.txtLowPRSA.TabIndex = 6;
            this.txtLowPRSA.Text = "60";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Low Pulse rate";
            // 
            // txtLowPR
            // 
            this.txtLowPR.Location = new System.Drawing.Point(114, 197);
            this.txtLowPR.Name = "txtLowPR";
            this.txtLowPR.Size = new System.Drawing.Size(145, 25);
            this.txtLowPR.TabIndex = 8;
            this.txtLowPR.Text = "50";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BPMsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLowPR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLowPRSA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHighPRSA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHighPR);
            this.Controls.Add(this.lbBID);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BPMsetting";
            this.Text = "BPMsetting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSetting;
        private System.Windows.Forms.Label lbBID;
        private System.Windows.Forms.TextBox txtHighPR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHighPRSA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLowPRSA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLowPR;
        private System.Windows.Forms.Button btnSave;
    }
}