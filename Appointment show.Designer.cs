namespace BBMS
{
    partial class Appointment_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment_show));
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.lblTotalAppointment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.colApprove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColReject = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApprove,
            this.ColReject});
            this.dgvAppointments.Location = new System.Drawing.Point(1, 162);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.Size = new System.Drawing.Size(714, 227);
            this.dgvAppointments.TabIndex = 0;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // lblTotalAppointment
            // 
            this.lblTotalAppointment.AutoSize = true;
            this.lblTotalAppointment.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAppointment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTotalAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalAppointment.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblTotalAppointment.Location = new System.Drawing.Point(0, 10);
            this.lblTotalAppointment.Name = "lblTotalAppointment";
            this.lblTotalAppointment.Size = new System.Drawing.Size(317, 41);
            this.lblTotalAppointment.TabIndex = 7;
            this.lblTotalAppointment.Text = "Total Appointment  : ";
            this.lblTotalAppointment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblTotalAppointment);
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 60);
            this.panel1.TabIndex = 13;
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.BackColor = System.Drawing.Color.Transparent;
            this.lblGoBack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGoBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblGoBack.ForeColor = System.Drawing.Color.White;
            this.lblGoBack.Location = new System.Drawing.Point(12, 9);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(51, 32);
            this.lblGoBack.TabIndex = 8;
            this.lblGoBack.Text = "<--";
            this.lblGoBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // colApprove
            // 
            this.colApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colApprove.HeaderText = "Approve";
            this.colApprove.Name = "colApprove";
            this.colApprove.ReadOnly = true;
            this.colApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colApprove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colApprove.Text = "Approve";
            this.colApprove.ToolTipText = "Click";
            this.colApprove.UseColumnTextForButtonValue = true;
            // 
            // ColReject
            // 
            this.ColReject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColReject.HeaderText = "Reject";
            this.ColReject.Name = "ColReject";
            this.ColReject.ReadOnly = true;
            this.ColReject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColReject.Text = "Reject";
            this.ColReject.ToolTipText = "Click";
            this.ColReject.UseColumnTextForButtonValue = true;
            // 
            // Appointment_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(723, 393);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAppointments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appointment_show";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.Appointment_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblTotalAppointment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.DataGridViewButtonColumn colApprove;
        private System.Windows.Forms.DataGridViewButtonColumn ColReject;
    }
}