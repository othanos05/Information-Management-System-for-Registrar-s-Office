using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Linq;

namespace RegSys
{
    public partial class Dashboard : Form
    {

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=regoff.accdb";
        public string userId { get; set; } // Store the logged-in user's ID

        // Add a constructor that accepts userId
        public Dashboard(string loginUserId = "")
        {
            InitializeComponent();
            userId = loginUserId;
            
        }
        public Dashboard()
        {
            InitializeComponent();
            pbox.Image = Image.FromFile(@"D:\Othan C#\logo.png");
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void User_Load(object sender, EventArgs e)
        {

            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userId); // Pass the userId
            dashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(userId); // Pass the userId
            profile.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Appointment_Form appointment = new Appointment_Form(userId);
            appointment.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About about = new About(userId);
            about.Show();

            this.Hide();
        }

        private void pbox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
