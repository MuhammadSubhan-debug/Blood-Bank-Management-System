namespace BBMS
{
    partial class Donation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donation));
            this.dgvDonationHistory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalDonor = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterByBloodGroup = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTodayDonor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDonationHistory
            // 
            this.dgvDonationHistory.AllowUserToAddRows = false;
            this.dgvDonationHistory.AllowUserToDeleteRows = false;
            this.dgvDonationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonationHistory.Location = new System.Drawing.Point(5, 247);
            this.dgvDonationHistory.Name = "dgvDonationHistory";
            this.dgvDonationHistory.ReadOnly = true;
            this.dgvDonationHistory.Size = new System.Drawing.Size(659, 266);
            this.dgvDonationHistory.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blood Bank Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalDonor
            // 
            this.lblTotalDonor.AutoSize = true;
            this.lblTotalDonor.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDonor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTotalDonor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalDonor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblTotalDonor.Location = new System.Drawing.Point(8, 10);
            this.lblTotalDonor.Name = "lblTotalDonor";
            this.lblTotalDonor.Size = new System.Drawing.Size(251, 41);
            this.lblTotalDonor.TabIndex = 7;
            this.lblTotalDonor.Text = "Total Donation : ";
            this.lblTotalDonor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.BackColor = System.Drawing.Color.Transparent;
            this.lblGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGoBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblGoBack.ForeColor = System.Drawing.Color.White;
            this.lblGoBack.Location = new System.Drawing.Point(12, 9);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(50, 28);
            this.lblGoBack.TabIndex = 8;
            this.lblGoBack.Text = "<---";
            this.lblGoBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter By Blood Group :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFilterByBloodGroup
            // 
            this.txtFilterByBloodGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFilterByBloodGroup.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtFilterByBloodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtFilterByBloodGroup.Location = new System.Drawing.Point(278, 202);
            this.txtFilterByBloodGroup.Multiline = true;
            this.txtFilterByBloodGroup.Name = "txtFilterByBloodGroup";
            this.txtFilterByBloodGroup.Size = new System.Drawing.Size(186, 32);
            this.txtFilterByBloodGroup.TabIndex = 10;
            this.txtFilterByBloodGroup.TextChanged += new System.EventHandler(this.txtFilterByBloodGroup_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblTotalDonor);
            this.panel1.Location = new System.Drawing.Point(74, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 60);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblTodayDonor);
            this.panel2.Location = new System.Drawing.Point(74, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 60);
            this.panel2.TabIndex = 12;
            // 
            // lblTodayDonor
            // 
            this.lblTodayDonor.AutoSize = true;
            this.lblTodayDonor.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayDonor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTodayDonor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTodayDonor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTodayDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblTodayDonor.Location = new System.Drawing.Point(8, 10);
            this.lblTodayDonor.Name = "lblTodayDonor";
            this.lblTodayDonor.Size = new System.Drawing.Size(265, 41);
            this.lblTodayDonor.TabIndex = 7;
            this.lblTodayDonor.Text = "Today Donation : ";
            this.lblTodayDonor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Donation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(699, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFilterByBloodGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDonationHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Donation";
            this.Text = "Donation";
            this.Load += new System.EventHandler(this.Donation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonationHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalDonor;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterByBloodGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTodayDonor;
    }
}