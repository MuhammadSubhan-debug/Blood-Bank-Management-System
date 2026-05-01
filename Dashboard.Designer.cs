namespace BBMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblDonationRecords = new System.Windows.Forms.Label();
            this.lblShowRequest = new System.Windows.Forms.Label();
            this.lblMangePatient = new System.Windows.Forms.Label();
            this.lblManageRecords = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblEmergencyRequest = new System.Windows.Forms.Label();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxDp = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerDropDown = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangeDp = new System.Windows.Forms.Button();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDropDown.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblInventory);
            this.panel1.Controls.Add(this.lblDonationRecords);
            this.panel1.Controls.Add(this.lblShowRequest);
            this.panel1.Controls.Add(this.lblMangePatient);
            this.panel1.Controls.Add(this.lblManageRecords);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.lblEmergencyRequest);
            this.panel1.Controls.Add(this.lblAppointment);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 628);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(4, 424);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(30, 32);
            this.panel9.TabIndex = 24;
            this.panel9.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(4, 350);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 32);
            this.panel7.TabIndex = 24;
            this.panel7.Click += new System.EventHandler(this.lblInventory_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel11.Location = new System.Drawing.Point(3, 81);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(30, 32);
            this.panel11.TabIndex = 19;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(40, 81);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(132, 32);
            this.lblDashboard.TabIndex = 26;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(39, 386);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(91, 32);
            this.lblLogout.TabIndex = 15;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseEnter += new System.EventHandler(this.lblDonationRecords_MouseEnter);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblDonationRecords_MouseLeave);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.White;
            this.lblInventory.Location = new System.Drawing.Point(40, 350);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(119, 32);
            this.lblInventory.TabIndex = 9;
            this.lblInventory.Text = "Inventory";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblInventory.Click += new System.EventHandler(this.lblInventory_Click);
            this.lblInventory.MouseEnter += new System.EventHandler(this.lblDonationRecords_MouseEnter);
            this.lblInventory.MouseLeave += new System.EventHandler(this.lblDonationRecords_MouseLeave);
            // 
            // lblDonationRecords
            // 
            this.lblDonationRecords.AutoSize = true;
            this.lblDonationRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblDonationRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDonationRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDonationRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonationRecords.ForeColor = System.Drawing.Color.White;
            this.lblDonationRecords.Location = new System.Drawing.Point(35, 122);
            this.lblDonationRecords.Name = "lblDonationRecords";
            this.lblDonationRecords.Size = new System.Drawing.Size(207, 32);
            this.lblDonationRecords.TabIndex = 10;
            this.lblDonationRecords.Text = "Donation Records";
            this.lblDonationRecords.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDonationRecords.Click += new System.EventHandler(this.lblDonationRecords_Click);
            this.lblDonationRecords.MouseEnter += new System.EventHandler(this.lblDonationRecords_MouseEnter);
            this.lblDonationRecords.MouseLeave += new System.EventHandler(this.lblDonationRecords_MouseLeave);
            // 
            // lblShowRequest
            // 
            this.lblShowRequest.AutoSize = true;
            this.lblShowRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblShowRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblShowRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRequest.ForeColor = System.Drawing.Color.White;
            this.lblShowRequest.Location = new System.Drawing.Point(40, 236);
            this.lblShowRequest.Name = "lblShowRequest";
            this.lblShowRequest.Size = new System.Drawing.Size(177, 32);
            this.lblShowRequest.TabIndex = 17;
            this.lblShowRequest.Text = "Show Requests";
            this.lblShowRequest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblShowRequest.Click += new System.EventHandler(this.lblShowRequest_Click);
            this.lblShowRequest.MouseEnter += new System.EventHandler(this.lblDonationRecords_MouseEnter);
            this.lblShowRequest.MouseLeave += new System.EventHandler(this.lblDonationRecords_MouseLeave);
            // 
            // lblMangePatient
            // 
            this.lblMangePatient.AutoSize = true;
            this.lblMangePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblMangePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMangePatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMangePatient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangePatient.ForeColor = System.Drawing.Color.White;
            this.lblMangePatient.Location = new System.Drawing.Point(39, 198);
            this.lblMangePatient.Name = "lblMangePatient";
            this.lblMangePatient.Size = new System.Drawing.Size(187, 32);
            this.lblMangePatient.TabIndex = 8;
            this.lblMangePatient.Text = "Manage Patient";
            this.lblMangePatient.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMangePatient.Click += new System.EventHandler(this.lblMangePatient_Click);
            this.lblMangePatient.MouseEnter += new System.EventHandler(this.lblDonationRecords_MouseEnter);
            this.lblMangePatient.MouseLeave += new System.EventHandler(this.lblDonationRecords_MouseLeave);
            // 
            // lblManageRecords
            // 
            this.lblManageRecords.AutoSize = true;
            this.lblManageRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblManageRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblManageRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblManageRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRecords.ForeColor = System.Drawing.Color.White;
            this.lblManageRecords.Location = new System.Drawing.Point(39, 160);
            this.lblManageRecords.Name = "lblManageRecords";
            this.lblManageRecords.Size = new System.Drawing.Size(178, 32);
            this.lblManageRecords.TabIndex = 7;
            this.lblManageRecords.Text = "Manage Donor";
            this.lblManageRecords.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblManageRecords.Click += new System.EventHandler(this.lblManageRecords_Click);
            this.lblManageRecords.MouseEnter += new System.EventHandler(this.lblDonationRecords_MouseEnter);
            this.lblManageRecords.MouseLeave += new System.EventHandler(this.lblDonationRecords_MouseLeave);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(3, 386);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(30, 32);
            this.panel12.TabIndex = 23;
            this.panel12.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblEmergencyRequest
            // 
            this.lblEmergencyRequest.AutoSize = true;
            this.lblEmergencyRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblEmergencyRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmergencyRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmergencyRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyRequest.ForeColor = System.Drawing.Color.White;
            this.lblEmergencyRequest.Location = new System.Drawing.Point(40, 274);
            this.lblEmergencyRequest.Name = "lblEmergencyRequest";
            this.lblEmergencyRequest.Size = new System.Drawing.Size(234, 32);
            this.lblEmergencyRequest.TabIndex = 13;
            this.lblEmergencyRequest.Text = "Emergency Request ";
            this.lblEmergencyRequest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEmergencyRequest.Click += new System.EventHandler(this.lblEmergencyRequest_Click);
            this.lblEmergencyRequest.MouseEnter += new System.EventHandler(this.lblDonationRecords_MouseEnter);
            this.lblEmergencyRequest.MouseLeave += new System.EventHandler(this.lblDonationRecords_MouseLeave);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.Color.White;
            this.lblAppointment.Location = new System.Drawing.Point(39, 312);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(168, 32);
            this.lblAppointment.TabIndex = 12;
            this.lblAppointment.Text = "Appointments";
            this.lblAppointment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAppointment.Click += new System.EventHandler(this.lblAppointment_Click);
            this.lblAppointment.MouseEnter += new System.EventHandler(this.lblDonationRecords_MouseEnter);
            this.lblAppointment.MouseLeave += new System.EventHandler(this.lblDonationRecords_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(3, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 32);
            this.panel4.TabIndex = 21;
            this.panel4.Click += new System.EventHandler(this.lblShowRequest_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(3, 312);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 32);
            this.panel8.TabIndex = 23;
            this.panel8.Click += new System.EventHandler(this.lblAppointment_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(3, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 32);
            this.panel5.TabIndex = 19;
            this.panel5.Click += new System.EventHandler(this.lblManageRecords_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(3, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 32);
            this.panel6.TabIndex = 20;
            this.panel6.Click += new System.EventHandler(this.lblMangePatient_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(3, 274);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 32);
            this.panel10.TabIndex = 22;
            this.panel10.Click += new System.EventHandler(this.lblEmergencyRequest_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(39, 424);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(53, 32);
            this.lblExit.TabIndex = 16;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblDonationRecords_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblDonationRecords_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(3, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 32);
            this.panel3.TabIndex = 18;
            this.panel3.Click += new System.EventHandler(this.lblDonationRecords_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.pictureBoxDp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 55);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxDp
            // 
            this.pictureBoxDp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDp.Image")));
            this.pictureBoxDp.Location = new System.Drawing.Point(867, 2);
            this.pictureBoxDp.Name = "pictureBoxDp";
            this.pictureBoxDp.Size = new System.Drawing.Size(42, 45);
            this.pictureBoxDp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDp.TabIndex = 2;
            this.pictureBoxDp.TabStop = false;
            this.pictureBoxDp.Click += new System.EventHandler(this.pictureBoxDp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(272, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blood Bank Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timerDropDown
            // 
            this.timerDropDown.Interval = 20;
            this.timerDropDown.Tick += new System.EventHandler(this.timerDropDown_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Tag = "pictureBoxDp";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Display Image";
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDropDown.Controls.Add(this.btnLogout);
            this.panelDropDown.Controls.Add(this.btnChangeDp);
            this.panelDropDown.Location = new System.Drawing.Point(510, 0);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(143, 114);
            this.panelDropDown.TabIndex = 2;
            this.panelDropDown.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnLogout.Location = new System.Drawing.Point(-18, 54);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(175, 71);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangeDp
            // 
            this.btnChangeDp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChangeDp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeDp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeDp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnChangeDp.Location = new System.Drawing.Point(0, 0);
            this.btnChangeDp.Name = "btnChangeDp";
            this.btnChangeDp.Size = new System.Drawing.Size(157, 61);
            this.btnChangeDp.TabIndex = 0;
            this.btnChangeDp.Text = "Change Profile Picture";
            this.btnChangeDp.UseVisualStyleBackColor = false;
            this.btnChangeDp.Click += new System.EventHandler(this.btnChangeDp_Click);
            // 
            // lblUserCount
            // 
            this.lblUserCount.AutoSize = true;
            this.lblUserCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.lblUserCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUserCount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCount.ForeColor = System.Drawing.Color.White;
            this.lblUserCount.Location = new System.Drawing.Point(10, 10);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(156, 32);
            this.lblUserCount.TabIndex = 27;
            this.lblUserCount.Text = "User Count : ";
            this.lblUserCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DarkGray;
            this.panelMain.Controls.Add(this.lblUserCount);
            this.panelMain.Controls.Add(this.panelDropDown);
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Location = new System.Drawing.Point(262, 52);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(653, 576);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(553, 455);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(915, 628);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDropDown.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblManageRecords;
        private System.Windows.Forms.Label lblMangePatient;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Label lblDonationRecords;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblEmergencyRequest;
        private System.Windows.Forms.Label lblShowRequest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBoxDp;
        private System.Windows.Forms.Timer timerDropDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangeDp;
        private System.Windows.Forms.Label lblUserCount;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}