using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class BookApointment : Form
    {
        User FromUser = null;
        List<DonationAppointment> appointments;
        public BookApointment(User u,List<DonationAppointment>obj )
        {
            InitializeComponent();
            appointments = obj;
            FromUser = u;

         //   appointments = new List<DonationAppointment>();
        }
      
        public BookApointment()
        {
            InitializeComponent();
           

        }


        private void lblGoBack_Click(object sender, EventArgs e)
        {
            UserDashboard obj=new UserDashboard(FromUser);
            this.Hide();
            obj.Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DonationAppointment appointment = new DonationAppointment(FromUser);
            bool isEligible = true;

            if (FromUser.LastDonation != null)
            {
                double daysPassed = (DateTime.Now - FromUser.LastDonation.Value).TotalDays;
                int remainingDays = 90 - (int)daysPassed;

                if (remainingDays > 0)
                {
                    MessageBox.Show("You can donate again after " + remainingDays + " day(s).");
                    isEligible = false;
                }
            }

            if (!isEligible)
                return;

            bool alreadyAppointment = appointments.Any(ap =>
                ap.FromUser.UserId == FromUser.UserId &&
                ap.AppointmentDate.Date == dateAppointment.Value.Date
            );

            if (alreadyAppointment)
            {
                MessageBox.Show("Cannot book appointment for same day.\nYou already have one.");
                return;
            }

            appointment.Status = "Pending";
            appointment.AppointmentDate = dateAppointment.Value;
            appointment.AdditionalRemarks = string.IsNullOrWhiteSpace(txtAreaRemarks.Text)
                                            ? "Nothing"
                                            : txtAreaRemarks.Text;

            MakeAppointmentInDB(appointment);

            MessageBox.Show("Your appointment is booked for " + appointment.AppointmentDate);

            this.Hide();
            UserDashboard obj = new UserDashboard(FromUser);
            obj.Show();

        }
        private void MakeAppointmentInDB(DonationAppointment obj) {
            string q = @"insert into DonationAppointment(UserId,AppointmentDate,AdditionalRemarks,Status)values (@UserID,@AppointmentDate,@AdditionalRemarks,@Status)";
            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            cmd.Parameters.AddWithValue("@UserId",obj.FromUser.UserId);
            cmd.Parameters.AddWithValue("@AppointmentDate", obj.AppointmentDate);
            cmd.Parameters.AddWithValue("@AdditionalRemarks", obj.AdditionalRemarks);
            cmd.Parameters.AddWithValue("@Status", obj.Status);
            DBManager.Open();
            cmd.ExecuteNonQuery();
            DBManager.Close();





        }
        int countpendingAppointments = 0;
        private void BookApointment_Load(object sender, EventArgs e)
        {
            //LoadAppointments(fr);
            PendingAppointments();
            lblTotalAppointment.Text += appointments.Count;
        }
        private void PendingAppointments() {
            foreach (DonationAppointment app in appointments)
            {
                if (app.Status == "Pending") {
                    countpendingAppointments++;
                }

            }
            lblPending.Text += countpendingAppointments;
        }
     
    }
}
