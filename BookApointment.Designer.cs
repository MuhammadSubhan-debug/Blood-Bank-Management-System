namespace BBMS
{
    partial class BookApointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookApointment));
            this.dateAppointment = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAreaRemarks = new System.Windows.Forms.TextBox();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.lblTotalAppointment = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateAppointment
            // 
            this.dateAppointment.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateAppointment.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateAppointment.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateAppointment.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateAppointment.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateAppointment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAppointment.Location = new System.Drawing.Point(367, 116);
            this.dateAppointment.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            this.dateAppointment.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateAppointment.Name = "dateAppointment";
            this.dateAppointment.Size = new System.Drawing.Size(239, 25);
            this.dateAppointment.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blood Bank Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Appointment Date :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDone
            // 
            this.btnDone.AllowDrop = true;
            this.btnDone.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnDone.Location = new System.Drawing.Point(266, 275);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(157, 61);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Additional Remarks :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAreaRemarks
            // 
            this.txtAreaRemarks.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAreaRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAreaRemarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtAreaRemarks.Location = new System.Drawing.Point(367, 156);
            this.txtAreaRemarks.Multiline = true;
            this.txtAreaRemarks.Name = "txtAreaRemarks";
            this.txtAreaRemarks.Size = new System.Drawing.Size(170, 104);
            this.txtAreaRemarks.TabIndex = 11;
            this.txtAreaRemarks.Text = "  ";
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
            this.lblGoBack.TabIndex = 12;
            this.lblGoBack.Text = "<---";
            this.lblGoBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // lblTotalAppointment
            // 
            this.lblTotalAppointment.AutoSize = true;
            this.lblTotalAppointment.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAppointment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTotalAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAppointment.ForeColor = System.Drawing.Color.White;
            this.lblTotalAppointment.Location = new System.Drawing.Point(123, 50);
            this.lblTotalAppointment.Name = "lblTotalAppointment";
            this.lblTotalAppointment.Size = new System.Drawing.Size(173, 21);
            this.lblTotalAppointment.TabIndex = 13;
            this.lblTotalAppointment.Text = "Total Appointments : ";
            this.lblTotalAppointment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.BackColor = System.Drawing.Color.Transparent;
            this.lblPending.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPending.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPending.ForeColor = System.Drawing.Color.White;
            this.lblPending.Location = new System.Drawing.Point(123, 76);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(82, 21);
            this.lblPending.TabIndex = 14;
            this.lblPending.Text = "Pending :";
            this.lblPending.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BookApointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(703, 400);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblTotalAppointment);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.txtAreaRemarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateAppointment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookApointment";
            this.Text = "BookApointment";
            this.Load += new System.EventHandler(this.BookApointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAreaRemarks;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Label lblTotalAppointment;
        private System.Windows.Forms.Label lblPending;
    }
}