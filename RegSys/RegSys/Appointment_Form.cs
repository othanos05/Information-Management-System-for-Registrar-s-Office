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
using static System.Net.WebRequestMethods;

namespace RegSys
{
    public partial class Appointment_Form : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=regoff.accdb";
        public string userId { get; set; } // Store the logged-in user's ID
        public Appointment_Form(string loginuserId = "")
        {
            InitializeComponent();
            userId = loginuserId;
        }

        private void InitializeDataGridView()
        {
            dgvdocs.Columns.Clear();

            // Predefine the columns
            dgvdocs.Columns.Add("TransactionID", "Transaction ID"); // Add Transaction ID column
            dgvdocs.Columns.Add("TypeOfDocument", "Type of Document");
            dgvdocs.Columns.Add("Status", "Status");

            // Set other properties
            dgvdocs.AllowUserToAddRows = false; // Prevent adding rows manually
            dgvdocs.ReadOnly = true; // Make the grid read-only for display
        }
        private void LoadData()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                // Filter data to display only rows where StudentID matches the logged-in user's ID
                string query = "SELECT TransactionNumber AS [Transaction ID], Document_Type AS [Type of Document], Status FROM documents WHERE Student_ID = ?";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("?", userId); // Use the logged-in user's ID to filter data

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the filtered DataTable to the DataGridView
                dgvdocs.DataSource = dt;

                // Ensure DataGridView properties
                dgvdocs.AutoGenerateColumns = true; // Automatically generate columns based on the data
                dgvdocs.AllowUserToAddRows = false; // Prevent adding rows manually
                dgvdocs.ReadOnly = true; // Make the grid read-only for display
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void Appointment_Form_Load(object sender, EventArgs e)
        {
            LoadData();

            // Populate the CheckedListBox
            clb.Items.Add("Transcript of Records");
            clb.Items.Add("Certificate of Registration");
            clb.Items.Add("Certificate of Good Moral");

        }

        private void pbox_Click(object sender, EventArgs e)
        {

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
            this.Hide();
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

        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                foreach (var item in clb.CheckedItems)
                {
                    // Insert into database, including Student ID
                    string insertQuery = "INSERT INTO documents (Student_ID, Document_Type, Status) VALUES (?, ?, ?)";
                    OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("?", userId); // Add the logged-in user ID (Student ID)
                    insertCommand.Parameters.AddWithValue("?", item.ToString());
                    insertCommand.Parameters.AddWithValue("?", "Pending");

                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Data Added Successfully!");

                // Clear the selection
                clb.ClearSelected();

                // Refresh DataGridView
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                if (dgvdocs.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvdocs.SelectedRows[0].Index;

                    // Correct column names
                    string typeOfDocument = dgvdocs.SelectedRows[0].Cells["Type of Document"].Value.ToString();

                    // Delete from database
                    string query = "DELETE FROM documents WHERE Document_Type = ?";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("?", typeOfDocument);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    // Remove row from DataGridView
                    dgvdocs.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Data Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            // Loop through all items in the CheckedListBox and uncheck them
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.ClearSelected();
                clb.SetItemChecked(i, false);
            }
        }

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dgvdocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dgvdocs.Rows[e.RowIndex];

                // Populate ChecklistBox
                string selectedDocument = row.Cells["TypeOfDocument"].Value.ToString();
                for (int i = 0; i < clb.Items.Count; i++)
                {
                    clb.SetItemChecked(i, clb.Items[i].ToString() == selectedDocument);
                }
            }
        }
    }
}