using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Payroller
{
    public partial class EmployeeViewer : Form
    {
        private readonly string employeeUsername;

        public EmployeeViewer(string username)
        {
            InitializeComponent();
            employeeUsername = username ?? string.Empty;
        }

        private void EmployeeViewer_Load(object sender, EventArgs e)
        {
            LoadEmployeeRecord();
        }

        private void LoadEmployeeRecord()
        {
            const string connString = "server=192.168.56.1; database=employeemanagementdb; uid=root;";

            try
            {
                using var sqlcon = new MySqlConnection(connString);
                using var cmd = new MySqlCommand("SELECT * FROM employees WHERE username = @username", sqlcon);
                cmd.Parameters.AddWithValue("@username", employeeUsername);
                using var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);

                dataGridViewReadOnly.DataSource = table;
                dataGridViewReadOnly.ReadOnly = true;
                dataGridViewReadOnly.AllowUserToAddRows = false;
                dataGridViewReadOnly.AllowUserToDeleteRows = false;
                dataGridViewReadOnly.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Hide sensitive columns if present
                if (table.Columns.Contains("password"))
                    dataGridViewReadOnly.Columns["password"].Visible = false;

                // Optionally hide credential columns named differently
                if (table.Columns.Contains("passwd"))
                    dataGridViewReadOnly.Columns["passwd"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}