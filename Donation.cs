using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class Donation : Form
    {
        List<User> user;
        public Donation(List<User> users)
        {
            InitializeComponent();
            user = users;
        }
        List<BloodUnit> bloodUnitList = new List<BloodUnit>();
        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard(user);
            obj.Show();
        }
        
        private void Donation_Load(object sender, EventArgs e)
        {
            LoadDonation();
            lblTotalDonor.Text +=bloodUnitList.Count;
            dgvDonationHistory.DataSource = bloodUnitList;
            TodayDonationCount();


        }
        private void TodayDonationCount()
        {
            int todayDonation = bloodUnitList
    .Count(u => u.collectionDate.Date == DateTime.Now.Date);

         
            lblTodayDonor.Text +=todayDonation;
        }
        private void LoadDonation()
        {
            string q = @"select * from BloodUnit ";
            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            DBManager.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                BloodUnit temp = new BloodUnit()
                {
                    BloodUnitId = (int)(sdr["BloodUnitId"]),
                    BloodGroup = sdr["BloodGroup"].ToString(),
                    Status = sdr["Status"].ToString(),
                    collectionDate = Convert.ToDateTime(sdr["collectionDate"])
                    ,
                    DonorId = (int)sdr["DonorId"]
                };
                if (temp.Status == "Testing" &&
           (DateTime.Now - temp.collectionDate).TotalHours >= 24)
                {
                    temp.Status = "Available";


                    UpdateBloodUnitStatus(temp.BloodUnitId, "Available");
                }

                bloodUnitList.Add(temp);
            }
            DBManager.Close();
        }
    

        
        private void UpdateBloodUnitStatus(int id, string status)
        {
            string q = "UPDATE BloodUnit SET Status = @status WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);
            DBManager.Open();
            cmd.ExecuteNonQuery();
            DBManager.Close();
        }

        private void txtFilterByBloodGroup_TextChanged(object sender, EventArgs e)
        {
            List<BloodUnit>filter=new List<BloodUnit>();    
            foreach (BloodUnit b in bloodUnitList) {
                if (b.BloodGroup.ToLower().Contains(txtFilterByBloodGroup.Text.ToLower())) { 
                
                filter.Add(b);
                
                }
            
            }
            dgvDonationHistory.DataSource = filter;
        }
    }
}
