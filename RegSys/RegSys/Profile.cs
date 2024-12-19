using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RegSys
{
    public partial class Profile : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=regoff.accdb";
        public string userId { get; set; } // Store the logged-in user's ID
        private bool isImageUploaded = false; // Tracks if an image is uploaded

        public Profile(string loginuserId = "")
        {
            InitializeComponent();
            userId = loginuserId;
        }

        private string GetloginuserId()
        {
            return "";
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
           
        }

        private void aboutBTN_Click(object sender, EventArgs e)
        {
            About about = new About(userId);
            about.Show();

            this.Hide();
        }


        private void emailEditbtn_Click(object sender, EventArgs e)
        {
            ToggleEditing(true); // Enable editing for Email
            emailTB.Focus();
        }

        private void contactEditbtn_Click(object sender, EventArgs e)
        {
            ToggleEditing(true); // Enable editing for Contact
            contactTB.Focus();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadProfileData(); // Load the user's profile data when the form loads
            ToggleEditing(false); // Disable editing initially
        }
        private void LoadProfileData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "SELECT First_Name, Last_Name, Year_Section, Student_ID, Contact_Number, Email_Address, Profile_Pic FROM useracc WHERE Student_ID = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", userId);

                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Populate the textboxes with the data
                            nameTB.Text = $"{reader["First_Name"]} {reader["Last_Name"]}";
                            yearsecTB.Text = reader["Year_Section"].ToString();
                            IDtb.Text = reader["Student_ID"].ToString();
                            contactTB.Text = reader["Contact_Number"].ToString();
                            emailTB.Text = reader["Email_Address"].ToString();

                            // Load the profile picture if available
                            if (reader["Profile_Pic"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["Profile_Pic"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    pfpbox.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                pfpbox.Image = null; // No image stored
                            }
                        }
                        else
                        {
                            MessageBox.Show("Profile data not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ToggleEditing(bool isEditing)
        {
            // Enable or disable editing of the contact and email fields
            contactTB.ReadOnly = !isEditing;
            emailTB.ReadOnly = !isEditing;

            // Toggle the visibility of Save buttons
            contactsave.Enabled = isEditing;
            emailsave.Enabled = isEditing;

            // Disable Edit buttons while in editing mode
            contactEditbtn.Enabled = !isEditing;
            emailEditbtn.Enabled = !isEditing;
        }


        private void contactsave_Click(object sender, EventArgs e)
        {
            SaveField("Contact_Number", contactTB.Text);
            ToggleEditing(false);
        }

        private void emailsave_Click(object sender, EventArgs e)
        {
            SaveField("Email_Address", emailTB.Text);
            ToggleEditing(false);
        }
        private void SaveField(string fieldName, string fieldValue)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = $"UPDATE useracc SET {fieldName} = ? WHERE Student_ID = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", fieldValue); // The value for the field
                        command.Parameters.AddWithValue("?", userId); // The user ID

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{fieldName.Replace("_", " ")} updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProfileData(); // Reload the updated data
                        }
                        else
                        {
                            MessageBox.Show($"Failed to update {fieldName.Replace("_", " ")}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open file dialog for selecting an image
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display selected image in the PictureBox
                pfpbox.Image = new Bitmap(openFileDialog.FileName);
                pfpbox.Tag = openFileDialog.FileName; // Store file path for saving later

                picsave.Visible = true; // Show the save button
            }
        }

        private void picsave_Click(object sender, EventArgs e)
        {
            if (pfpbox.Image != null && pfpbox.Tag != null)
            {
                try
                {
                    // Convert the image to a byte array
                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pfpbox.Image.Save(ms, pfpbox.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    // Save the image to the database
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "UPDATE useracc SET Profile_Pic = ? WHERE Student_ID = ?";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("?", imageBytes);
                            command.Parameters.AddWithValue("?", userId);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Profile picture updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to update profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving profile picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a photo to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogLogoutHistory();

            // Navigate back to the login form
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
        private void LogLogoutHistory()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "UPDATE logTab SET Time_Out = ? WHERE Student_ID = ? AND Time_Out IS NULL";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", DateTime.Now); // Current logout time
                        command.Parameters.AddWithValue("?", userId); // Current user ID

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Logout recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to record logout. No active session found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording logout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            changepassUser cpUser = new changepassUser(userId);
            cpUser.ShowDialog(); // Open the form as a modal dialog
        }
    }
}
