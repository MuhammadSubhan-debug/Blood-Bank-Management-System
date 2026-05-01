using System;
using System.Windows.Forms;

namespace BBMS
{
    public partial class LoadingScreen : Form
    {
        private readonly int maxWidth = 751;

        public LoadingScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            panelSizeable.Width = 0;
            lblPercentage.Text = "0%";
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Interval = 20;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSizeable.Width += 5;

            double percentage = (double)panelSizeable.Width / maxWidth * 100;

            if (percentage >= 100)
            {
                lblPercentage.Text = "100%";
                timer1.Stop();

                this.Hide();
               LoginPage obj = new LoginPage();
                obj.Show();
            }
            else
            {
                lblPercentage.Text = $"Loading {(int)percentage}%";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}