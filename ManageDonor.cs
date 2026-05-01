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
    public partial class ManageDonor : Form
    {
        List<User> users;
        List<User>tempList=new List<User>();
        User UsertoUpdate = null;
        List<int> deleteIDs = new List<int>();
        public ManageDonor(List<User>u)
        {
            InitializeComponent();
            users = u;
        }


        private void lblGoBack_Click(object sender, EventArgs e)
        {
            if (tempList.Count == 0)
            {
                Dashboard obj = new Dashboard(users);
                this.Hide();
                obj.Show();
            }
            else {

                MessageBox.Show("Some Data is pending to store.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }
        private void ValidateForm()
        {
            bool isValid =
                IsValidName(txtName.Text) &&
                IsValidEmail(txtEmail.Text) &&
                IsValidCNIC(txtCnic.Text) &&
                IsValidPassword(txtPassword.Text) &&
                txtAge.Value > 0 &&

                (rdoMale.Checked || rdoFemale.Checked);
            btnAdd.Enabled = isValid;
            btnUpdate.Enabled = isValid;
            lblInvalid.Visible = !isValid;
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
        private void ManageDonor_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = users;
         //   lblCountUsers.Text += users.Count;

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            if (txtCnic.Text.Length == 5 || txtCnic.Text.Length == 13) {
                txtCnic.Text += "-";
                txtCnic.SelectionStart= txtCnic.Text.Length;
            
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            List<User> filtered = new List<User>();
            foreach (User u in users) {
                if (u.Name.ToLower().Contains(txtSearchUser.Text.ToLower())) { 
                filtered.Add(u);
                } 

            }
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = filtered;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool unique = true;
            foreach (User u in users) {
                if (u.Email.ToLower() == txtEmail.Text.ToLower())
                {
                    unique = false;
                    break;
                }
            }
            if (unique)
            {
                User temp = new User()
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
               
                try
                {
                    temp = AddUserInDB(temp);
                    BloodUnit unit = new BloodUnit()
                    {
                        Status = "testing",
                        collectionDate = dateCollection.Value,
                        DonorId = temp.UserId,
                        BloodUnitId = 0,
                        BloodGroup = temp.BloodGroup

                    };
                   
                    MessageBox.Show("User id : " + temp.UserId);

                    unit = InsertBloodUnit(unit);
                }

                catch (Exception exp)
                {
                    MessageBox.Show("Failed to Add."+exp.Message);
                    //exp ko logs ma add karna rehta hai
                }

                tempList.Add(temp);

                RefreshGrid();
            }
            else {
                MessageBox.Show("User Already Exist With these credentials");
                return;
            
            }
            ClearControls();
        }
        public BloodUnit InsertBloodUnit(BloodUnit unit)
        {
            string query = @"INSERT INTO BloodUnit 
                    (DonorId, BloodGroup, CollectionDate,Status)output inserted.BloodUnitId
                    VALUES 
                    (@DonorId, @BloodGroup, @CollectionDate, @Status)";

           
                SqlCommand cmd = new SqlCommand(query, DBManager.conn);

                cmd.Parameters.AddWithValue("@DonorId", unit.DonorId);
                cmd.Parameters.AddWithValue("@BloodGroup", unit.BloodGroup);
                cmd.Parameters.AddWithValue("@CollectionDate", unit.collectionDate);
              
                cmd.Parameters.AddWithValue("@Status", unit.Status);

            DBManager.Open();
            unit.BloodUnitId = (int)cmd.ExecuteScalar();
            DBManager.Close(); 
            return unit;
               
        }
        private void RefreshGrid() {
            var allUsers = users.Concat(tempList).ToList();
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = allUsers;


        
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
                   obj.UserId=(int)cmd.ExecuteScalar();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls() {

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
        
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colUpdate")
            {
                UsertoUpdate = dgvUsers.Rows[e.RowIndex].DataBoundItem as User;
                FillField(UsertoUpdate);
                ValidateForm();
            }
            else if (dgvUsers.Columns[e.ColumnIndex].Name== "colSelect") {
                User u = dgvUsers.Rows[e.RowIndex].DataBoundItem as User;
                deleteIDs.Add(u.UserId);

            
            
            }
        }
        private void FillField(User user) {
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            string query = @"UPDATE Users 
                         SET Name=@Name, Age=@Age, Cnic=@Cnic, Email=@Email,
                             Password=@Password, Gender=@Gender,
                             BloodGroup=@BloodGroup, City=@City,
                             LastDonation=@LastDonation
                         WHERE userId=@Id";

            SqlCommand cmd = new SqlCommand(query, DBManager.conn);
            if (UsertoUpdate != null)
            {
                cmd.Parameters.AddWithValue("@Id", UsertoUpdate.UserId);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@Cnic", txtCnic.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Gender", rdoMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@BloodGroup", cmbBloodGroup.Text);
                cmd.Parameters.AddWithValue("@City", cmbCity.Text);
                cmd.Parameters.AddWithValue("@LastDonation", dateCollection.Value);
                DBManager.Open();
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("User Details Updated");
                    ClearControls();

                }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleteIDs.Count == 0)
            {
                MessageBox.Show("No Record Selected to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
}
            else {
                MessageBox.Show("Total records are " + deleteIDs.Count);
                DeleteFromDb();
            
            }
        }
        private void DeleteFromDb() {
            foreach (int i in deleteIDs)
            {
              
                string q = @"update users set isactive ='InActive' where userid = @id";
                SqlCommand cmd = new SqlCommand(q, DBManager.conn);
                DBManager.Open();
                cmd.Parameters.AddWithValue("@id", i);
                cmd.ExecuteNonQuery();
                DBManager.Close();
                User toRemove= null;
                foreach (User u in users) {
                    if (u.UserId == i)
                    {
                        toRemove= u;
                        break;

                    }
                
                }
                users.Remove(toRemove);
                RefreshGrid();
             //   MessageBox.Show("Records are deleting"+q);
            }
            deleteIDs.Clear();
        }

        private void btnAddDonation_Click(object sender, EventArgs e)
        {
            
            BloodUnit unit = new BloodUnit()
            {
                Status = "testing",
                collectionDate = dateCollection.Value,
                DonorId = UsertoUpdate.UserId,
                BloodUnitId = 0,
                BloodGroup = UsertoUpdate.BloodGroup

            };
            unit = InsertBloodUnit(unit);
            ClearControls();    
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
