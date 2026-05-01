namespace BBMS
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvalidEmai = new System.Windows.Forms.Label();
            this.lblWrongPassword = new System.Windows.Forms.Label();
            this.rdoUser = new System.Windows.Forms.RadioButton();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForgetPassword = new System.Windows.Forms.Label();
            this.LblSignIn = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.picturePasswordShow = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblInvalidEmai);
            this.panel1.Controls.Add(this.lblWrongPassword);
            this.panel1.Controls.Add(this.rdoUser);
            this.panel1.Controls.Add(this.rdoAdmin);
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblForgetPassword);
            this.panel1.Controls.Add(this.LblSignIn);
            this.panel1.Controls.Add(this.pictureBoxUser);
            this.panel1.Controls.Add(this.picturePasswordShow);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(352, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 503);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblInvalidEmai
            // 
            this.lblInvalidEmai.AutoSize = true;
            this.lblInvalidEmai.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidEmai.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblInvalidEmai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInvalidEmai.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblInvalidEmai.ForeColor = System.Drawing.Color.White;
            this.lblInvalidEmai.Location = new System.Drawing.Point(341, 230);
            this.lblInvalidEmai.Name = "lblInvalidEmai";
            this.lblInvalidEmai.Size = new System.Drawing.Size(73, 13);
            this.lblInvalidEmai.TabIndex = 14;
            this.lblInvalidEmai.Text = "Invalid Email";
            this.lblInvalidEmai.Visible = false;
            // 
            // lblWrongPassword
            // 
            this.lblWrongPassword.AutoSize = true;
            this.lblWrongPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblWrongPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWrongPassword.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblWrongPassword.ForeColor = System.Drawing.Color.White;
            this.lblWrongPassword.Location = new System.Drawing.Point(341, 268);
            this.lblWrongPassword.Name = "lblWrongPassword";
            this.lblWrongPassword.Size = new System.Drawing.Size(95, 13);
            this.lblWrongPassword.TabIndex = 13;
            this.lblWrongPassword.Text = "Invalid Password";
            this.lblWrongPassword.Visible = false;
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoUser.Location = new System.Drawing.Point(194, 311);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(70, 29);
            this.rdoUser.TabIndex = 12;
            this.rdoUser.TabStop = true;
            this.rdoUser.Text = "User";
            this.rdoUser.UseVisualStyleBackColor = true;
            this.rdoUser.MouseEnter += new System.EventHandler(this.rdoUser_MouseEnter);
            this.rdoUser.MouseLeave += new System.EventHandler(this.rdoUser_MouseLeave);
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoAdmin.Location = new System.Drawing.Point(99, 311);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(89, 29);
            this.rdoAdmin.TabIndex = 11;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Admin";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            this.rdoAdmin.CheckedChanged += new System.EventHandler(this.rdoAdmin_CheckedChanged);
            this.rdoAdmin.MouseEnter += new System.EventHandler(this.rdoAdmin_MouseEnter);
            this.rdoAdmin.MouseLeave += new System.EventHandler(this.rdoAdmin_MouseLeave);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(430, 7);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(31, 42);
            this.lblMinimize.TabIndex = 9;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.label6_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.btnLogin.Location = new System.Drawing.Point(99, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(236, 37);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgetPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgetPassword.Location = new System.Drawing.Point(96, 294);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(94, 13);
            this.lblForgetPassword.TabIndex = 7;
            this.lblForgetPassword.Text = "Forget Password";
            this.lblForgetPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblForgetPassword.Click += new System.EventHandler(this.label5_Click);
            // 
            // LblSignIn
            // 
            this.LblSignIn.AutoSize = true;
            this.LblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.LblSignIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignIn.ForeColor = System.Drawing.Color.White;
            this.LblSignIn.Location = new System.Drawing.Point(95, 386);
            this.LblSignIn.Name = "LblSignIn";
            this.LblSignIn.Size = new System.Drawing.Size(240, 21);
            this.LblSignIn.TabIndex = 6;
            this.LblSignIn.Text = "Dont have an account? Sign in";
            this.LblSignIn.Click += new System.EventHandler(this.LblSignIn_Click);
            this.LblSignIn.MouseEnter += new System.EventHandler(this.LblSignIn_MouseEnter);
            this.LblSignIn.MouseLeave += new System.EventHandler(this.LblSignIn_MouseLeave);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(113, 38);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(237, 166);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 6;
            this.pictureBoxUser.TabStop = false;
            // 
            // picturePasswordShow
            // 
            this.picturePasswordShow.BackColor = System.Drawing.Color.Gainsboro;
            this.picturePasswordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePasswordShow.Image = ((System.Drawing.Image)(resources.GetObject("picturePasswordShow.Image")));
            this.picturePasswordShow.Location = new System.Drawing.Point(306, 260);
            this.picturePasswordShow.Name = "picturePasswordShow";
            this.picturePasswordShow.Size = new System.Drawing.Size(29, 30);
            this.picturePasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePasswordShow.TabIndex = 5;
            this.picturePasswordShow.TabStop = false;
            this.picturePasswordShow.Click += new System.EventHandler(this.picturePasswordShow_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtPassword.Location = new System.Drawing.Point(98, 259);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(237, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Enter your Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtEmail.Location = new System.Drawing.Point(98, 221);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 32);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Enter your Email";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.MouseEnter += new System.EventHandler(this.txtEmail_MouseEnter);
            this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(17, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 72);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blood Bank ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(846, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picturePasswordShow;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label LblSignIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblForgetPassword;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.Label lblInvalidEmai;
        private System.Windows.Forms.Label lblWrongPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}