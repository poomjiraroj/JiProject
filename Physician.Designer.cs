namespace TricuslabSoftware
{
    partial class Physician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Physician));
            this.lbPhysician = new System.Windows.Forms.Label();
            this.lbDept = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.btnPreOPD = new System.Windows.Forms.Button();
            this.btnOPD = new System.Windows.Forms.Button();
            this.btnIPD = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPhysician
            // 
            this.lbPhysician.AutoSize = true;
            this.lbPhysician.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.lbPhysician.Location = new System.Drawing.Point(101, 105);
            this.lbPhysician.Name = "lbPhysician";
            this.lbPhysician.Size = new System.Drawing.Size(287, 54);
            this.lbPhysician.TabIndex = 42;
            this.lbPhysician.Text = "Physician Name";
            // 
            // lbDept
            // 
            this.lbDept.AutoSize = true;
            this.lbDept.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbDept.Location = new System.Drawing.Point(105, 151);
            this.lbDept.Name = "lbDept";
            this.lbDept.Size = new System.Drawing.Size(113, 28);
            this.lbDept.TabIndex = 43;
            this.lbDept.Text = "Department";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.lbDate.Location = new System.Drawing.Point(867, 105);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(102, 54);
            this.lbDate.TabIndex = 44;
            this.lbDate.Text = "Date";
            // 
            // btnPreOPD
            // 
            this.btnPreOPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.btnPreOPD.FlatAppearance.BorderSize = 0;
            this.btnPreOPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreOPD.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreOPD.ForeColor = System.Drawing.Color.White;
            this.btnPreOPD.Location = new System.Drawing.Point(110, 215);
            this.btnPreOPD.Name = "btnPreOPD";
            this.btnPreOPD.Size = new System.Drawing.Size(300, 300);
            this.btnPreOPD.TabIndex = 45;
            this.btnPreOPD.Text = "PRE-OPD Patient";
            this.btnPreOPD.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPreOPD.UseVisualStyleBackColor = false;
            this.btnPreOPD.Click += new System.EventHandler(this.btnPreOPD_Click);
            // 
            // btnOPD
            // 
            this.btnOPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.btnOPD.FlatAppearance.BorderSize = 0;
            this.btnOPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOPD.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPD.ForeColor = System.Drawing.Color.White;
            this.btnOPD.Location = new System.Drawing.Point(416, 215);
            this.btnOPD.Name = "btnOPD";
            this.btnOPD.Size = new System.Drawing.Size(300, 147);
            this.btnOPD.TabIndex = 47;
            this.btnOPD.Text = "OPD Patient";
            this.btnOPD.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnOPD.UseVisualStyleBackColor = false;
            this.btnOPD.Click += new System.EventHandler(this.btnOPD_Click);
            // 
            // btnIPD
            // 
            this.btnIPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.btnIPD.FlatAppearance.BorderSize = 0;
            this.btnIPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIPD.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPD.ForeColor = System.Drawing.Color.White;
            this.btnIPD.Location = new System.Drawing.Point(416, 368);
            this.btnIPD.Name = "btnIPD";
            this.btnIPD.Size = new System.Drawing.Size(300, 147);
            this.btnIPD.TabIndex = 48;
            this.btnIPD.Text = "IPD Patient";
            this.btnIPD.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnIPD.UseVisualStyleBackColor = false;
            this.btnIPD.Click += new System.EventHandler(this.btnIPD_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(1166, 712);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 41);
            this.btnBack.TabIndex = 49;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(876, 215);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(125, 70);
            this.btnSetting.TabIndex = 51;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.panelReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelReport.FlatAppearance.BorderSize = 0;
            this.panelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelReport.ForeColor = System.Drawing.Color.White;
            this.panelReport.Location = new System.Drawing.Point(876, 292);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(125, 70);
            this.panelReport.TabIndex = 52;
            this.panelReport.Text = "REPORT";
            this.panelReport.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.panelReport.UseVisualStyleBackColor = false;
            this.panelReport.Click += new System.EventHandler(this.panelReport_Click);
            // 
            // Physician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnIPD);
            this.Controls.Add(this.btnOPD);
            this.Controls.Add(this.btnPreOPD);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbDept);
            this.Controls.Add(this.lbPhysician);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Physician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physician";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPhysician;
        private System.Windows.Forms.Label lbDept;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btnPreOPD;
        private System.Windows.Forms.Button btnOPD;
        private System.Windows.Forms.Button btnIPD;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button panelReport;
    }
}