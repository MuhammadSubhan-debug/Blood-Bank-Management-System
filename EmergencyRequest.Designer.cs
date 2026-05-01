namespace BBMS
{
    partial class EmergencyRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmergencyRequest));
            this.lblEmergencyRequest = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.dgvEmergency = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergency)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmergencyRequest
            // 
            this.lblEmergencyRequest.AutoSize = true;
            this.lblEmergencyRequest.BackColor = System.Drawing.Color.Transparent;
            this.lblEmergencyRequest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblEmergencyRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmergencyRequest.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblEmergencyRequest.Location = new System.Drawing.Point(8, 10);
            this.lblEmergencyRequest.Name = "lblEmergencyRequest";
            this.lblEmergencyRequest.Size = new System.Drawing.Size(317, 41);
            this.lblEmergencyRequest.TabIndex = 7;
            this.lblEmergencyRequest.Text = "Emergency Request : ";
            this.lblEmergencyRequest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblEmergencyRequest);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 60);
            this.panel1.TabIndex = 13;
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
            this.lblGoBack.TabIndex = 15;
            this.lblGoBack.Text = "<---";
            this.lblGoBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // dgvEmergency
            // 
            this.dgvEmergency.AllowUserToAddRows = false;
            this.dgvEmergency.AllowUserToDeleteRows = false;
            this.dgvEmergency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmergency.Location = new System.Drawing.Point(12, 171);
            this.dgvEmergency.Name = "dgvEmergency";
            this.dgvEmergency.ReadOnly = true;
            this.dgvEmergency.Size = new System.Drawing.Size(776, 267);
            this.dgvEmergency.TabIndex = 16;
            this.dgvEmergency.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmergencyRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmergency);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmergencyRequest";
            this.Text = "EmergencyRequest";
            this.Load += new System.EventHandler(this.EmergencyRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmergencyRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.DataGridView dgvEmergency;
    }
}