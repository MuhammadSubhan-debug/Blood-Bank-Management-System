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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }
        public Request(List<User> u)
        {
            InitializeComponent();
            Users = u;
        }
        List<User> Users = null;
        List<BloodRequest> bloodRequests = new List<BloodRequest>();

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            Dashboard ob = new Dashboard(Users);
            this.Hide();
            ob.Show();
        }

        private List<string> GetCompatibleBloodGroups(string bg)
        {
            switch (bg.ToUpper())
            {
                case "A+": return new List<string> { "A+", "A-", "O+", "O-" };
                case "A-": return new List<string> { "A-", "O-" };
                case "B+": return new List<string> { "B+", "B-", "O+", "O-" };
                case "B-": return new List<string> { "B-", "O-" };
                case "AB+": return new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
                case "AB-": return new List<string> { "A-", "B-", "AB-", "O-" };
                case "O+": return new List<string> { "O+", "O-" };
                case "O-": return new List<string> { "O-" };
                default: return new List<string>();
            }
        }
        private void Request_Load(object sender, EventArgs e)
        {
            LoadRequest();
            lblTotalDonor.Text += bloodRequests.Count;
            dgvRequest .DataSource = bloodRequests;
        }
        private void LoadRequest() {
            try
            {
                string q = @"select * from BloodRequest";
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
                        BloodGroup = sdr["BloodGroup"].ToString(),
                        RequestId = (int)sdr["RequestId"],
                        NeedDate = (DateTime)sdr["NeedDate"]

                    };
                    bloodRequests.Add(temp);

                }
            }
            catch(Exception ex  ) {
                Logger.LogException(ex);
            
            }
            DBManager.Close();
        }
        List<int> ApproveIDS=new List<int>();
        BloodRequest selected = null;
        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                if (dgvRequest.Columns[e.ColumnIndex].Name == "colApprove")
                {
                    BloodRequest temp = dgvRequest.Rows[e.RowIndex].DataBoundItem as BloodRequest;
                    ApproveIDS.Add(temp.RequestId);

                }
                else if (dgvRequest.Columns[e.ColumnIndex].Name == "colSelect")
                {
                    selected = dgvRequest.Rows[e.RowIndex].DataBoundItem as BloodRequest;
                    if (selected != null) { 
                      var list=  GetCompatibleBloodGroups(selected.BloodGroup);
                        cmbCompatilbeGroups.DataSource = null;
                        cmbCompatilbeGroups.Items.Clear();

                        cmbCompatilbeGroups.Items.AddRange(list.ToArray());
                        cmbCompatilbeGroups.SelectedIndex = -1;
                        lblList.Text += list.Count;
                        
                        if (list.Count == 0)
                        {
                            MessageBox.Show("No compatible groups found");
                            return;
                        }
                        else {
                            MessageBox.Show("else parting is working the list is assig");
                            cmbCompatilbeGroups.DataSource = list;

                        }

                    }

                    else {
                        MessageBox.Show("First select  a record");
                    }

                }
            }
            catch (Exception ex) {
                Logger.LogException(ex);
                MessageBox.Show("Error ");

            
            }
            
        }

      
          private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected == null)
                {
                    MessageBox.Show("Select request first");
                    return;
                }

                string bg = cmbCompatilbeGroups.SelectedItem.ToString();
                int units = (int)txtAssigned.Value;

                DBManager.Open();

                // 1️⃣ Get Unit IDs
                string q1 = @"SELECT TOP (@u) bloodUnitID 
                      FROM BloodUnit 
                      WHERE BloodGroup=@bg AND Status='Available'";

                SqlCommand cmd1 = new SqlCommand(q1, DBManager.conn);
                cmd1.Parameters.AddWithValue("@u", units);
                cmd1.Parameters.AddWithValue("@bg", bg);

                SqlDataReader sdr = cmd1.ExecuteReader();

                List<int> ids = new List<int>();
                while (sdr.Read())
                {
                    ids.Add((int)sdr["BloodUnitId"]);
                }
                sdr.Close();

                if (ids.Count < units)
                {
                    MessageBox.Show("Not enough units");
                    DBManager.Close();
                    return;
                }

                // 2️⃣ Update BloodUnit + Insert Assignment
                foreach (int id in ids)
                {
                    // Update unit
                    string q2 = "UPDATE BloodUnit SET Status='Used' WHERE BloodUnitId=@id";
                    SqlCommand cmd2 = new SqlCommand(q2, DBManager.conn);
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.ExecuteNonQuery();

                    // Insert assignment
                    string q3 = @"INSERT INTO BloodAssignment(RequestId, BloodUnitId,AssignedDate)
                          VALUES(@rid, @uid,@AssignedDate)";
                    SqlCommand cmd3 = new SqlCommand(q3, DBManager.conn);
                    cmd3.Parameters.AddWithValue("@rid", selected.RequestId);
                    cmd3.Parameters.AddWithValue("@uid", id);
                    cmd3.Parameters.AddWithValue("@AssignedDate",DateTime.Today.Date);
                    cmd3.ExecuteNonQuery();
                }

                // 3️⃣ Update Request
                string q4 = @"UPDATE BloodRequest 
                      SET Status='Approved', UnitsAssigned=@u
                      WHERE RequestId=@rid";

                SqlCommand cmd4 = new SqlCommand(q4, DBManager.conn);
                cmd4.Parameters.AddWithValue("@u", units);
                cmd4.Parameters.AddWithValue("@rid", selected.RequestId);
                cmd4.ExecuteNonQuery();

                DBManager.Close();

                MessageBox.Show("Approved Successfully");
                bloodRequests.Clear();
                LoadRequest();
                dgvRequest.DataSource = null;
                dgvRequest.DataSource = bloodRequests;
            }
            catch (Exception ex)
            {
                DBManager.Close();
                MessageBox.Show("Error");
                Logger.LogException(ex);    
            }
        }
    }
    }

