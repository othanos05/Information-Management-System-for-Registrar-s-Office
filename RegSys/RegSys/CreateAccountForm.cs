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
    public partial class CreateAccountForm : Form
    {
        private string adminId;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=regoff.accdb"; // Your database path

        public CreateAccountForm(string loginuserId = "")
        {
            InitializeComponent();
            InitializeRoleComboBox(); // Initialize the ComboBox when the form is loaded
            adminId = loginuserId;
        }
        private void InitializeRoleComboBox()
        {
            // Add the role options to the ComboBox
            rolecb.Items.Add("STUDENT");
            rolecb.Items.Add("ADMIN");
            rolecb.SelectedIndex = 0; // Set default selected item to 'STUDENT'
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearsectb_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void contacttb_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void createaccbtn_Click(object sender, EventArgs e)
        {
            string firstName = fnametb.Text;
            string lastName = lnametb.Text;
            string yearSection = yearsectb.Text;
            string studentId = IDtb.Text;
            string contactNumber = contacttb.Text;
            string email = emailtb.Text;
            string role = rolecb.SelectedItem.ToString(); // Get the selected role (STUDENT or ADMIN)
            string password = "DEFPASS01"; // You can modify this later to accept user-generated passwords

            string query = "INSERT INTO useracc (First_Name, Last_Name, Year_Section, Student_ID, Contact_Number, Email_Address, [Password], Role) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    OleDbCommand command = new OleDbCommand(query, connection);

                    // Use parameterized queries to avoid SQL injection
                    command.Parameters.AddWithValue("?", firstName);
                    command.Parameters.AddWithValue("?", lastName);
                    command.Parameters.AddWithValue("?", yearSection);
                    command.Parameters.AddWithValue("?", studentId);
                    command.Parameters.AddWithValue("?", contactNumber);
                    command.Parameters.AddWithValue("?", email);
                    command.Parameters.AddWithValue("?", password); // Default password
                    command.Parameters.AddWithValue("?", role);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!");

                    this.Close(); // Close the form after saving the account
                }
                catch (OleDbException ex)
                {
                    // Handle specific database errors
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Handle general exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    

        private void backbtn_Click(object sender, EventArgs e)
        {
            ManUser user = new ManUser(adminId);
            user.Show();

            this.Hide();    
            
        }
    }
}
