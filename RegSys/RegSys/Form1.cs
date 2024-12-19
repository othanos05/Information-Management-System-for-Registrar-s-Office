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
    public partial class Form1 : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private int loginAttempts = 0;

        public Form1()
        {
            InitializeComponent();
            pbox.Image = Image.FromFile(@"D:\Othan C#\logo.png");
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=regoff.accdb;";
            string query = "SELECT [Role], [Student_ID] FROM useracc WHERE Student_ID = @username AND Password = @password";

            try
            {
                using (conn = new OleDbConnection(connectionString))
                {
                    using (cmd = new OleDbCommand(query, conn))
                    {
                        // Bind parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", untb.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", pwtb.Text.Trim());

                        conn.Open();

                        OleDbDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            loginAttempts = 0; // Reset login attempts
                            string userType = reader["Role"].ToString();
                            string userId = reader["Student_ID"].ToString();

                            // Log the login to the history
                            LogLoginHistory(userId, userType, connectionString);

                            // Navigate to appropriate form based on the user type
                            this.Hide();

                            if (userType == "ADMIN")
                            {
                                Admin adminForm = new Admin(untb.Text);
                                adminForm.Show();
                            }
                            else if (userType == "STUDENT")
                            {
                                Dashboard dashboardForm = new Dashboard(untb.Text);
                                dashboardForm.Show();
                            }
                            else if (userType == "STAFF")
                            {
                                Admin adminForm = new Admin(untb.Text);
                                adminForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Unrecognized role. Contact administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Show();
                            }
                        }
                        else
                        {
                            // Invalid login
                            loginAttempts++;
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            if (loginAttempts >= 3)
                            {
                                MessageBox.Show("Too many failed attempts. Application will now exit.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LogLoginHistory(string userId, string role, string connectionString)
        {
            string logQuery = "INSERT INTO logTab (Student_ID, Role, Time_In) VALUES (?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(logQuery, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("?", userId); // Short Text
                        cmd.Parameters.AddWithValue("?", role); // Short Text
                        cmd.Parameters.AddWithValue("?", DateTime.Now); // Date/Time

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error logging login history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SPcb.Checked)
            {
                pwtb.PasswordChar = '\0';
            }
            else
            {
                pwtb.PasswordChar = '*';
            }
        }

        private void pwtb_TextChanged(object sender, EventArgs e)
        {
            pwtb.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void untb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
