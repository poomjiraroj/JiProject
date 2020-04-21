namespace TricuslabSoftware
{
    partial class IPDmanagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.cbReason = new System.Windows.Forms.ComboBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbPhy = new System.Windows.Forms.Label();
            this.lbPatient = new System.Windows.Forms.Label();
            this.lbReason = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 70);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPD Management";
            // 
            // lbBID
            // 
            this.lbBID.AutoSize = true;
            this.lbBID.Location = new System.Drawing.Point(12, 83);
            this.lbBID.Name = "lbBID";
            this.lbBID.Size = new System.Drawing.Size(79, 17);
            this.lbBID.TabIndex = 2;
            this.lbBID.Text = "BID - Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reason";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDischarge);
            this.groupBox1.Controls.Add(this.cbReason);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discharge";
            // 
            // btnDischarge
            // 
            this.btnDischarge.Enabled = false;
            this.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDischarge.Location = new System.Drawing.Point(99, 72);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(79, 29);
            this.btnDischarge.TabIndex = 2;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.UseVisualStyleBackColor = true;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // cbReason
            // 
            this.cbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.cbReason.FormattingEnabled = true;
            this.cbReason.Items.AddRange(new object[] {
            "Better",
            "Died",
            "Refer",
            "Other"});
            this.cbReason.Location = new System.Drawing.Point(9, 41);
            this.cbReason.Name = "cbReason";
            this.cbReason.Size = new System.Drawing.Size(169, 25);
            this.cbReason.TabIndex = 1;
            this.cbReason.SelectedIndexChanged += new System.EventHandler(this.cbReason_SelectedIndexChanged);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(251, 103);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(33, 17);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "time";
            this.lbTime.Visible = false;
            // 
            // lbPhy
            // 
            this.lbPhy.AutoSize = true;
            this.lbPhy.Location = new System.Drawing.Point(251, 130);
            this.lbPhy.Name = "lbPhy";
            this.lbPhy.Size = new System.Drawing.Size(28, 17);
            this.lbPhy.TabIndex = 5;
            this.lbPhy.Text = "Phy";
            this.lbPhy.Visible = false;
            // 
            // lbPatient
            // 
            this.lbPatient.AutoSize = true;
            this.lbPatient.Location = new System.Drawing.Point(251, 157);
            this.lbPatient.Name = "lbPatient";
            this.lbPatient.Size = new System.Drawing.Size(47, 17);
            this.lbPatient.TabIndex = 6;
            this.lbPatient.Text = "Patient";
            this.lbPatient.Visible = false;
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Location = new System.Drawing.Point(251, 184);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(51, 17);
            this.lbReason.TabIndex = 7;
            this.lbReason.Text = "Reason";
            this.lbReason.Visible = false;
            // 
            // IPDmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 250);
            this.Controls.Add(this.lbReason);
            this.Controls.Add(this.lbPatient);
            this.Controls.Add(this.lbPhy);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbBID);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IPDmanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPDmanagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbReason;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbPhy;
        private System.Windows.Forms.Label lbPatient;
        private System.Windows.Forms.Label lbReason;
    }
}