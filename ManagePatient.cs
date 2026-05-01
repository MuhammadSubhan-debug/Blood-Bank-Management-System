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
    public partial class ManagePatient : Form
    {
        List<User> users;

        public ManagePatient(List<User>u)
        {
            
            InitializeComponent();
            users = u;
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }
        private void ValidateForm()
        {
            bool isNameValid = IsValidName(txtName.Text);
            bool isEmailValid = IsValidEmail(txtEmail.Text);
            bool isCnicValid = IsValidCNIC(txtCnic.Text);
            bool isPasswordValid = IsValidPassword(txtPassword.Text);
            bool isAgeValid = txtAge.Value > 0;
            bool isTypeSelected = rdoEmergency.Checked || rdoNormal.Checked;
            bool isGenderSelected = rdoMale.Checked || rdoFemale.Checked;
            

            bool isValid = isNameValid &&
                           isEmailValid &&
                           isCnicValid &&
                           isPasswordValid &&
                           isAgeValid &&
                           isTypeSelected &&
                           isGenderSelected;

            btnAdd.Enabled = isValid;
            btnCreateRequestOnly.Enabled = isValid;
            lblInvalid.Visible = !isValid;
            if (!isNameValid)
                lblInvalid.Text = "Invalid Name";
            else if (!isEmailValid)
                lblInvalid.Text = "Invalid Email";
            else if (!isCnicValid)
                lblInvalid.Text = "Invalid CNIC";
            else if (!isPasswordValid)
                lblInvalid.Text = "Weak Password";
            else if (!isAgeValid)
                lblInvalid.Text = "Enter valid Age";
            else if (!isTypeSelected)
                lblInvalid.Text = "Select Request Type";
            else if (!isGenderSelected)
                lblInvalid.Text = "Select Gender";
            else
                lblInvalid.Text = "";
        }

        private bool IsValidName(string name)
        {
            return !string.IsNullOrEmpty(name) &&
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
            return !string.IsNullOrEmpty(password) &&
                   Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            if (txtCnic.Text.Length == 5 || txtCnic.Text.Length == 13)
            {
                txtCnic.Text += "-";
                txtCnic.SelectionStart = txtCnic.Text.Length;

            }

        }
        User toUpdate = null;
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text)) { 
            foreach (User u in users) {
                if (u.Email.ToLower() == txtEmail.Text.ToLower()) {

                    lblInvalid.Text = "User with same email exists";
                    btnAdd.Enabled = false;
                        toUpdate = u;
                    DialogResult dr=MessageBox.Show("Do You want to create a request for existing user", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            //fill the field and only add request
                            FillField(toUpdate);
                            
                        }
                        else {
                            txtEmail.Text = "";
                            return;

                        }

                  
                }
            
            }
            }
            ValidateForm();
        }
        private void FillField(User user)
        {
            txtAge.Value = user.Age;
            txtCnic.Text = user.Cnic;
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            cmbBloodGroup.Text = user.BloodGroup;
            cmbCity.Text = user.City;
            if (user.Gender.ToLower() == "male")
            {
                rdoMale.Checked = true;
            }
            else { rdoFemale.Checked = true; }

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
          
    }
        private void ClearControls()
        {

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                }

            }
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
        }

        private void ManagePatient_Load(object sender, EventArgs e)
        {
             btnAdd.Enabled = false;
            btnCreateRequestOnly.Enabled= false;    
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private User AddUserInDB(User obj)
        {
            string query = @"INSERT INTO Users 
        (FullName, city, age, Password, gender, email, cnic, bloodGroup, IsVerified, Role) output inserted.userid
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
                    obj.UserId = (int)cmd.ExecuteScalar();
                    MessageBox.Show("User added successfully");
                }
                catch (Exception ex)
                {

                    //isko logs ma add karna hai
                    MessageBox.Show("DB Error: " + ex.Message);
                }
                return obj;
            }


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User tempUser = new User()
            {
                Name = txtName.Text,
                Age = (int)txtAge.Value,
                Email = txtEmail.Text,
                City = cmbCity.Text,
                BloodGroup = cmbBloodGroup.Text,
                LastDonation = dateCollection.Value,
                isVerfied = false,
                Password = txtPassword.Text,
                Path = "No Image",
                Role = "user",
                UserId = 0,
                Gender = rdoMale.Checked ? "Male" : "Female",
                Cnic = txtCnic.Text

            };
            tempUser = AddUserInDB(tempUser);


            BloodRequest temp = new BloodRequest(toUpdate) { 
            Condition=rdoEmergency.Checked?"Emergency":"Normal",
            Status="Pending",
            BloodGroup=cmbBloodGroup.Text,
            RequestDate=DateTime.Now,
            UnitsRequested=(int)txtUnitRequested.Value,
            UnitsAssigned=0,
            NeedDate=dateCollection.Value,


            
            } ;
            AddBloodRequest(temp);

        }
        private void AddBloodRequest(BloodRequest obj)
        {
            string q = @"insert into BloodRequest(FromUserId,RequestDate,NeedDate,UnitsRequested,UnitsAssigned,Condition,Status,BloodGroup)
values (@userId,@RequestDate,@needDate,@UnitRequested,@unitAssigned,@condition,@status,@BloodGroup)";
            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            DBManager.Open();
            cmd.Parameters.AddWithValue("@userId", obj.FromUser.UserId);
            cmd.Parameters.AddWithValue("@requestDate", obj.RequestDate);
            cmd.Parameters.AddWithValue("@BloodGroup",obj.BloodGroup);
            cmd.Parameters.AddWithValue("@needDate", obj.NeedDate);
            cmd.Parameters.AddWithValue("@UnitRequested", obj.UnitsRequested);
            cmd.Parameters.AddWithValue("@unitAssigned", obj.UnitsAssigned);
            cmd.Parameters.AddWithValue("@condition", obj.Condition);
            cmd.Parameters.AddWithValue("@status", obj.Status);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Request Added");

            }

        }

        private void btnCreateRequestOnly_Click(object sender, EventArgs e)
        {
            BloodRequest temp = new BloodRequest(toUpdate)
            {
                Condition = rdoEmergency.Checked ? "Emergency" : "Normal",
                Status = "Pending",
                RequestDate = DateTime.Now,
                NeedDate = dateCollection.Value,
                UnitsAssigned=0,
                UnitsRequested=(int)txtUnitRequested.Value




            };
            AddBloodRequest(temp);
            ClearControls();

        }
    }
}
