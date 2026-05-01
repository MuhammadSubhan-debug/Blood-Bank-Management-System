namespace BBMS
{
    partial class Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request));
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalDonor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.colApprove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssigned = new System.Windows.Forms.NumericUpDown();
            this.cmbCompatilbeGroups = new System.Windows.Forms.ComboBox();
            this.lblList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssigned)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequest
            // 
            this.dgvRequest.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApprove,
            this.colSelect});
            this.dgvRequest.Location = new System.Drawing.Point(2, 177);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.Size = new System.Drawing.Size(795, 269);
            this.dgvRequest.TabIndex = 0;
            this.dgvRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblTotalDonor);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 60);
            this.panel1.TabIndex = 12;
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
            this.lblTotalDonor.Size = new System.Drawing.Size(225, 41);
            this.lblTotalDonor.TabIndex = 7;
            this.lblTotalDonor.Text = "Total Request :";
            this.lblTotalDonor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(189, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Blood Bank Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.BackColor = System.Drawing.Color.Transparent;
            this.lblGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGoBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblGoBack.ForeColor = System.Drawing.Color.White;
            this.lblGoBack.Location = new System.Drawing.Point(12, 16);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(50, 28);
            this.lblGoBack.TabIndex = 14;
            this.lblGoBack.Text = "<---";
            this.lblGoBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.btnApprove.Location = new System.Drawing.Point(328, 111);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(118, 60);
            this.btnApprove.TabIndex = 15;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // colApprove
            // 
            this.colApprove.FalseValue = "false";
            this.colApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colApprove.HeaderText = "Approve";
            this.colApprove.Name = "colApprove";
            this.colApprove.ToolTipText = "Check";
            this.colApprove.TrueValue = "true";
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.Text = "Select";
            this.colSelect.ToolTipText = "Click";
            this.colSelect.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 36);
            this.label4.TabIndex = 44;
            this.label4.Text = "Units to Assigned";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAssigned
            // 
            this.txtAssigned.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtAssigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtAssigned.Location = new System.Drawing.Point(246, 68);
            this.txtAssigned.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAssigned.Name = "txtAssigned";
            this.txtAssigned.Size = new System.Drawing.Size(200, 34);
            this.txtAssigned.TabIndex = 43;
            this.txtAssigned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAssigned.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbCompatilbeGroups
            // 
            this.cmbCompatilbeGroups.AllowDrop = true;
            this.cmbCompatilbeGroups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompatilbeGroups.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbCompatilbeGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCompatilbeGroups.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.cmbCompatilbeGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.cmbCompatilbeGroups.FormattingEnabled = true;
            this.cmbCompatilbeGroups.Location = new System.Drawing.Point(452, 67);
            this.cmbCompatilbeGroups.Name = "cmbCompatilbeGroups";
            this.cmbCompatilbeGroups.Size = new System.Drawing.Size(285, 34);
            this.cmbCompatilbeGroups.Sorted = true;
            this.cmbCompatilbeGroups.TabIndex = 45;
            this.cmbCompatilbeGroups.Text = "Blood Group";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.BackColor = System.Drawing.Color.Transparent;
            this.lblList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblList.ForeColor = System.Drawing.Color.White;
            this.lblList.Location = new System.Drawing.Point(465, 116);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(61, 41);
            this.lblList.TabIndex = 8;
            this.lblList.Text = "list";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.cmbCompatilbeGroups);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAssigned);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Request";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssigned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalDonor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colApprove;
        private System.Windows.Forms.DataGridViewButtonColumn colSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtAssigned;
        private System.Windows.Forms.ComboBox cmbCompatilbeGroups;
        private System.Windows.Forms.Label lblList;
    }
}