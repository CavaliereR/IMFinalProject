using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Payroller
{
    public partial class EmployeePov : Form
    {
        private readonly string employeeUsername;
        private const string ConnString = "server=192.168.56.1; database=employeemanagementdb; uid=root;";

        // Designer support constructor - keeps designer working
        public EmployeePov()
        {
            InitializeComponent();
            employeeUsername = string.Empty;
            Load += EmployeePov_Load;
        }

        // Runtime constructor kept for compatibility but username is not used anymore
        public EmployeePov(string username)
        {
            InitializeComponent();
            employeeUsername = username ?? string.Empty;
            Load += EmployeePov_Load;
        }

        private void EmployeePov_Load(object? sender, EventArgs e)
        {
            // Configure grid for read-only viewing
            try
            {
                if (dataGridView1 != null)
                {
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch
            {
                // ignore designer-time issues
            }

            LoadEmployeeData();
        }

        // Loads ALL employee records into the grid
        private void LoadEmployeeData()
        {
            try
            {
                using var con = new MySqlConnection(ConnString);
                using var cmd = new MySqlCommand("SELECT * FROM employees", con);
                using var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                // Hide common credential columns if present
                if (table.Columns.Contains("password") && dataGridView1.Columns.Contains("password"))
                    dataGridView1.Columns["password"].Visible = false;
                if (table.Columns.Contains("passwd") && dataGridView1.Columns.Contains("passwd"))
                    dataGridView1.Columns["passwd"].Visible = false;
                if (table.Columns.Contains("PasswordHash") && dataGridView1.Columns.Contains("PasswordHash"))
                    dataGridView1.Columns["PasswordHash"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // wired by designer: EmployeeRefresh.Click -> button1_Click
        private void button1_Click(object? sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        // wired by designer: EmployeeBack2Menu.Click -> EmployeeBack2Menu_Click
        private void EmployeeBack2Menu_Click(object? sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();
            Close();
        }
    }
}
