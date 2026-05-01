using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace BBMS
{
    public partial class UserDashboard : Form
    {
        User user;
       
        List<DonationAppointment> appointments = new List<DonationAppointment>();
        List<BloodRequest>Requests= new List<BloodRequest>();
       
        public UserDashboard(User u)
        {
            
            InitializeComponent();
            user = u;
            if (user.Path != null ) {
                try { 
                using (var stream = new FileStream(user.Path, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxDp.Image = new Bitmap(stream);
                }
                pictureBoxDp.SizeMode = PictureBoxSizeMode.Zoom;
                }
                
                catch(Exception ex){
                    MessageBox.Show("Image not found");
                    Logger.LogException(ex);
                }
            }

        }
        List<DonationAppointment> obj = null;
        public UserDashboard(User u,List<DonationAppointment>obj)
        {
            //  dgvAppointment.DataSource = null;
            this.obj = obj;

            InitializeComponent();
            user = u;
            if (u.Path != null)
            {

                using (var stream = new FileStream(u.Path, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxDp.Image = new Bitmap(stream);
                }
                pictureBoxDp.SizeMode = PictureBoxSizeMode.Zoom;

            }

        }
        public UserDashboard()
        {
            InitializeComponent();
           // pictureBoxDp.Image = Image.FromFile(u.Path);
        }
        bool isExpanded=false;
        int maxHeight = 118;

        private void pictureBoxDp_Click(object sender, EventArgs e)

        {

            // panelDropDown.Visible = !panelDropDown.Visible;
            panelDropDown.Visible = true;
          
            if (panelDropDown.Visible)
            {
                panelDropDown.Height = 0;
            }
            timerDropDown.Start();

        }

        private void timerDropDown_Tick(object sender, EventArgs e)
        {
            if (!isExpanded)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Height > maxHeight)
                {
                    timerDropDown.Stop();
                    isExpanded = true;
                }

            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Height <= 0)
                {
                    timerDropDown.Stop();
                    isExpanded = false;
                }

            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginPage obj= new LoginPage();
            this.Hide();
            obj.Show();
        }

        private void lblBookAppointment_Click(object sender, EventArgs e)
        {
            BookApointment obj=new BookApointment(user,appointments);
            this.Hide();
            obj.Show();
        }

        private void lblCreateRequest_Click(object sender, EventArgs e)
        {
            CreateRequest obj = new CreateRequest(user,Requests);
            this.Hide();
            obj.Show();
        }

     
        private void lblBookAppointment_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = Color.White;
            lbl.ForeColor = Color.Red;
        }

        private void lblBookAppointment_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Color.White;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            lblUserID.Text += user.UserId;
          
            LoadAppointments(user);
            LoadRequest(user);
            LoadGrid();
            dgvRequest.DataSource = Requests;
           
        }
        private void LoadRequest(User user) {
            string q = @"select * from BloodRequest where FromUserId=@FromUserId";

            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            cmd.Parameters.AddWithValue("@FromUserId", user.UserId);
            DBManager.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) {
                BloodRequest obj = new BloodRequest(user)
                {
                    UnitsAssigned = (int)sdr["UnitsAssigned"],
                    UnitsRequested = (int)sdr["UnitsRequested"],
                    RequestId = (int)sdr["RequestId"],
                    Condition = sdr["Condition"].ToString(),
                    Status = sdr["Status"].ToString(),
                    RequestDate = (DateTime)sdr["RequestDate"],
                    NeedDate =(DateTime) sdr["NeedDate"]

                };
            Requests.Add(obj);
            }
            DBManager.Close();

        }
        private void LoadGrid() {

            dgvAppointment.AutoGenerateColumns = false;
           
            dgvAppointment.Columns.Clear();

            dgvAppointment.Columns.Add("AppointmentId", "Number");
            dgvAppointment.Columns.Add("AppointmentDate", "Date");
            dgvAppointment.Columns.Add("UserName", "Name");
            dgvAppointment.Columns.Add("Status", "Status");
            dgvAppointment.Columns.Add("City", "City");
            dgvAppointment.Columns.Add("BloodGroup", "Blood Group");
            dgvAppointment.Rows.Clear();
           
                foreach (DonationAppointment ap in appointments)
                {
                    dgvAppointment.Rows.Add(
                        ap.AppointmentId,
                        ap.AppointmentDate,
                        ap.FromUser.Name,
                        ap.Status,
                        ap.FromUser.City,
                        ap.FromUser.BloodGroup
                    );
                }
            
        }
        private void LoadAppointments(User u)
        {
            string q = @"select * from DonationAppointment where userID=@userid";

            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            cmd.Parameters.AddWithValue("@userid", u.UserId);
            DBManager.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DonationAppointment obj = new DonationAppointment(u)
                {
                    Status = sdr["Status"].ToString(),
                    AppointmentId = (int)sdr["AppointmentId"],
                    AppointmentDate = (DateTime)sdr["AppointmentDate"],
                    AdditionalRemarks = sdr["AdditionalRemarks"].ToString()

                };
              
                appointments.Add(obj);



            }
            DBManager.Close();

        }
       
        private void btnChangeDp_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.Combine(Application.StartupPath, "ProfileImages");

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

             
                if (pictureBoxDp.Image != null)
                {
                    pictureBoxDp.Image.Dispose();
                    pictureBoxDp.Image = null;
                }

             
                foreach (var file in Directory.GetFiles(folderPath, user.UserId + ".*"))
                {
                    File.Delete(file);
                }

                string ext = Path.GetExtension(ofd.FileName);
                string destinationPath = Path.Combine(folderPath, user.UserId + ext);

                File.Copy(ofd.FileName, destinationPath, true);

                
                using (var stream = new FileStream(destinationPath, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxDp.Image = new Bitmap(stream);
                }

                user.Path = destinationPath;
                updateDp(user);
            }
        }


        public void updateDp(User u) {
            string q = @"update users set path=@path where userId=@userID";
            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            cmd.Parameters.AddWithValue("@path",u.Path);
            cmd.Parameters.AddWithValue("@userID", u.UserId);
            DBManager.Open();
            cmd.ExecuteNonQuery();
            DBManager.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage obj = new LoginPage();
            this.Hide();
            obj.Show();
        }
    }
}
