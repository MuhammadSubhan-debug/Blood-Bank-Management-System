using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class Appointment_show : Form
    {
        public Appointment_show(List<DonationAppointment>list1)
        {
            InitializeComponent();
            listOFAppointments = list1;
        }

        List<DonationAppointment> listOFAppointments = null;
        
        private void Appointment_show_Load(object sender, EventArgs e)
        {
            lblTotalAppointment.Text += listOFAppointments.Count;
            dgvAppointments.DataSource = listOFAppointments;
        }
        DonationAppointment toUpdate = null;
        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAppointments.Columns[e.ColumnIndex].Name == "colApprove")
                {
                    toUpdate = dgvAppointments.Rows[e.RowIndex].DataBoundItem as DonationAppointment;
                    DialogResult temp = MessageBox.Show("Do you want to approve the appointment ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (temp == DialogResult.OK)
                    {
                        listOFAppointments.Remove(toUpdate);
                        toUpdate.Status = "Approved";
                        UpdateStatusOfAppointment(toUpdate);

                        listOFAppointments.Add(toUpdate);
                        dgvAppointments.DataSource = null;
                        dgvAppointments.DataSource = listOFAppointments;

                    }
                    else
                    {
                       // return;
                    }


                }
                else if (dgvAppointments.Columns[e.ColumnIndex].Name == "ColReject")
                {
                    toUpdate = dgvAppointments.Rows[e.RowIndex].DataBoundItem as DonationAppointment;
                    DialogResult temp = MessageBox.Show("Do you want to Reject the appointment ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (temp == DialogResult.OK)
                    {
                        listOFAppointments.Remove(toUpdate);

                        toUpdate.Status = "Rejected";
                        UpdateStatusOfAppointment(toUpdate);
                        listOFAppointments.Add(toUpdate);
                        dgvAppointments.DataSource = null;
                        dgvAppointments.DataSource = listOFAppointments;
                    }
                    else
                    {
                      //  return;
                    }


                }
            }
            catch (Exception ex ){
              //  return;
            
                Logger.LogException(ex);
                MessageBox.Show("Logger Upated ");
            }

        }
        private void UpdateStatusOfAppointment(DonationAppointment temp) {
            string q = @"update DonationAppointment set Status=@status where AppointmentId = @id";
            SqlCommand cmd = new SqlCommand(q, DBManager.conn);
            cmd.Parameters.AddWithValue("@id",temp.AppointmentId);
            cmd.Parameters.AddWithValue("@status", temp.Status);
            DBManager.Open();
            cmd.ExecuteNonQuery();
            DBManager.Close();
            MessageBox.Show("User status updated");
            



        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
