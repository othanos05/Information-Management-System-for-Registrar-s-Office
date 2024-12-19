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
    public partial class ManUser : Form
    {
        private string adminId;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=regoff.accdb"; // Update path to your database
        public ManUser(string loginuserId = "")
        {
            InitializeComponent();
            adminId = loginuserId;
        }

        private void mabtn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(adminId);
            admin.Show();

            this.Hide();
        }

        private void thbtn_Click(object sender, EventArgs e)
        {
            TranHis transaction = new TranHis(adminId);
            transaction.Show();

            this.Hide();
        }

        private void mubtn_Click(object sender, EventArgs e)
        {
            ManUser manuser = new ManUser(adminId);
            manuser.Show();

            this.Hide();
        }

        private void pfpbox_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(adminId);
            ap.Show();

            this.Hide();
        }

        private void ManUser_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data into the DataGridView when the form loads
        }
        private void LoadData()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                // Query to get user information from the useracc table
                string query = @"SELECT Student_ID AS [User ID], First_Name AS [First Name],Last_Name AS [Last Name], Year_Section AS [Year & Section], Student_ID AS [Student ID], Contact_Number AS [Contact Number], Email_Address AS [Email Address] FROM useracc";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                dgvUser.DataSource = dt;

                // Ensure DataGridView properties
                dgvUser.AutoGenerateColumns = true; // Automatically generate columns based on the data
                dgvUser.AllowUserToAddRows = false; // Prevent adding rows manually
                dgvUser.ReadOnly = true; // Make the grid read-only for display
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchtb.Text.ToLower(); // Get the search text and convert to lowercase for case-insensitive search

            // Modify the RowFilter to search for matches in the Name, Section, and Student ID columns
            (dgvUser.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                "CONVERT([First Name], 'System.String') LIKE '%{0}%' OR CONVERT([Last Name], 'System.String') LIKE '%{0}%' OR " +
                "CONVERT([Year & Section], 'System.String') LIKE '%{0}%' OR CONVERT([Student ID], 'System.String') LIKE '%{0}%'",
                searchQuery);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            CreateAccountForm acc = new CreateAccountForm(adminId);
            acc.Show();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dgvUser.SelectedRows.Count > 0)
            {
                // Get the Student_ID (or User ID) of the selected row
                string studentId = dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString();

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Create the SQL DELETE query to remove the user from the database
                    string query = @"DELETE FROM useracc WHERE Student_ID = ?";

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        try
                        {
                            // Prepare the command with parameterized query to avoid SQL injection
                            OleDbCommand command = new OleDbCommand(query, connection);
                            command.Parameters.AddWithValue("?", studentId);

                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Account deleted successfully!");

                            // Refresh the DataGridView to reflect the changes
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting the account: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
