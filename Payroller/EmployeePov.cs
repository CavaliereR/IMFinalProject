using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Payroller
{
    public partial class EmployeePov : Form
    {
        private readonly string employeeUsername;
        private const string ConnString = "server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;";


        public EmployeePov()
        {
            InitializeComponent();
            employeeUsername = string.Empty;
            Load += EmployeePov_Load;
        }


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

        // Loads ALL employee records into the grid. Should probably work because this was based off from another form I think?????
        private void LoadEmployeeData()
        {
            string connectionString = "server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;";

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Database connection string not set.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {
                MySqlCommand sqlcmd = new MySqlCommand();
                MySqlDataAdapter sqlda = new MySqlDataAdapter();
                DataSet DS = new DataSet();

                try
                {
                    sqlconn.Open();

                    // Query selection

                    sqlcmd.CommandText = "SELECT * FROM employees WHERE Name = @username";
                    sqlcmd.Parameters.AddWithValue("@username", this.employeeUsername ?? string.Empty);


                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Connection = sqlconn;

                    sqlda.SelectCommand = sqlcmd;
                    sqlda.Fill(DS, "tablefetch");

                    dataGridView1.DataSource = DS.Tables["tablefetch"];

                    // Image layout setup
                    if (dataGridView1.Columns.Contains("Photo"))
                    {
                        DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["Photo"];
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        imageColumn.Width = 60;
                        dataGridView1.RowTemplate.Height = 60;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Just link function to button function
        private void button1_Click(object? sender, EventArgs e)
        {
            LoadEmployeeData();
        }



        private void EmployeeLogOut_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void Employee_Pov_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
