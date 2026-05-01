namespace BBMS
{
    partial class ManageDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDonor));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateCollection = new System.Windows.Forms.DateTimePicker();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastDonation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCountUsers = new System.Windows.Forms.Label();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.btnAddDonation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnDelete.Location = new System.Drawing.Point(468, 278);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 48);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnClear.Location = new System.Drawing.Point(678, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 48);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnAdd.Location = new System.Drawing.Point(363, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnUpdate.Location = new System.Drawing.Point(573, 278);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 48);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearchUser.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtSearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtSearchUser.Location = new System.Drawing.Point(101, 47);
            this.txtSearchUser.Multiline = true;
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(264, 32);
            this.txtSearchUser.TabIndex = 5;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtName.Location = new System.Drawing.Point(101, 85);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 32);
            this.txtName.TabIndex = 10;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Age";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cnic";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCnic
            // 
            this.txtCnic.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCnic.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtCnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtCnic.Location = new System.Drawing.Point(101, 167);
            this.txtCnic.MaxLength = 15;
            this.txtCnic.Multiline = true;
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(264, 32);
            this.txtCnic.TabIndex = 14;
            this.txtCnic.TextChanged += new System.EventHandler(this.txtCnic_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtEmail.Location = new System.Drawing.Point(101, 205);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 32);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtPassword.Location = new System.Drawing.Point(142, 243);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(223, 32);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAge.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtAge.Location = new System.Drawing.Point(101, 127);
            this.txtAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(264, 34);
            this.txtAge.TabIndex = 42;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.ForeColor = System.Drawing.Color.White;
            this.rdoFemale.Location = new System.Drawing.Point(216, 283);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(100, 34);
            this.rdoFemale.TabIndex = 46;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.ForeColor = System.Drawing.Color.White;
            this.rdoMale.Location = new System.Drawing.Point(131, 283);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(79, 34);
            this.rdoMale.TabIndex = 45;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 32);
            this.label8.TabIndex = 47;
            this.label8.Text = "Gender";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 32);
            this.label9.TabIndex = 49;
            this.label9.Text = "Last Donation :";
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
            this.dateCollection.Location = new System.Drawing.Point(223, 327);
            this.dateCollection.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            this.dateCollection.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateCollection.Name = "dateCollection";
            this.dateCollection.Size = new System.Drawing.Size(239, 25);
            this.dateCollection.TabIndex = 48;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColBloodGroup,
            this.ColAge,
            this.colUpdate,
            this.colSelect,
            this.colCnic,
            this.colEmail,
            this.ColLastDonation});
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.dgvUsers.Location = new System.Drawing.Point(371, 44);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(579, 228);
            this.dgvUsers.TabIndex = 50;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            // 
            // ColBloodGroup
            // 
            this.ColBloodGroup.DataPropertyName = "BloodGroup";
            this.ColBloodGroup.HeaderText = "Blood Group";
            this.ColBloodGroup.Name = "ColBloodGroup";
            // 
            // ColAge
            // 
            this.ColAge.DataPropertyName = "Age";
            this.ColAge.HeaderText = "Age";
            this.ColAge.Name = "ColAge";
            // 
            // colUpdate
            // 
            this.colUpdate.HeaderText = "Update";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.Text = "Update";
            this.colUpdate.ToolTipText = "Click";
            this.colUpdate.UseColumnTextForButtonValue = true;
            // 
            // colSelect
            // 
            this.colSelect.FalseValue = "false";
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.ToolTipText = "Press";
            this.colSelect.TrueValue = "true";
            // 
            // colCnic
            // 
            this.colCnic.DataPropertyName = "Cnic";
            this.colCnic.HeaderText = "Cnic";
            this.colCnic.Name = "colCnic";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // ColLastDonation
            // 
            this.ColLastDonation.DataPropertyName = "LastDonation";
            this.ColLastDonation.HeaderText = "LastDonation";
            this.ColLastDonation.Name = "ColLastDonation";
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
            this.cmbCity.Location = new System.Drawing.Point(194, 413);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(285, 34);
            this.cmbCity.Sorted = true;
            this.cmbCity.TabIndex = 52;
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
            this.cmbBloodGroup.Location = new System.Drawing.Point(194, 368);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(285, 34);
            this.cmbBloodGroup.Sorted = true;
            this.cmbBloodGroup.TabIndex = 51;
            this.cmbBloodGroup.Text = "Select Your Blood Group";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 32);
            this.label10.TabIndex = 53;
            this.label10.Text = "Blood Group :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 32);
            this.label11.TabIndex = 54;
            this.label11.Text = "City :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCountUsers
            // 
            this.lblCountUsers.AutoSize = true;
            this.lblCountUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblCountUsers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCountUsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCountUsers.ForeColor = System.Drawing.Color.White;
            this.lblCountUsers.Location = new System.Drawing.Point(365, 9);
            this.lblCountUsers.Name = "lblCountUsers";
            this.lblCountUsers.Size = new System.Drawing.Size(170, 32);
            this.lblCountUsers.TabIndex = 55;
            this.lblCountUsers.Text = "Users count : ";
            this.lblCountUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblInvalid.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.White;
            this.lblInvalid.Location = new System.Drawing.Point(188, 459);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(274, 32);
            this.lblInvalid.TabIndex = 56;
            this.lblInvalid.Text = "Credentials Are Invalid";
            this.lblInvalid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddDonation
            // 
            this.btnAddDonation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDonation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.btnAddDonation.Location = new System.Drawing.Point(783, 278);
            this.btnAddDonation.Name = "btnAddDonation";
            this.btnAddDonation.Size = new System.Drawing.Size(135, 48);
            this.btnAddDonation.TabIndex = 57;
            this.btnAddDonation.Text = "Add Donation";
            this.btnAddDonation.UseVisualStyleBackColor = true;
            this.btnAddDonation.Click += new System.EventHandler(this.btnAddDonation_Click);
            // 
            // ManageDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(954, 500);
            this.Controls.Add(this.btnAddDonation);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.lblCountUsers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbBloodGroup);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateCollection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageDonor";
            this.Text = "ManageDonor";
            this.Load += new System.EventHandler(this.ManageDonor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.NumericUpDown txtAge;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateCollection;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCountUsers;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAge;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastDonation;
        private System.Windows.Forms.Button btnAddDonation;
    }
}