namespace TricuslabSoftware
{
    partial class ReportPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPatient));
            this.lbPatient = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAVGBPM = new System.Windows.Forms.Label();
            this.lbHighBPM = new System.Windows.Forms.Label();
            this.lbLowBPM = new System.Windows.Forms.Label();
            this.lbDiagnosis = new System.Windows.Forms.Label();
            this.lbWard = new System.Windows.Forms.Label();
            this.gvHR = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gvHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvHR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPatient
            // 
            this.lbPatient.AutoSize = true;
            this.lbPatient.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatient.Location = new System.Drawing.Point(101, 105);
            this.lbPatient.Name = "lbPatient";
            this.lbPatient.Size = new System.Drawing.Size(145, 47);
            this.lbPatient.TabIndex = 0;
            this.lbPatient.Text = "lbPatient";
            this.lbPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnBack.TabIndex = 50;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 86);
            this.label1.TabIndex = 51;
            this.label1.Text = "Avarage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 25.25F);
            this.label2.Location = new System.Drawing.Point(635, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 46);
            this.label2.TabIndex = 52;
            this.label2.Text = "High";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 25.25F);
            this.label3.Location = new System.Drawing.Point(1089, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 46);
            this.label3.TabIndex = 53;
            this.label3.Text = "Low";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAVGBPM
            // 
            this.lbAVGBPM.AutoSize = true;
            this.lbAVGBPM.Font = new System.Drawing.Font("Segoe UI", 80F);
            this.lbAVGBPM.Location = new System.Drawing.Point(811, 161);
            this.lbAVGBPM.Name = "lbAVGBPM";
            this.lbAVGBPM.Size = new System.Drawing.Size(176, 142);
            this.lbAVGBPM.TabIndex = 54;
            this.lbAVGBPM.Text = "00";
            this.lbAVGBPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHighBPM
            // 
            this.lbHighBPM.AutoSize = true;
            this.lbHighBPM.Font = new System.Drawing.Font("Segoe UI", 40.25F);
            this.lbHighBPM.Location = new System.Drawing.Point(634, 207);
            this.lbHighBPM.Name = "lbHighBPM";
            this.lbHighBPM.Size = new System.Drawing.Size(88, 72);
            this.lbHighBPM.TabIndex = 55;
            this.lbHighBPM.Text = "00";
            this.lbHighBPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLowBPM
            // 
            this.lbLowBPM.AutoSize = true;
            this.lbLowBPM.Font = new System.Drawing.Font("Segoe UI", 40.25F);
            this.lbLowBPM.Location = new System.Drawing.Point(1084, 207);
            this.lbLowBPM.Name = "lbLowBPM";
            this.lbLowBPM.Size = new System.Drawing.Size(88, 72);
            this.lbLowBPM.TabIndex = 56;
            this.lbLowBPM.Text = "00";
            this.lbLowBPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiagnosis
            // 
            this.lbDiagnosis.AutoSize = true;
            this.lbDiagnosis.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiagnosis.Location = new System.Drawing.Point(102, 162);
            this.lbDiagnosis.Name = "lbDiagnosis";
            this.lbDiagnosis.Size = new System.Drawing.Size(155, 40);
            this.lbDiagnosis.TabIndex = 57;
            this.lbDiagnosis.Text = "lbDiagnosis";
            this.lbDiagnosis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWard
            // 
            this.lbWard.AutoSize = true;
            this.lbWard.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWard.Location = new System.Drawing.Point(102, 212);
            this.lbWard.Name = "lbWard";
            this.lbWard.Size = new System.Drawing.Size(102, 40);
            this.lbWard.TabIndex = 58;
            this.lbWard.Text = "lbWard";
            this.lbWard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvHR
            // 
            this.gvHR.AllowUserToAddRows = false;
            this.gvHR.AllowUserToDeleteRows = false;
            this.gvHR.AllowUserToResizeColumns = false;
            this.gvHR.AllowUserToResizeRows = false;
            this.gvHR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvHR.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHR.Location = new System.Drawing.Point(109, 351);
            this.gvHR.MultiSelect = false;
            this.gvHR.Name = "gvHR";
            this.gvHR.ReadOnly = true;
            this.gvHR.RowHeadersVisible = false;
            this.gvHR.Size = new System.Drawing.Size(229, 314);
            this.gvHR.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 37);
            this.label4.TabIndex = 61;
            this.label4.Text = "HR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 37);
            this.label5.TabIndex = 62;
            this.label5.Text = "HISTORY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvHistory
            // 
            this.gvHistory.AllowUserToAddRows = false;
            this.gvHistory.AllowUserToDeleteRows = false;
            this.gvHistory.AllowUserToResizeColumns = false;
            this.gvHistory.AllowUserToResizeRows = false;
            this.gvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHistory.Location = new System.Drawing.Point(377, 351);
            this.gvHistory.MultiSelect = false;
            this.gvHistory.Name = "gvHistory";
            this.gvHistory.ReadOnly = true;
            this.gvHistory.RowHeadersVisible = false;
            this.gvHistory.Size = new System.Drawing.Size(817, 314);
            this.gvHistory.TabIndex = 60;
            // 
            // ReportPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gvHistory);
            this.Controls.Add(this.gvHR);
            this.Controls.Add(this.lbWard);
            this.Controls.Add(this.lbDiagnosis);
            this.Controls.Add(this.lbLowBPM);
            this.Controls.Add(this.lbHighBPM);
            this.Controls.Add(this.lbAVGBPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbPatient);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPatient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gvHR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPatient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAVGBPM;
        private System.Windows.Forms.Label lbHighBPM;
        private System.Windows.Forms.Label lbLowBPM;
        private System.Windows.Forms.Label lbDiagnosis;
        private System.Windows.Forms.Label lbWard;
        private System.Windows.Forms.DataGridView gvHR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvHistory;
    }
}