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

        // Parameterless constructor kept for designer support — treat as admin by default
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
                // (btnaddrecord and dataGridView1 are expected to exist in the designer)
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
                // If designer controls are not present yet, ignore safely
            }

            LoadEmployeeData();
        }


        private void LoadEmployeeData()
        {
            // URL Declaration and Instances and Connection
            MySqlConnection sqlcon = new MySqlConnection("server=192.168.56.1; database=employeemanagementdb; uid=root;");
            MySqlCommand sqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlda = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            try
            {
                //SQL Connections
                sqlcon.Open();

                // Query selection: admins see all employees; employees see only their own record
                if (this.isAdmin)
                {
                    sqlcmd.CommandText = "SELECT * FROM employees";
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Connection = sqlcon;
                }
                else
                {
                    sqlcmd.CommandText = "SELECT * FROM employees WHERE username = @username";
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.Parameters.AddWithValue("@username", this.employeeUsername ?? string.Empty);
                }

                //Execute of SQL Command
                sqlda.SelectCommand = sqlcmd;
                sqlda.Fill(DS, "tablefetch");
                sqlcmd.ExecuteNonQuery();

                //Fetch data from database
                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "tablefetch";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close connection
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (refreshTimer != null)
                refreshTimer.Stop();
            base.OnFormClosing(e);
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
    }
}


