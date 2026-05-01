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
    public partial class CreateRequest : Form
    {
        List<BloodRequest> Requests = null;
        public CreateRequest(User u,List<BloodRequest>obj)
        {
            InitializeComponent();
            user = u;
            Requests = obj;
        }
        User user;
        private void lblGoBack_Click(object sender, EventArgs e)
        {
            UserDashboard obj = new UserDashboard(user);
            this.Hide();
            obj.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BloodRequest obj = new BloodRequest(user)
            {
                NeedDate=dateNeedDate.Value,
                RequestDate=DateTime.Now,
                UnitsRequested=(int)unitRequest.Value,
                UnitsAssigned=0,
                Condition =rdoEmergency.Checked?"Emergency":"Normal",
                Status="Pending"


            };
            bool isEliglbe = true;
            foreach (BloodRequest b in Requests) {
                if (b.NeedDate.Date == obj.NeedDate.Date && b.UnitsRequested==obj.UnitsRequested)
                {
                    isEliglbe = false;
                    break;

                }
            }
            if (isEliglbe)
            {
                AddBloodRequest(obj);
            }
            else {
                MessageBox.Show("Cannot create a Request.\nRequest with same Requested units and Same day are not allowed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.Hide();
            UserDashboard obj2 = new UserDashboard(user);
            obj2.Show();

        }
        private void AddBloodRequest(BloodRequest obj) {
            string q = @"insert into BloodRequest(FromUserId,RequestDate,NeedDate,UnitsRequested,UnitsAssigned,Condition,Status,BloodGroup)
values (@userId,@RequestDate,@needDate,@UnitRequested,@unitAssigned,@condition,@status,@BloodGroup)";
            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            DBManager.Open();
            cmd.Parameters.AddWithValue("@userId", obj.FromUser.UserId);
            cmd.Parameters.AddWithValue("@BloodGroup", obj.BloodGroup);
            cmd.Parameters.AddWithValue("@requestDate", obj.RequestDate);
            cmd.Parameters.AddWithValue("@needDate", obj.NeedDate);
            cmd.Parameters.AddWithValue("@UnitRequested", obj.UnitsRequested);
            cmd.Parameters.AddWithValue("@unitAssigned", obj.UnitsAssigned);
            cmd.Parameters.AddWithValue("@condition", obj.Condition);
            cmd.Parameters.AddWithValue("@status", obj.Status);
            int r =cmd.ExecuteNonQuery();
            if (r > 0) {
                MessageBox.Show("Request Added");
            
            }

        }

        private void CreateRequest_Load(object sender, EventArgs e)
        {
            lblTotalRequest.Text += Requests.Count;
            approvedReqeust();
        }
        int countOfApprovedRequest = 0;
        private void approvedReqeust() {

            foreach (BloodRequest b in Requests) {
                if (b.Status == "Approved") countOfApprovedRequest++;
            
            }
            lblApprovedRequest.Text += countOfApprovedRequest;
        }
    }
}
