using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Payroller
{
    public partial class EmployeeSQL : Form
    {
        private System.Windows.Forms.Timer refreshTimer;
        private readonly bool isAdmin;
        private readonly string employeeUsername;

        // Parameterless constructor kept for designer support treat as admin by default
        public EmployeeSQL()
        {
            InitializeComponent();
            this.isAdmin = true;
            this.employeeUsername = null;
        }

        // Use this constructor to control admin vs employee mode
        public EmployeeSQL(bool isAdmin, string employeeUsername)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.employeeUsername = employeeUsername;
        }

        private void EmployeeSQL_Load(object sender, EventArgs e)
        {
            // Disable editing and hide add button for non-admin users
            try
            {
                // Preserve designer-created controls by checking for null
                if (btnaddrecord != null)
                    btnaddrecord.Visible = this.isAdmin;

                if (dataGridView1 != null)
                {
                    dataGridView1.ReadOnly = !this.isAdmin;
                    // prevent adding rows in the grid for non-admins
                    dataGridView1.AllowUserToAddRows = this.isAdmin;
                    dataGridView1.AllowUserToDeleteRows = this.isAdmin;
                }
            }
            catch
            {

            }

            LoadEmployeeData();
        }


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
                    if (this.isAdmin)
                    {
                        sqlcmd.CommandText = "SELECT * FROM employees";
                    }
                    else
                    {
                        sqlcmd.CommandText = "SELECT * FROM employees WHERE username = @username";
                        sqlcmd.Parameters.AddWithValue("@username", this.employeeUsername ?? string.Empty);
                    }

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



        private void btnmenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }



        private void btnaddrecord_Click(object sender, EventArgs e)
        {

            if (!this.isAdmin)
            {
                MessageBox.Show("You do not have permission to add records.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddRecords addRecordsForm = new AddRecords();
            addRecordsForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void btndelrecord_Click(object sender, EventArgs e)
        {
            DeleteForm DeleteForm = new DeleteForm();
            DeleteForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


