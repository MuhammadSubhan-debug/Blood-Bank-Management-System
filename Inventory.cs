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
    public partial class Inventory : Form
    {
        List<User> users = null;
        public Inventory(List<User> u)
        {
            InitializeComponent();
            users = u;
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard(users);
            this.Hide();
            obj.Show();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            ResetLabels();
            LoadInventory();

        }
        private void LoadInventory()
        {
            string query = "SELECT * FROM Inventory";
            SqlCommand cmd = new SqlCommand(query, DBManager.conn);
            DBManager.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            ResetLabels(); // set all to 0 first

            while (reader.Read())
            {
                string bg = reader["BloodGroup"].ToString();
                int units = (int)(reader["AvailableUnits"]);

                switch (bg)
                {
                    case "A+":
                        lblApos.Text = "A+ : " + units;
                        break;

                    case "A-":
                        lblAneg.Text = "A- : " + units;
                        break;

                    case "B+":
                        lblBpos.Text = "B+ : " + units;
                        break;

                    case "B-":
                        lblBneg.Text = "B- : " + units;
                        break;

                    case "AB+":
                        lblABpos.Text = "AB+ : " + units;
                        break;

                    case "AB-":
                        lblABneg.Text = "AB- : " + units;
                        break;

                    case "O+":
                        lblOpos.Text = "O+ : " + units;
                        break;

                    case "O-":
                        lblONeg.Text = "O- : " + units;
                        break;
                }
            }

            reader.Close();
            DBManager.Close();
            
        }
        private void ResetLabels()
        {
            lblApos.Text = "A+ : 0";
            lblAneg.Text = "A- : 0";
            lblBpos.Text = "B+ : 0";
            lblBneg.Text = "B- : 0";
            lblABpos.Text = "AB+ : 0";

            lblABneg.Text = "AB- : 0";
            lblOpos.Text = "O+ : 0";
            lblONeg.Text = "O- : 0";
        }
    }
}
