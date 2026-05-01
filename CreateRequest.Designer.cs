namespace BBMS
{
    partial class CreateRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRequest));
            this.lblGoBack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNeedDate = new System.Windows.Forms.DateTimePicker();
            this.unitRequest = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoEmergency = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblTotalRequest = new System.Windows.Forms.Label();
            this.lblApprovedRequest = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unitRequest)).BeginInit();
            this.SuspendLayout();
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
            this.lblGoBack.TabIndex = 9;
            this.lblGoBack.Text = "<---";
            this.lblGoBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 41);
            this.label3.TabIndex = 10;
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
            this.label1.Location = new System.Drawing.Point(175, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Need Date : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateNeedDate
            // 
            this.dateNeedDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateNeedDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateNeedDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateNeedDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateNeedDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNeedDate.Location = new System.Drawing.Point(322, 158);
            this.dateNeedDate.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateNeedDate.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dateNeedDate.Name = "dateNeedDate";
            this.dateNeedDate.Size = new System.Drawing.Size(261, 27);
            this.dateNeedDate.TabIndex = 12;
            // 
            // unitRequest
            // 
            this.unitRequest.BackColor = System.Drawing.Color.Gainsboro;
            this.unitRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.unitRequest.Location = new System.Drawing.Point(367, 201);
            this.unitRequest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.unitRequest.Name = "unitRequest";
            this.unitRequest.Size = new System.Drawing.Size(216, 29);
            this.unitRequest.TabIndex = 13;
            this.unitRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitRequest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(175, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Unit Required :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoEmergency
            // 
            this.rdoEmergency.AutoSize = true;
            this.rdoEmergency.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEmergency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoEmergency.Location = new System.Drawing.Point(278, 234);
            this.rdoEmergency.Name = "rdoEmergency";
            this.rdoEmergency.Size = new System.Drawing.Size(128, 29);
            this.rdoEmergency.TabIndex = 15;
            this.rdoEmergency.TabStop = true;
            this.rdoEmergency.Text = "Emergency";
            this.rdoEmergency.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoNormal.Location = new System.Drawing.Point(412, 234);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(97, 29);
            this.rdoNormal.TabIndex = 17;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.AllowDrop = true;
            this.btnCreate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnCreate.Location = new System.Drawing.Point(278, 354);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(157, 61);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTotalRequest
            // 
            this.lblTotalRequest.AutoSize = true;
            this.lblTotalRequest.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRequest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTotalRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalRequest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalRequest.ForeColor = System.Drawing.Color.White;
            this.lblTotalRequest.Location = new System.Drawing.Point(175, 63);
            this.lblTotalRequest.Name = "lblTotalRequest";
            this.lblTotalRequest.Size = new System.Drawing.Size(193, 32);
            this.lblTotalRequest.TabIndex = 19;
            this.lblTotalRequest.Text = "Total Requests :";
            this.lblTotalRequest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblApprovedRequest
            // 
            this.lblApprovedRequest.AutoSize = true;
            this.lblApprovedRequest.BackColor = System.Drawing.Color.Transparent;
            this.lblApprovedRequest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblApprovedRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblApprovedRequest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblApprovedRequest.ForeColor = System.Drawing.Color.White;
            this.lblApprovedRequest.Location = new System.Drawing.Point(175, 105);
            this.lblApprovedRequest.Name = "lblApprovedRequest";
            this.lblApprovedRequest.Size = new System.Drawing.Size(246, 32);
            this.lblApprovedRequest.TabIndex = 20;
            this.lblApprovedRequest.Text = "Approved Request : ";
            this.lblApprovedRequest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbBloodGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBloodGroup.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.cmbBloodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A-",
            "A+",
            "AB-",
            "AB+",
            "B-",
            "B+",
            "O-",
            "O+"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(278, 274);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(285, 34);
            this.cmbBloodGroup.Sorted = true;
            this.cmbBloodGroup.TabIndex = 40;
            this.cmbBloodGroup.Text = "Select Your Blood Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 41;
            this.label5.Text = "Blood Group :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(860, 483);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBloodGroup);
            this.Controls.Add(this.lblApprovedRequest);
            this.Controls.Add(this.lblTotalRequest);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rdoNormal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoEmergency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitRequest);
            this.Controls.Add(this.dateNeedDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGoBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateRequest";
            this.Text = "CreateRequest";
            this.Load += new System.EventHandler(this.CreateRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNeedDate;
        private System.Windows.Forms.NumericUpDown unitRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoEmergency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblTotalRequest;
        private System.Windows.Forms.Label lblApprovedRequest;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label label5;
    }
}