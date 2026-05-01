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
using System.Windows.Forms.DataVisualization.Charting;

namespace BBMS
{
    public partial class Dashboard : Form
    {
        List<User>users;
        List<DonationAppointment > ListOfAppointment =new List<DonationAppointment>();

        public Dashboard(List<User>u)
        {
            InitializeComponent();
            users=u;
        }
        public Dashboard() {
            InitializeComponent();

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //  MessageBox.Show("Welcome..", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (users != null)
                lblUserCount.Text += users.Count;
            else
                lblUserCount.Text += -1;
            try
            {
                LoadAppointments();
               
            }
            catch (Exception ex) {
                Logger.LogException(ex);
            }
            //ConvertToWhite(panel1.BackgroundImage);

        }
      
        private void LoadAppointments() {

            string q = @"select * from DonationAppointment";
            SqlCommand cmd =new SqlCommand(q,DBManager.conn);
            DBManager.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) {
                DonationAppointment temp = new DonationAppointment()
                {
                    AdditionalRemarks = sdr["AdditionalRemarks"].ToString(),
                    AppointmentDate = (DateTime)sdr["AppointmentDate"],
                    FromUser = null,
                    Status=sdr["Status"].ToString(),
                    AppointmentId =(int) sdr["AppointmentId"]

                };
                ListOfAppointment.Add(temp);
            }
            sdr.Close();
        }


        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool isExpanded=false;
        int maxHeight = 114;

        private void lblDonationRecords_MouseEnter(object sender, EventArgs e)
        {
            Label lbl= sender as Label;
            lbl.BackColor=Color.White;
            lbl.ForeColor=Color.Red;
            
        }

        private void lblDonationRecords_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Color.White;
        }

        private void pictureBoxDp_Click(object sender, EventArgs e)
        {
            panelDropDown.Visible = true;
            if (panelDropDown.Visible) {
                panelDropDown.Height = 0;    
            }
        //    panelDropDown.Visible=!panelDropDown.Visible;
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
            else {
                panelDropDown.Height -= 10;
                if (panelDropDown.Height <= 0) {
                    timerDropDown.Stop();
                    isExpanded=false;
                }
            
            }
        }

        private void btnChangeDp_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage obj = new LoginPage();
            this.Hide();
            obj.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

       
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadForm(Form childForm)
        {
            panelMain.Controls.Clear(); // your 3rd panel

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void lblDonationRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donation obj = new Donation(users);
            obj.Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage obj = new LoginPage();
            obj.Show();
        }

        

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard(users);
            obj.Show();
            this.Hide();
        }

        private void lblShowRequest_Click(object sender, EventArgs e)
        {
            Request obj = new Request(users);
            this.Hide();
            obj.Show();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {

        }

        private void lblInventory_Click(object sender, EventArgs e)
        {
            Inventory ob= new Inventory(users);

            this.Hide();
            ob.Show();

        }

        private void lblMangePatient_Click(object sender, EventArgs e)
        {
            ManagePatient obj=new ManagePatient(users);
            this.Hide();
            obj.Show();
        }

        private void lblEmergencyRequest_Click(object sender, EventArgs e)
        {
            EmergencyRequest obj = new EmergencyRequest();
            obj.Show();
        }

        private void lblManageRecords_Click(object sender, EventArgs e)
        {
            ManageDonor obj = new ManageDonor(users);
            this.Hide();
            obj.Show();
        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAppointment_Click(object sender, EventArgs e)
        {
            Appointment_show temp = new Appointment_show(ListOfAppointment);
         //   this.Hide();
            temp.Show();
        }
    }
}
