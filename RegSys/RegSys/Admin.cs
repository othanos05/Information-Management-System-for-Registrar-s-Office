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
using System.Net.Mail;

namespace RegSys
{
    public partial class Admin : Form
    {
        private string adminId;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=regoff.accdb"; // Update path to your database


        // Add a constructor that accepts userId
        public Admin(string loginuserId = "")
        {
            InitializeComponent();
            adminId = loginuserId;


        }
        private void Admin_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data into the DataGridView when the form loads
        }
        private void LoadData()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string query = "SELECT TransactionNumber AS [Transaction ID], Student_ID AS [Student ID], Document_Type AS [Type of Document], Status FROM documents";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvAdmin.DataSource = dt;

                // Add Approve Button if not already added
                if (!dgvAdmin.Columns.Contains("ApproveButton"))
                {
                    DataGridViewButtonColumn approveButton = new DataGridViewButtonColumn();
                    approveButton.Name = "ApproveButton";
                    approveButton.HeaderText = "Approve";
                    approveButton.Text = "Approve";
                    approveButton.UseColumnTextForButtonValue = true;
                    dgvAdmin.Columns.Add(approveButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchtb.Text.ToLower(); // Get the search text and convert to lowercase for case-insensitive search

            // Modify the RowFilter to handle numeric fields
            (dgvAdmin.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                "CONVERT([Transaction ID], 'System.String') LIKE '%{0}%' OR CONVERT([Student ID], 'System.String') LIKE '%{0}%'",
                searchQuery);
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

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAdmin.Columns[e.ColumnIndex].Name == "ApproveButton")
            {
                DataGridViewRow row = dgvAdmin.Rows[e.RowIndex];
                string transactionNumber = row.Cells["Transaction ID"].Value.ToString();
                string studentId = row.Cells["Student ID"].Value.ToString();

                // Retrieve the email address of the user
                string userEmail = GetUserEmail(studentId);
                if (string.IsNullOrEmpty(userEmail))
                {
                    MessageBox.Show("Error: User email not found.");
                    return;
                }

                // Update the status to "Approved"
                UpdateStatusToApproved(transactionNumber);

                // Send an email to the user
                SendApprovalEmail(userEmail);

                MessageBox.Show("Request approved, and email sent successfully!");
            }
        }
        private void UpdateStatusToApproved(string transactionNumber)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string updateQuery = "UPDATE documents SET Status = ? WHERE TransactionNumber = ?";
                OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("?", "Approved");
                updateCommand.Parameters.AddWithValue("?", transactionNumber);

                connection.Open();
                updateCommand.ExecuteNonQuery();
                connection.Close();

                LoadData(); // Refresh the DataGridView to reflect the updated status
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating status: " + ex.Message);
            }
        }
        private void SendApprovalEmail(string userEmail)
        {
            try
            {
                string fromEmail = "orewaotyan@gmail.com"; // Replace with your email
                string fromPassword = "bhiamyetrcdvbqiz"; // Replace with your email password or app-specific password

                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(fromEmail);
                mail.To.Add(userEmail);
                mail.Subject = "Document Request Approved";
                mail.Body = "Dear User,\n\nYour document request has been approved. Please proceed with the payment to finalize the process. Once payment is confirmed, your requested documents will be released.\n\nThank you for using our system!\n\nBest regards,\nRegistrar's Office";

                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(fromEmail, fromPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private string GetUserEmail(string studentId)
        {
            string email = string.Empty;
            string query = "SELECT Email_Address FROM useracc WHERE Student_ID = ?";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("?", studentId);

                connection.Open();
                email = command.ExecuteScalar()?.ToString();
                connection.Close();
            }
            return email;
        }

        private bool DoesStudentIdExist(string studentId)
        {
            string query = "SELECT COUNT(*) FROM useracc WHERE Student_ID = ?";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("?", studentId);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }
        private void release_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0) // Ensure a row is selected
            {
                DataGridViewRow selectedRow = dgvAdmin.SelectedRows[0];
                string transactionId = selectedRow.Cells["Transaction ID"].Value.ToString();
                string studentId = selectedRow.Cells["Student ID"].Value.ToString();
                string documentType = selectedRow.Cells["Type of Document"].Value.ToString();

                if (!DoesStudentIdExist(studentId))
                {
                    MessageBox.Show("Error: The Student ID does not exist in the user account table.");
                    return;
                }

                // Ensure that the DateTimePicker has a valid date selected
                if (dtpPickupDate.Value == null || dtpPickupDate.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Please select a valid pickup date.");
                    return;
                }

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        // Step 1: Insert the row into the history table with the pickup date
                        string insertQuery = @"INSERT INTO history (TransactionNumber, Document_Type, Student_ID, Pickup_Date) 
                                       VALUES (?, ?, ?, ?)";
                        OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("?", transactionId);
                        insertCommand.Parameters.AddWithValue("?", documentType);
                        insertCommand.Parameters.AddWithValue("?", studentId);
                        insertCommand.Parameters.AddWithValue("?", dtpPickupDate.Value);  // Add the pickup date

                        connection.Open();
                        insertCommand.ExecuteNonQuery();

                        // Step 2: Delete the row from the documents table
                        string deleteQuery = "DELETE FROM documents WHERE TransactionNumber = ?";
                        OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection);
                        deleteCommand.Parameters.AddWithValue("?", transactionId);

                        deleteCommand.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Step 3: Remove the row from the DataGridView
                    dgvAdmin.Rows.Remove(selectedRow);

                    // Step 4: Send the email notification to the user
                    string userEmail = GetUserEmail(studentId);
                    if (!string.IsNullOrEmpty(userEmail))
                    {
                        SendReleaseNotificationEmail(userEmail, documentType, dtpPickupDate.Value);
                    }

                    MessageBox.Show("Row successfully released, transferred to the history table, and pickup date set.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to release.");
            }
        }
        private void SendReleaseNotificationEmail(string userEmail, string documentType, DateTime pickupDate)
        {
            try
            {
                string fromEmail = "orewaotyan@gmail.com"; // Replace with your email
                string fromPassword = "bhiamyetrcdvbqiz"; // Replace with your email password or app-specific password

                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(fromEmail);
                mail.To.Add(userEmail);
                mail.Subject = "Document Request Released and Ready for Pickup";

                // Format the body of the email
                string emailBody = $"Dear User,\n\n" +
                                   $"Your document request for '{documentType}' has been approved and waiting to be pick up. " +
                                   $"Please note that your document will be ready for pickup on {pickupDate.ToString("MMMM dd, yyyy")}.\n\n" +
                                   $"Thank you for using our system!\n\n" +
                                   $"Best regards,\n" +
                                   $"Registrar's Office";

                mail.Body = emailBody;

                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(fromEmail, fromPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);  // Send the email
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }


    }
    
}
