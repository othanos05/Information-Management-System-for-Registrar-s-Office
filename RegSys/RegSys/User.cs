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
    public partial class User : Form
    {

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=regoff.accdb";

        List<Panel> listPanel = new List<Panel>();
        int index = 0;
        public User()
        {
            InitializeComponent();
            pbox.Image = Image.FromFile(@"D:\Othan C#\logo.png");
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void User_Load(object sender, EventArgs e)
        {
           

            listPanel.Add(dashpanel);
            listPanel.Add(apppanel);
            listPanel.Add(profpanel);
            listPanel.Add(aboutpanel);


            foreach (var panel in listPanel)
            {
                panel.Visible = true;
            }
            listPanel[index].BringToFront();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            index = 0;  // profile index
            listPanel[index].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = 2;  // dash index
            listPanel[index].BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = 1;  // appoointment index
            listPanel[index].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 3;  // about index
            listPanel[index].BringToFront();
        }

        private void pbox_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void profpanel_Paint(object sender, PaintEventArgs e)
        { 
            using (OleDbConnection connection = new OleDbConnection(connectionString))
                
            {
                string query = "SELECT First_Name, Last_Name, Student_ID, Contact_Number, Email_Address FROM useracc "; // Adjust condition as needed
                OleDbCommand command = new OleDbCommand(query, connection);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    nametb.Text = $"{reader["First_Name"]} {reader["Last_Name"]}";
                    idtb.Text = reader["Student_ID"].ToString();
                    contb.Text = reader["Contact_Number"].ToString();
                    emailtb.Text = reader["Email_Address"].ToString();
                }

                connection.Close();
            }
            RefreshData();
            LoadProfilePicture();
        }
     

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            nametb.ReadOnly = true;
            idtb.ReadOnly = true;
            contb.ReadOnly = false;
            emailtb.ReadOnly = false;
        }


        private void savebtn_Click_1(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(contb.Text) || string.IsNullOrEmpty(emailtb.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the database
            string query = "UPDATE useracc SET Contact_Number = @ContactNumber, Email_Address = @Email WHERE Student_ID = @ID";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ContactNumber", contb.Text.Trim());
                command.Parameters.AddWithValue("@Email", emailtb.Text.Trim());
                command.Parameters.AddWithValue("@ID", idtb.Text.Trim());

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Refresh UI to reflect changes
            RefreshData();

            // Lock fields again
            contb.ReadOnly = true;
            emailtb.ReadOnly = true;

        }
        private void RefreshData()
        {
            // Fetch updated data for the current user
            string query = "SELECT * FROM useracc WHERE Student_ID = @ID";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ID", idtb.Text.Trim());

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    contb.Text = reader["Contact_Number"].ToString();
                    emailtb.Text = reader["Email_Address"].ToString();
                }
                reader.Close();
            }
        }

        private void editbtn_Click_2(object sender, EventArgs e)
        {
         
        }

       
        private void pbox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbox2.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void saveimage_Click(object sender, EventArgs e)
        {
            if (pbox2.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageBytes = ms.ToArray();

                    string query = "UPDATE useracc SET ProfileImage = @ProfilePicture WHERE Student_ID = @ID";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@ProfilePicture", imageBytes);
                        command.Parameters.AddWithValue("@ID", idtb.Text.Trim());

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Profile picture updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("No image selected. Please upload an image first.");
            }
        }
        private void LoadProfilePicture()
        {
            string query = "SELECT ProfileImage FROM useracc WHERE Student_ID = @ID";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ID", idtb.Text.Trim());

                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    byte[] imageBytes = (byte[])result;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbox2.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbox2.Image = null; // Clear picture if none exists
                }
            }
        }
    }
}
