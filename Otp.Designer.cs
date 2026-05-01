namespace BBMS
{
    partial class Otp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWrongOtp = new System.Windows.Forms.Label();
            this.lblResendOtp = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtOTP6 = new System.Windows.Forms.TextBox();
            this.txtOTP5 = new System.Windows.Forms.TextBox();
            this.txtOTP4 = new System.Windows.Forms.TextBox();
            this.txtOTP2 = new System.Windows.Forms.TextBox();
            this.txtOTP3 = new System.Windows.Forms.TextBox();
            this.txtOTP1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblEmailHeader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerOtp = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblWrongOtp);
            this.panel1.Controls.Add(this.lblResendOtp);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.txtOTP6);
            this.panel1.Controls.Add(this.txtOTP5);
            this.panel1.Controls.Add(this.txtOTP4);
            this.panel1.Controls.Add(this.txtOTP2);
            this.panel1.Controls.Add(this.txtOTP3);
            this.panel1.Controls.Add(this.txtOTP1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblEmailHeader);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-20, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 446);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblWrongOtp
            // 
            this.lblWrongOtp.AutoSize = true;
            this.lblWrongOtp.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongOtp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblWrongOtp.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongOtp.ForeColor = System.Drawing.Color.White;
            this.lblWrongOtp.Location = new System.Drawing.Point(501, 168);
            this.lblWrongOtp.Name = "lblWrongOtp";
            this.lblWrongOtp.Size = new System.Drawing.Size(120, 28);
            this.lblWrongOtp.TabIndex = 18;
            this.lblWrongOtp.Text = "Wrong OTP";
            this.lblWrongOtp.Visible = false;
            // 
            // lblResendOtp
            // 
            this.lblResendOtp.AutoSize = true;
            this.lblResendOtp.BackColor = System.Drawing.Color.Transparent;
            this.lblResendOtp.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblResendOtp.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResendOtp.ForeColor = System.Drawing.Color.White;
            this.lblResendOtp.Location = new System.Drawing.Point(220, 324);
            this.lblResendOtp.Name = "lblResendOtp";
            this.lblResendOtp.Size = new System.Drawing.Size(290, 28);
            this.lblResendOtp.TabIndex = 17;
            this.lblResendOtp.Text = " Didn\'t receive code? Resend ";
            this.lblResendOtp.Click += new System.EventHandler(this.lblResendOtp_Click);
            this.lblResendOtp.MouseEnter += new System.EventHandler(this.lblResendOtp_MouseEnter);
            this.lblResendOtp.MouseLeave += new System.EventHandler(this.lblResendOtp_MouseLeave);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.btnVerify.Location = new System.Drawing.Point(271, 273);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(180, 38);
            this.btnVerify.TabIndex = 16;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(242, 221);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 28);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "⏱";
            // 
            // txtOTP6
            // 
            this.txtOTP6.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOTP6.Font = new System.Drawing.Font("Segoe UI Semibold", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtOTP6.Location = new System.Drawing.Point(455, 154);
            this.txtOTP6.MaxLength = 1;
            this.txtOTP6.Multiline = true;
            this.txtOTP6.Name = "txtOTP6";
            this.txtOTP6.Size = new System.Drawing.Size(40, 50);
            this.txtOTP6.TabIndex = 14;
            this.txtOTP6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTP6.TextChanged += new System.EventHandler(this.txtOTP6_TextChanged);
            // 
            // txtOTP5
            // 
            this.txtOTP5.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOTP5.Font = new System.Drawing.Font("Segoe UI Semibold", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtOTP5.Location = new System.Drawing.Point(409, 154);
            this.txtOTP5.MaxLength = 1;
            this.txtOTP5.Multiline = true;
            this.txtOTP5.Name = "txtOTP5";
            this.txtOTP5.Size = new System.Drawing.Size(40, 50);
            this.txtOTP5.TabIndex = 13;
            this.txtOTP5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTP5.TextChanged += new System.EventHandler(this.txtOTP5_TextChanged);
            // 
            // txtOTP4
            // 
            this.txtOTP4.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOTP4.Font = new System.Drawing.Font("Segoe UI Semibold", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtOTP4.Location = new System.Drawing.Point(363, 154);
            this.txtOTP4.MaxLength = 1;
            this.txtOTP4.Multiline = true;
            this.txtOTP4.Name = "txtOTP4";
            this.txtOTP4.Size = new System.Drawing.Size(40, 50);
            this.txtOTP4.TabIndex = 12;
            this.txtOTP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTP4.TextChanged += new System.EventHandler(this.txtOTP4_TextChanged);
            // 
            // txtOTP2
            // 
            this.txtOTP2.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOTP2.Font = new System.Drawing.Font("Segoe UI Semibold", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtOTP2.Location = new System.Drawing.Point(271, 154);
            this.txtOTP2.MaxLength = 1;
            this.txtOTP2.Multiline = true;
            this.txtOTP2.Name = "txtOTP2";
            this.txtOTP2.Size = new System.Drawing.Size(40, 50);
            this.txtOTP2.TabIndex = 11;
            this.txtOTP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTP2.TextChanged += new System.EventHandler(this.txtOTP2_TextChanged);
            // 
            // txtOTP3
            // 
            this.txtOTP3.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOTP3.Font = new System.Drawing.Font("Segoe UI Semibold", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtOTP3.Location = new System.Drawing.Point(317, 154);
            this.txtOTP3.MaxLength = 1;
            this.txtOTP3.Multiline = true;
            this.txtOTP3.Name = "txtOTP3";
            this.txtOTP3.Size = new System.Drawing.Size(40, 50);
            this.txtOTP3.TabIndex = 10;
            this.txtOTP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTP3.TextChanged += new System.EventHandler(this.txtOTP3_TextChanged);
            // 
            // txtOTP1
            // 
            this.txtOTP1.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOTP1.Font = new System.Drawing.Font("Segoe UI Semibold", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.txtOTP1.Location = new System.Drawing.Point(225, 154);
            this.txtOTP1.MaxLength = 1;
            this.txtOTP1.Multiline = true;
            this.txtOTP1.Name = "txtOTP1";
            this.txtOTP1.Size = new System.Drawing.Size(40, 50);
            this.txtOTP1.TabIndex = 9;
            this.txtOTP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTP1.TextChanged += new System.EventHandler(this.txtOTP1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(192, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "        Enter OTP Code Below                   ";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(725, 3);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(25, 28);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            // 
            // lblEmailHeader
            // 
            this.lblEmailHeader.AutoSize = true;
            this.lblEmailHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailHeader.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblEmailHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblEmailHeader.ForeColor = System.Drawing.Color.White;
            this.lblEmailHeader.Location = new System.Drawing.Point(161, 72);
            this.lblEmailHeader.Name = "lblEmailHeader";
            this.lblEmailHeader.Size = new System.Drawing.Size(315, 28);
            this.lblEmailHeader.TabIndex = 6;
            this.lblEmailHeader.Text = " We have sent a 6-digit code to ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "              🔐 Verify Your OTP              ";
            // 
            // timerOtp
            // 
            this.timerOtp.Interval = 1000;
            this.timerOtp.Tick += new System.EventHandler(this.timerOtp_Tick);
            // 
            // Otp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(736, 441);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Otp";
            this.Text = "Otp";
            this.Load += new System.EventHandler(this.Otp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblEmailHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtOTP6;
        private System.Windows.Forms.TextBox txtOTP5;
        private System.Windows.Forms.TextBox txtOTP4;
        private System.Windows.Forms.TextBox txtOTP2;
        private System.Windows.Forms.TextBox txtOTP3;
        private System.Windows.Forms.TextBox txtOTP1;
        private System.Windows.Forms.Label lblResendOtp;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Timer timerOtp;
        private System.Windows.Forms.Label lblWrongOtp;
    }
}