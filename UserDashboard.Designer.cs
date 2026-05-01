namespace BBMS
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pictureBoxDp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.btnChangeDp = new System.Windows.Forms.Button();
            this.timerDropDown = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCreateRequest = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBookAppointment = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDropDown.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.pictureBoxDp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 56);
            this.panel1.TabIndex = 0;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblUserID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(80, 23);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(34, 21);
            this.lblUserID.TabIndex = 29;
            this.lblUserID.Text = "ID :";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxDp
            // 
            this.pictureBoxDp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDp.Image")));
            this.pictureBoxDp.Location = new System.Drawing.Point(899, 3);
            this.pictureBoxDp.Name = "pictureBoxDp";
            this.pictureBoxDp.Size = new System.Drawing.Size(42, 45);
            this.pictureBoxDp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDp.TabIndex = 3;
            this.pictureBoxDp.TabStop = false;
            this.pictureBoxDp.Click += new System.EventHandler(this.pictureBoxDp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(219, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blood Bank Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            this.btnLogout.AllowDrop = true;
            this.btnLogout.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnLogout.Location = new System.Drawing.Point(1, 57);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(157, 61);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.btnChangeDp);
            this.panelDropDown.Controls.Add(this.btnLogout);
            this.panelDropDown.Location = new System.Drawing.Point(795, 53);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(158, 118);
            this.panelDropDown.TabIndex = 4;
            this.panelDropDown.Visible = false;
            // 
            // btnChangeDp
            // 
            this.btnChangeDp.AllowDrop = true;
            this.btnChangeDp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChangeDp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeDp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnChangeDp.Location = new System.Drawing.Point(0, 0);
            this.btnChangeDp.Name = "btnChangeDp";
            this.btnChangeDp.Size = new System.Drawing.Size(157, 61);
            this.btnChangeDp.TabIndex = 2;
            this.btnChangeDp.Text = "Change Dp";
            this.btnChangeDp.UseVisualStyleBackColor = false;
            this.btnChangeDp.Click += new System.EventHandler(this.btnChangeDp_Click);
            // 
            // timerDropDown
            // 
            this.timerDropDown.Interval = 29;
            this.timerDropDown.Tick += new System.EventHandler(this.timerDropDown_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.lblCreateRequest);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblBookAppointment);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.lblLogout);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.lblExit);
            this.panel2.Location = new System.Drawing.Point(-1, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 478);
            this.panel2.TabIndex = 5;
            // 
            // lblCreateRequest
            // 
            this.lblCreateRequest.AutoSize = true;
            this.lblCreateRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblCreateRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCreateRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateRequest.ForeColor = System.Drawing.Color.White;
            this.lblCreateRequest.Location = new System.Drawing.Point(48, 102);
            this.lblCreateRequest.Name = "lblCreateRequest";
            this.lblCreateRequest.Size = new System.Drawing.Size(111, 64);
            this.lblCreateRequest.TabIndex = 31;
            this.lblCreateRequest.Text = "Create\r\nRequests";
            this.lblCreateRequest.Click += new System.EventHandler(this.lblCreateRequest_Click);
            this.lblCreateRequest.MouseEnter += new System.EventHandler(this.lblBookAppointment_MouseEnter);
            this.lblCreateRequest.MouseLeave += new System.EventHandler(this.lblBookAppointment_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(12, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 56);
            this.panel4.TabIndex = 32;
            // 
            // lblBookAppointment
            // 
            this.lblBookAppointment.AutoSize = true;
            this.lblBookAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblBookAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBookAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBookAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAppointment.ForeColor = System.Drawing.Color.White;
            this.lblBookAppointment.Location = new System.Drawing.Point(49, 29);
            this.lblBookAppointment.Name = "lblBookAppointment";
            this.lblBookAppointment.Size = new System.Drawing.Size(158, 64);
            this.lblBookAppointment.TabIndex = 29;
            this.lblBookAppointment.Text = "Book \r\nAppointment";
            this.lblBookAppointment.Click += new System.EventHandler(this.lblBookAppointment_Click);
            this.lblBookAppointment.MouseEnter += new System.EventHandler(this.lblBookAppointment_MouseEnter);
            this.lblBookAppointment.MouseLeave += new System.EventHandler(this.lblBookAppointment_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(11, 29);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(32, 64);
            this.panel8.TabIndex = 30;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(49, 177);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(91, 32);
            this.lblLogout.TabIndex = 25;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseEnter += new System.EventHandler(this.lblBookAppointment_MouseEnter);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblBookAppointment_MouseLeave);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(13, 177);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(30, 32);
            this.panel12.TabIndex = 27;
            this.panel12.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel13.BackgroundImage")));
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel13.Location = new System.Drawing.Point(13, 215);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(30, 32);
            this.panel13.TabIndex = 28;
            this.panel13.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(49, 215);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(53, 32);
            this.lblExit.TabIndex = 26;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblBookAppointment_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblBookAppointment_MouseLeave);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dgvAppointment.Location = new System.Drawing.Point(218, 327);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.Size = new System.Drawing.Size(734, 204);
            this.dgvAppointment.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Appointments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Location = new System.Drawing.Point(218, 82);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.Size = new System.Drawing.Size(735, 218);
            this.dgvRequest.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Requests";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(952, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDropDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDropDown.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxDp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Timer timerDropDown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblBookAppointment;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCreateRequest;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnChangeDp;
    }
}