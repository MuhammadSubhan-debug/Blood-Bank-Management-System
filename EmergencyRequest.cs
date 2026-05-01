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
    public partial class EmergencyRequest : Form
    {
        public EmergencyRequest()
        {
            InitializeComponent();
        }

        private void EmergencyRequest_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRequest();
            }
            catch (Exception ex) {
                Logger.LogException(ex);
            
            }
            lblEmergencyRequest.Text += bloodRequests.Count();
            dgvEmergency.DataSource = bloodRequests;
        }
        List<BloodRequest> bloodRequests = new List<BloodRequest>();
        private void LoadRequest()
        {

            string q = @"select * from BloodRequest where Condition='Emergency'";
            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            DBManager.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                BloodRequest temp = new BloodRequest()
                {
                    Condition = sdr["Condition"].ToString(),
                    Status = sdr["Status"].ToString(),
                    UnitsAssigned = (int)sdr["UnitsAssigned"],
                    UnitsRequested = (int)sdr["UnitsRequested"],
                    RequestDate = (DateTime)sdr["RequestDate"],
                    FromUser = null,
                    RequestId = (int)sdr["RequestId"],
                    NeedDate = (DateTime)sdr["NeedDate"]
                    ,
                    BloodGroup = sdr["BloodGroup"].ToString()

                };
                bloodRequests.Add(temp);

            }
            sdr.Close();
            DBManager.Close();
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

