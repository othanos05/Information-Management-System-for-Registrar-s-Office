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
    public partial class TranHis : Form
    {
        private string adminId;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=regoff.accdb"; // Update path to your database
        public TranHis(string loginuserId = "")
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

        private void TranHis_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data into the DataGridView when the form loads
        }
        private void LoadData()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string query = @"SELECT History_Number AS [Record Number], TransactionNumber AS [Transaction ID], Student_ID AS [Student ID], Document_Type AS [Type of Document] FROM history";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                dgvTranHis.DataSource = dt;

                // Ensure DataGridView properties
                dgvTranHis.AutoGenerateColumns = true; // Automatically generate columns based on the data
                dgvTranHis.AllowUserToAddRows = false; // Prevent adding rows manually
                dgvTranHis.ReadOnly = true; // Make the grid read-only for display
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchtb.Text.ToLower(); // Get the search text and convert to lowercase for case-insensitive search

            // Modify the RowFilter to search only in the Transaction ID and Student ID columns
            (dgvTranHis.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                "CONVERT([Transaction ID], 'System.String') LIKE '%{0}%' OR " +
                "CONVERT([Student ID], 'System.String') LIKE '%{0}%'",
                searchQuery);
        }
    }
}
