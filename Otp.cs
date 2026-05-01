using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace BBMS
{

    public partial class Otp : Form
    {
        private int timeLeft = 60;
        string generatedOtp="";
        string EnteredOtp = "";
        string UserEmail = "";
        User fromUser=null;
        public Otp(User u,string otp)
        {
            InitializeComponent();
            lblEmailHeader.Text += u.Email;
            this.generatedOtp = otp;
            UserEmail = u.Email;
            fromUser = u;
        }

       

    private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtOTP6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtOTP2_TextChanged(object sender, EventArgs e)
        {
            if (txtOTP1.Text.Length == 1)
                txtOTP3.Focus();
        }

        private void txtOTP3_TextChanged(object sender, EventArgs e)
        {
            if (txtOTP1.Text.Length == 1)
                txtOTP4.Focus();
        }

        private void txtOTP4_TextChanged(object sender, EventArgs e)
        {
            if (txtOTP1.Text.Length == 1)
                txtOTP5.Focus();
        }

        private void txtOTP5_TextChanged(object sender, EventArgs e)
        {
            if (txtOTP1.Text.Length == 1)
                txtOTP6.Focus();
        }

        private void txtOTP1_TextChanged(object sender, EventArgs e)
        {
            if (txtOTP1.Text.Length == 1)
                txtOTP2.Focus();
        }

        private void lblResendOtp_MouseEnter(object sender, EventArgs e)
        {
            lblResendOtp.BackColor = Color.White;
            lblResendOtp.ForeColor = Color.Red;
        }

        private void lblResendOtp_MouseLeave(object sender, EventArgs e)
        {
            lblResendOtp.BackColor = Color.Transparent;
            lblResendOtp.ForeColor = Color.White;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {

            lblExit.BackColor = Color.Transparent;
            lblExit.ForeColor = Color.White;
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
           lblExit. BackColor = Color.White;
            lblExit.ForeColor = Color.Red;

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            EnteredOtp += txtOTP1.Text;
            EnteredOtp += txtOTP2.Text;
            EnteredOtp += txtOTP3.Text;
            EnteredOtp += txtOTP4.Text;
            EnteredOtp += txtOTP5.Text;
            EnteredOtp += txtOTP6.Text;
            if (EnteredOtp == generatedOtp)
            {
                fromUser.isVerfied = true;
                UpdateVerfied(fromUser);

                LoginPage obj = new LoginPage();
                this.Hide();
                obj.Show();

            }
            else {
                lblWrongOtp.Visible = true;
                txtOTP1.Text = "";
                txtOTP2.Text = "";
                txtOTP3.Text = "";
                txtOTP4.Text = "";
                txtOTP5.Text = "";
                txtOTP6.Text = "";
                timerOtp.Stop();
                lblTime.Text = "Expired";
                lblResendOtp.Enabled = true;

            }
            // MessageBox.Show($"Your enter {EnteredOtp}");
        }
        public void UpdateVerfied(User u)
        {

            string q = @"update users set IsVerified='true' where userId=@userId";
            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            cmd.Parameters.AddWithValue("@userId", u.UserId);
            DBManager.Open();
            cmd.ExecuteNonQuery();
            DBManager.Close();



        }
        private void Otp_Load(object sender, EventArgs e)
        {
            timerOtp.Start();
            lblResendOtp.Enabled = false;
        }

        private void timerOtp_Tick(object sender, EventArgs e)
        {

            timeLeft--;

            lblTime.Text = "⏱ 00:" + timeLeft.ToString("00");

            if (timeLeft <= 0)
            {
                timerOtp.Stop();

                lblTime.Text = "Expired";
                btnVerify.Enabled=false;
                lblResendOtp.Enabled = true;


            }
        }

        private void lblResendOtp_Click(object sender, EventArgs e)
        {
            generatedOtp = SignIn.GenerateOTP();
            lblWrongOtp.Visible = false;
            btnVerify.Enabled = true;
            SignIn.SendOTPEmail(UserEmail, generatedOtp);

            timeLeft = 60;
            lblTime.Text = "01:00";

            lblResendOtp.Enabled = false;
            timerOtp.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
    }
