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

namespace RegSys
{
    public partial class changepassUser : Form

    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=regoff.accdb";
        public string userId { get; set; } // Store the logged-in user's ID
        private bool isImageUploaded = false; // Tracks if an image is uploaded

        public changepassUser(string loginuserId = "")
        {
            InitializeComponent();
            userId = loginuserId;
        }
        private string GetloginuserId()
        {
            return "";
        }

        private void changepassUser_Load(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without saving changes
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string currentPassword = ecptb.Text; // Current password entered by user
            string newPassword = enptb.Text;     // New password
            string confirmPassword = renptb.Text; // Confirm new password

            // Validation: Ensure fields are filled
            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validation: Ensure new password matches confirmation
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    // Step 1: Validate the current password
                    string query = "SELECT [Password] FROM useracc WHERE Student_ID = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", userId);
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result == null || result.ToString() != currentPassword)
                        {
                            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Step 2: Update the password
                    string updateQuery = "UPDATE useracc SET [Password] = ? WHERE Student_ID = ?";
                    using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("?", newPassword); // New password
                        updateCommand.Parameters.AddWithValue("?", userId);      // User ID

                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the change password form
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
