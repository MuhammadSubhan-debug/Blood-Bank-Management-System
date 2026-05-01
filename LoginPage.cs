using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BBMS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            Users = new List<User>();
            admin = new List<User>();
        }
        List<User> Users = null;
        List<User> admin = null;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red; label1.ForeColor=Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent; label1.ForeColor=Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_MouseEnter(object sender, EventArgs e)

        {
            if (txtEmail.Text.Equals("Enter your Email"))
            {
                txtEmail.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblWrongPassword.Visible=false;
            lblInvalidEmai.Visible = false;
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Enter your Password"))
            {
                txtPassword.Text = "";
            }
           
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") {
                txtPassword.Text = "Enter your Password";
            
            }
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            if(txtEmail.Text=="")
            txtEmail.Text = "Enter your Email";
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txtPassword.UseSystemPasswordChar = true;
            picturePasswordShow.Image = Properties.Resources.close_png;
            this.ActiveControl = panel1; // or label
            MakeIconWhite(pictureBoxUser);
            LoadUsers();
        }
        public void LoadUsers()
        {
            String q = @"Select * from users where isactive ='Active'";
            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            DBManager.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                User u = new User()
                {
                    Name = sdr["FullName"].ToString(),
                    Age = (int)sdr["age"],
                    City = sdr["city"].ToString(),
                    Password = sdr["Password"].ToString(),
                    Gender = sdr["gender"].ToString(),
                    UserId = (int)sdr["userId"],
                    BloodGroup = sdr["bloodGroup"].ToString(),
                    isVerfied = Convert.ToBoolean(sdr["IsVerified"]),
                    Cnic = sdr["cnic"].ToString(),
                    Email = sdr["email"].ToString(),
                    Role = sdr["Role"].ToString(),
                    Path = sdr["Path"].ToString()

                };
                if (u.Role.ToLower() == "user")
                    Users.Add(u);
                else if (u.Role.ToLower() == "admin")
                    admin.Add(u);
            }
            DBManager.Close();
        }

        public void MakeIconWhite(PictureBox pBox)
    {
        if (pBox.Image == null) return;

        Bitmap bmp = new Bitmap(pBox.Image);
        Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);

        using (Graphics g = Graphics.FromImage(newBmp))
        {
            // This matrix ignores the original color and forces 
            // the RGB values to 1.0 (White) while keeping the original Alpha (Transparency)
            float[][] colorMatrixElements = {
            new float[] {0, 0, 0, 0, 0},        // Red
            new float[] {0, 0, 0, 0, 0},        // Green
            new float[] {0, 0, 0, 0, 0},        // Blue
            new float[] {0, 0, 0, 1, 0},        // Alpha (Keep transparency)
            new float[] {1, 1, 1, 0, 1}         // Offset (Add 1 to R, G, and B to make them white)
        };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height),
                0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);
        }

        pBox.Image = newBmp;
        pBox.BackColor = Color.Transparent; // Ensure the background is see-through
    }
    private void picturePasswordShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                // SHOW password
                txtPassword.UseSystemPasswordChar = false;
                picturePasswordShow.Image = Properties.Resources.eye_open_4;
            }
            else
            {
                // HIDE password
                txtPassword.UseSystemPasswordChar = true;
                picturePasswordShow.Image = Properties.Resources.close_png;
            }
        }

       

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            lblMinimize.ForeColor = Color.Red;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact to Admin\nOnly Admins can forget password", "BBSM", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void LblSignIn_Click(object sender, EventArgs e)
        {
            SignIn obj = new SignIn(Users);
            this.Hide();
            obj.Show();

        }

        private void LblSignIn_MouseEnter(object sender, EventArgs e)
        {
            LblSignIn.BackColor = Color.White;
            LblSignIn.ForeColor = Color.Red;

                  }

        private void LblSignIn_MouseLeave(object sender, EventArgs e)
        {
            LblSignIn.BackColor = Color.Transparent;
            LblSignIn.ForeColor = Color.White;
        }

        private void rdoAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAdmin.Checked)
            {
                LblSignIn.Enabled = false;
            }
            else {
                LblSignIn.Enabled = true;

            }
        }

        private void rdoAdmin_MouseEnter(object sender, EventArgs e)
        {
            rdoAdmin.BackColor= Color.White;
            rdoAdmin.ForeColor = Color.Red;
        }

        private void rdoAdmin_MouseLeave(object sender, EventArgs e)
        {
            rdoAdmin.BackColor = Color.FromArgb(140, 3, 39);
            rdoAdmin.ForeColor = Color.White;
        }

        private void rdoUser_MouseEnter(object sender, EventArgs e)
        {
            rdoUser.BackColor = Color.White;
            rdoUser.ForeColor = Color.Red;
        }

        private void rdoUser_MouseLeave(object sender, EventArgs e)
        {
            rdoUser.BackColor = Color.FromArgb(140, 3, 39);
            rdoUser.ForeColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool IsMatch = false;
            if (rdoUser.Checked)
            {
                foreach (User u in Users)
                {
                    if (u.Email == email && u.Password == password)
                    {
                        if (u.isVerfied)
                        {
                            UserDashboard obj = new UserDashboard(u);
                            this.Hide();
                            obj.Show();
                            IsMatch = true;
                            break;
                        }
                        else {
                            MessageBox.Show($"Account Found But not verified.\nWe have sent otp to your Email : {u.Email}", "Need Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            try {
                                string generatedOtp = SignIn.GenerateOTP();
                               bool isSent= SignIn.SendOTPEmail(u.Email, generatedOtp);
                                if (isSent)
                                {
                                    Otp temp = new Otp(u, generatedOtp);
                                    this.Hide(); temp.Show();
                                }
                                else {
                                    MessageBox.Show("Failed to Sent OTP.\nTry Again later");
                                    Application.Exit();
                                }

                            }
                            catch
                            {
                                MessageBox.Show("Failed to Sent OTP.\nTry Again later");
                                Application.Exit();

                            }
                        }
                    }

                }
                
                if (!IsMatch)
                {
                    lblInvalidEmai.Visible = true;
                    lblWrongPassword.Visible = true;
                }
            }
            else if (rdoAdmin.Checked) {
                IsMatch = false;
                foreach (User u in admin) {
                    if (u.Email == email && u.Password == password)
                    {
                        Dashboard obj = new Dashboard(Users);
                        this.Hide();
                        obj.Show();
                        IsMatch = true;
                    }


                }
                if (!IsMatch) {

                    MessageBox.Show("No Admin Found Against these credentials", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

            lblWrongPassword.Visible = false;
            lblInvalidEmai.Visible = false;

        }
    }
}
