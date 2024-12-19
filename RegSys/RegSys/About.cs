using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegSys
{
    public partial class About : Form
    {
        public string userId { get; set; } // Store the logged-in user's ID
        public About(string loginuserId = "")
        {
            InitializeComponent();
            userId = loginuserId;
        }

        private void aboutBTN_Click(object sender, EventArgs e)
        {
            About about = new About(userId);
            about.Show();

            this.Hide();
        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userId); // Pass the userId
            dashboard.Show();
            this.Hide();
        }

        private void appointmentBTN_Click(object sender, EventArgs e)
        {
            Appointment_Form appointment = new Appointment_Form(userId);
            appointment.Show();

            this.Hide();
        }

        private void profileBTN_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(userId); // Pass the userId
            profile.Show();
            this.Hide(); ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
