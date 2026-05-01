namespace BBMS
{
    partial class ManagePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePatient));
            this.lblGoBack = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateCollection = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoEmergency = new System.Windows.Forms.RadioButton();
            this.txtUnitRequested = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExistingUser = new System.Windows.Forms.Label();
            this.btnCreateRequestOnly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitRequested)).BeginInit();
            this.panel1.SuspendLayout();
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 32);
            this.label11.TabIndex = 75;
            this.label11.Text = "City :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 32);
            this.label10.TabIndex = 74;
            this.label10.Text = "Blood Group :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCity.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.cmbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Abbottabad",
            "Attock",
            "Badin",
            "Bahawalpur",
            "Bhakkar",
            "Burewala",
            "Chakwal",
            "Charsadda",
            "Chiniot",
            "Dera Ghazi Khan",
            "Faisalabad",
            "Gujranwala",
            "Gujrat",
            "Gwadar",
            "Hafizabad",
            "Hyderabad",
            "Islamabad",
            "Jacobabad",
            "Jhelum",
            "Kamoke",
            "Karachi",
            "Kasur",
            "Khuzdar",
            "Kohat",
            "Lahore",
            "Larkana",
            "Mansehra",
            "Mardan",
            "Mingora",
            "Mirpur Khas",
            "Multan",
            "Muzaffargarh",
            "Nawabshah",
            "Nowshera",
            "Okara",
            "Peshawar",
            "Quetta",
            "Rahim Yar Khan",
            "Rawalpindi",
            "Sadiqabad",
            "Sargodha",
            "Sheikhupura",
            "Sialkot",
            "Sukkur",
            "Swabi",
            "Turbat",
            "Vehari"});
            this.cmbCity.Location = new System.Drawing.Point(101, 361);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(285, 34);
            this.cmbCity.Sorted = true;
            this.cmbCity.TabIndex = 73;
            this.cmbCity.Text = "Select Your City";
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
            this.cmbBloodGroup.Location = new System.Drawing.Point(203, 316);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(183, 34);
            this.cmbBloodGroup.Sorted = true;
            this.cmbBloodGroup.TabIndex = 72;
            this.cmbBloodGroup.Text = "Blood Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 32);
            this.label9.TabIndex = 71;
            this.label9.Text = "Need Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateCollection
            // 
            this.dateCollection.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateCollection.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateCollection.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateCollection.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateCollection.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dateCollection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCollection.Location = new System.Drawing.Point(163, 274);
            this.dateCollection.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            this.dateCollection.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateCollection.Name = "dateCollection";
            this.dateCollection.Size = new System.Drawing.Size(223, 25);
            this.dateCollection.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 32);
            this.label8.TabIndex = 69;
            this.label8.Text = "Gender";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.ForeColor = System.Drawing.Color.White;
            this.rdoFemale.Location = new System.Drawing.Point(190, 14);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(100, 34);
            this.rdoFemale.TabIndex = 68;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.ForeColor = System.Drawing.Color.White;
            this.rdoMale.Location = new System.Drawing.Point(105, 14);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(79, 34);
            this.rdoMale.TabIndex = 67;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAge.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtAge.Location = new System.Drawing.Point(110, 120);
            this.txtAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(264, 34);
            this.txtAge.TabIndex = 66;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 65;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtPassword.Location = new System.Drawing.Point(151, 236);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(223, 32);
            this.txtPassword.TabIndex = 64;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 32);
            this.label5.TabIndex = 63;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtEmail.Location = new System.Drawing.Point(110, 82);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 32);
            this.txtEmail.TabIndex = 62;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 61;
            this.label4.Text = "Cnic";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCnic
            // 
            this.txtCnic.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCnic.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtCnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtCnic.Location = new System.Drawing.Point(110, 160);
            this.txtCnic.MaxLength = 15;
            this.txtCnic.Multiline = true;
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(264, 32);
            this.txtCnic.TabIndex = 60;
            this.txtCnic.TextChanged += new System.EventHandler(this.txtCnic_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 32);
            this.label2.TabIndex = 59;
            this.label2.Text = "Age";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtName.Location = new System.Drawing.Point(110, 198);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 32);
            this.txtName.TabIndex = 57;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblInvalid.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.White;
            this.lblInvalid.Location = new System.Drawing.Point(68, 398);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(274, 32);
            this.lblInvalid.TabIndex = 76;
            this.lblInvalid.Text = "Credentials Are Invalid";
            this.lblInvalid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(388, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 32);
            this.label12.TabIndex = 82;
            this.label12.Text = "Condition";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal.ForeColor = System.Drawing.Color.White;
            this.rdoNormal.Location = new System.Drawing.Point(651, 119);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(105, 34);
            this.rdoNormal.TabIndex = 81;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoEmergency
            // 
            this.rdoEmergency.AutoSize = true;
            this.rdoEmergency.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEmergency.ForeColor = System.Drawing.Color.White;
            this.rdoEmergency.Location = new System.Drawing.Point(521, 119);
            this.rdoEmergency.Name = "rdoEmergency";
            this.rdoEmergency.Size = new System.Drawing.Size(138, 34);
            this.rdoEmergency.TabIndex = 80;
            this.rdoEmergency.TabStop = true;
            this.rdoEmergency.Text = "Emergency";
            this.rdoEmergency.UseVisualStyleBackColor = true;
            // 
            // txtUnitRequested
            // 
            this.txtUnitRequested.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUnitRequested.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtUnitRequested.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtUnitRequested.Location = new System.Drawing.Point(521, 76);
            this.txtUnitRequested.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtUnitRequested.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUnitRequested.Name = "txtUnitRequested";
            this.txtUnitRequested.Size = new System.Drawing.Size(264, 34);
            this.txtUnitRequested.TabIndex = 84;
            this.txtUnitRequested.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnitRequested.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(380, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 32);
            this.label7.TabIndex = 83;
            this.label7.Text = "Units Need";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnAdd.Location = new System.Drawing.Point(442, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(235, 60);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnClear.Location = new System.Drawing.Point(442, 417);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(235, 60);
            this.btnClear.TabIndex = 85;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(213, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 41);
            this.label3.TabIndex = 87;
            this.label3.Text = "Blood Bank Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rdoMale);
            this.panel1.Controls.Add(this.rdoFemale);
            this.panel1.Location = new System.Drawing.Point(394, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 57);
            this.panel1.TabIndex = 88;
            // 
            // lblExistingUser
            // 
            this.lblExistingUser.AutoSize = true;
            this.lblExistingUser.BackColor = System.Drawing.Color.Transparent;
            this.lblExistingUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblExistingUser.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingUser.ForeColor = System.Drawing.Color.White;
            this.lblExistingUser.Location = new System.Drawing.Point(436, 233);
            this.lblExistingUser.Name = "lblExistingUser";
            this.lblExistingUser.Size = new System.Drawing.Size(0, 32);
            this.lblExistingUser.TabIndex = 89;
            this.lblExistingUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreateRequestOnly
            // 
            this.btnCreateRequestOnly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRequestOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnCreateRequestOnly.Location = new System.Drawing.Point(442, 290);
            this.btnCreateRequestOnly.Name = "btnCreateRequestOnly";
            this.btnCreateRequestOnly.Size = new System.Drawing.Size(235, 60);
            this.btnCreateRequestOnly.TabIndex = 90;
            this.btnCreateRequestOnly.Text = "Create Request Only";
            this.btnCreateRequestOnly.UseVisualStyleBackColor = true;
            this.btnCreateRequestOnly.Click += new System.EventHandler(this.btnCreateRequestOnly_Click);
            // 
            // ManagePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(950, 507);
            this.Controls.Add(this.btnCreateRequestOnly);
            this.Controls.Add(this.lblExistingUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtUnitRequested);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rdoNormal);
            this.Controls.Add(this.rdoEmergency);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbBloodGroup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateCollection);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGoBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagePatient";
            this.Text = "ManagePatient";
            this.Load += new System.EventHandler(this.ManagePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitRequested)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateCollection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.NumericUpDown txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoEmergency;
        private System.Windows.Forms.NumericUpDown txtUnitRequested;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExistingUser;
        private System.Windows.Forms.Button btnCreateRequestOnly;
    }
}