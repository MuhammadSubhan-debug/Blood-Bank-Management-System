using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class SignIn : Form
    {
        List<User> Users;
        public SignIn(List<User> users)
        {
            InitializeComponent();
            Users = users;
        }
        string generatedOTP = "";
        private void SignIn_Load(object sender, EventArgs e)
        {
            lblTotalUser.Text += Users.Count;
            btnSignUp.Enabled=false;
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtPassword.Refresh();
            txtConfirmPassword.Refresh();
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            lblPassword.Visible = true;
            lblConfirmPassword.Visible = true;

            isPasswordPlaceholder = true;
            isConfirmPasswordPlaceHolder = true;
        //    PasswordHidden();
          //  ConfirmPasswordHidden();

        }
        bool isPasswordPlaceholder = true;
        public static string GenerateOTP()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }
        public static bool SendOTPEmail(string toEmail, string otp)
        {
           
            //try
            //{
            //    using (var client = new System.Net.WebClient())
            //    using (client.OpenRead("https://www.google.com")) { }
            //}
            //catch
            //{
            //    MessageBox.Show("No Internet Connection");
            //    return false;
            //}

            try
            {
                string fromEmail = "your_email_address";
                string appPassword = "password";//go to gmail setting  -> two step verficatiaon -> make an app password use this to work correctly 

                var mail = new System.Net.Mail.MailMessage();
                mail.From = new System.Net.Mail.MailAddress(fromEmail, "Blood Bank System");
                mail.To.Add(toEmail);
                mail.Subject = "OTP Verification - Blood Bank";

              
                mail.IsBodyHtml = true;

               
                mail.Body = $@"
<html>
<body style='font-family:Arial; background-color:#f4f4f4; padding:20px;'>

    <div style='max-width:500px; margin:auto; background:white; border-radius:10px; overflow:hidden; border:1px solid #ddd;'>

        <div style='background-color:#940327; color:white; padding:15px; text-align:center;'>
            <h2>Blood Bank System</h2>
        </div>

        <div style='padding:20px; text-align:center;'>

            <h3>Email Verification</h3>

            <p style='font-size:16px; color:#333;'>
                Use the following OTP to verify your account:
            </p>

            <div style='font-size:28px; font-weight:bold; letter-spacing:5px; 
                        background:#f8f8f8; padding:12px; border-radius:8px; 
                        display:inline-block; color:#940327;'>
                {otp}
            </div>

            <p style='margin-top:20px; color:#777;'>
                This OTP is valid for <b>1 minute</b>. Do not share it.
            </p>

        </div>

        <div style='background:#eee; text-align:center; padding:10px; font-size:12px; color:#666;'>
            © Blood Bank Management System
        </div>

    </div>

</body>
</html>";

                var smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential(fromEmail, appPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email sending failed: ");
                Logger.LogException(ex);    
               
                return false;

            }
        }
        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.BackColor = Color.Red;
                lb.ForeColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.BackColor = Color.Transparent;
            lb.ForeColor = Color.FromArgb(148,3,39);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordStrength(txtPassword.Text);
        }

        private void UpdatePasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                lblStrength.Text = "";
                //lblStrength.ForeColor = Color.Gray;
                return;
            }

            // Strong: at least 8 chars, upper, lower, digit, special char
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"))
            {
                lblStrength.Text = "Strong";
                lblStrength.ForeColor = Color.Green;
            }
            // Medium: at least 6 chars, mix of letters and numbers
            else if (Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d).{6,}$"))
            {
                lblStrength.Text = "Medium";
                lblStrength.ForeColor = Color.Orange;
            }
            // Weak: anything else
            else
            {
                lblStrength.Text = "Weak";
                lblStrength.ForeColor = Color.Red;
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            if (!IsValidName(txtFullName.Text) && txtFullName.Text.Length > 3) {
                lblInvaildName.Visible = true;
            
            }
            else
            {
                lblInvaildName.Visible = false;

            }
        }

        private void txtFullName_MouseEnter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Enter Your Full Name") {

                txtFullName.Text = "";
            }
        }

        private void txtFullName_MouseLeave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {

                txtFullName.Text = "Enter Your Full Name";
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text&&txtConfirmPassword.Text.Length>=8) { 
            lblPasswordNotMatch.Visible = false;
            
            }
            else { lblPasswordNotMatch.Visible = true;}
            ValidateForm();
        }
        private void ValidateForm()
        {
            bool isValid =
                IsValidName(txtFullName.Text) &&
                IsValidEmail(txtEmail.Text) &&
                IsValidCNIC(txtCnic.Text) &&
                IsValidPassword(txtPassword.Text) &&
                txtPassword.Text == txtConfirmPassword.Text &&
                (rdoFemale.Checked || rdoMale.Checked) &&
                cmbCity.SelectedIndex != -1 &&
                cmbBloodGroup.SelectedIndex != -1 &&
                txtEmail.Text != "Enter Your Email" &&
                txtFullName.Text != "Enter Your Full Name" &&
                txtPassword.Text != "Password" &&
                txtConfirmPassword.Text != "Confirm Password";

            btnSignUp.Enabled = isValid;
        }
        private bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) &&
                   Regex.IsMatch(name, @"^[a-zA-Z\s]{3,50}$");
        }
        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) &&
                   Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        private bool IsValidCNIC(string cnic)
        {
            return !string.IsNullOrWhiteSpace(cnic) &&
                   Regex.IsMatch(cnic, @"^\d{5}-\d{7}-\d{1}$");
        }
        private bool IsValidPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password) &&
                   Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            if (!IsValidEmail(txtEmail.Text) && txtEmail.Text.Length > 5)
            {
                lblWrongEmail.Visible = true;
                lblUserExist.Visible = false;
            }
            else {
                lblWrongEmail.Visible = false;
                foreach (User u in Users) {
                    if (u.Email == txtEmail.Text) {

                        lblUserExist.Visible = true;
                    }
                        
                            
                            } }
            }

        

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            if (txtCnic.Text.Length == 5 || txtCnic.Text.Length == 13) {
                txtCnic.Text += "-";
                txtCnic.SelectionStart=txtCnic.Text.Length;
            }
            if (!IsValidCNIC(txtCnic.Text))
            {
                lblWrongCnic.Visible = true;

            }
            else {
                lblWrongCnic.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PasswordHidden() {

            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                pictureShowPassword.Image = Properties.Resources.close_png; // show icon
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                pictureShowPassword.Image = Properties.Resources.eye_open_4; // hide icon
            }
        }
        private void pictureShowPassword_Click(object sender, EventArgs e)
        {
            PasswordHidden();
        }
        private void ConfirmPasswordHidden() {

            if (txtConfirmPassword.UseSystemPasswordChar)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                pictureBoxShowPassword.Image = Properties.Resources.close_png;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                pictureBoxShowPassword.Image = Properties.Resources.eye_open_4;
            }
        }
        private void pictureBoxShowPassword_Click(object sender, EventArgs e)
        {
            ConfirmPasswordHidden();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User obj = new User()
            {
                Name = txtFullName.Text,
                Age = (int)txtAge.Value,
                UserId = 0,
                Email = txtEmail.Text,
                BloodGroup = cmbBloodGroup.Text,
                City = cmbCity.Text,
                Path = null,
                Gender = rdoMale.Checked ? "Male" : "Female",
                Cnic = txtCnic.Text,
                Role = "User",
                Password = txtPassword.Text,
                LastDonation = null,
                isVerfied = false

            };
            AddUserInDB(obj);
            generatedOTP = GenerateOTP();
            SendOTPEmail(txtEmail.Text,generatedOTP);
            Otp obj2 = new Otp(obj, generatedOTP);
            this.Hide();
            obj2.Show();
        }
        private void AddUserInDB(User obj) {
            string query = @"INSERT INTO Users 
        (FullName, city, age, Password, gender, email, cnic, bloodGroup, IsVerified, Role)
        VALUES 
        (@Name, @City, @Age, @Password, @Gender, @Email, @Cnic, @BloodGroup, @IsVerified, @Role)";

            using (SqlCommand cmd = new SqlCommand(query, DBManager.conn))
            {
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@City", obj.City);
                cmd.Parameters.AddWithValue("@Age", obj.Age);
                cmd.Parameters.AddWithValue("@Password", obj.Password);
                cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@Cnic", obj.Cnic);
                cmd.Parameters.AddWithValue("@BloodGroup", obj.BloodGroup);
                cmd.Parameters.AddWithValue("@IsVerified", obj.isVerfied ? "true" : "false");
                cmd.Parameters.AddWithValue("@Role", obj.Role);

                try
                {
                    DBManager.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully");
                }
                catch (Exception ex)
                {

                    //isko logs ma add karna hai
                    MessageBox.Show("DB Error: " + ex.Message);
                }
            }


        }

        private void txtEmail_MouseEnter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Enter Your Email") {
                txtEmail.Text = "";
            
            }
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Enter Your Email";

            }
        }

        private void txtCnic_MouseEnter(object sender, EventArgs e)
        {
            if (txtCnic.Text == "Enter Your Cnic") {
                txtCnic.Text = "";
            }
        }

        private void txtCnic_MouseLeave(object sender, EventArgs e)
        {
            if (txtCnic.Text == "")
            {
                txtCnic.Text = "Enter Your Cnic";
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (isPasswordPlaceholder)
            
            {
                lblPassword.Visible= false;
                isPasswordPlaceholder= false;
            }


        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPassword.Visible = true;
                isPasswordPlaceholder = true;
            }
        }

        private void txtConfirmPassword_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                lblConfirmPassword.Visible = true;
                isConfirmPasswordPlaceHolder = true;
            }
        }
        bool isConfirmPasswordPlaceHolder = true;
        private void txtConfirmPassword_MouseEnter(object sender, EventArgs e)
        {

            if (isConfirmPasswordPlaceHolder)

            {
                lblConfirmPassword.Visible = false;
                isConfirmPasswordPlaceHolder = false;
            }

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            LoginPage ob = new LoginPage();
            this.Hide();
            ob.Show();
        }

           }
}
