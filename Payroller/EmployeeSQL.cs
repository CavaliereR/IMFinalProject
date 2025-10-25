using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Payroller
{
    public partial class EmployeeSQL : Form
    {
        // removed unused refreshTimer
        private readonly bool isAdmin;
        private readonly string? employeeUsername;

        // Parameterless constructor kept for designer support — treat as admin by default
        public EmployeeSQL()
        {
            InitializeComponent();
            this.isAdmin = true;
            this.employeeUsername = null;
        }

        // Use this constructor to control admin vs employee mode
        public EmployeeSQL(bool isAdmin, string username)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.employeeUsername = username;
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

                // If there is an edit button on the designer, only enable it for admins
                if (btnEditSalary != null)
                    btnEditSalary.Visible = this.isAdmin;
            }
            catch
            {
                // If designer controls are not present yet, ignore safely
            }

            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            // Get connection from database
            string connectionString = "server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;";

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Database connection string not set.\nPlease configure PAYROLLER_DB_CONN environment variable.",
                                "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open connection safely using 'using' block.
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

                    dataGridView1.DataSource = DS;
                    dataGridView1.DataMember = "tablefetch";
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

        /// <summary>
        /// Edit hours worked and rate per hour for an employee.
        /// Uses selected DataGridView row if present; otherwise prompts for name and looks up the record.
        /// </summary>
        private void btnEditSalary_Click(object sender, EventArgs e)
        {
            if (!this.isAdmin)
            {
                MessageBox.Show("You do not have permission to edit records.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;";

            int employeeId = -1;
            decimal currentHours = 0m;
            decimal currentRate = 0m;
            string employeeName = "";

            // Prefer selected row from the grid
            if (dataGridView1 != null && dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                // Try common column names, fall back to first cell
                object? idVal = row.Cells["EmployeeID"]?.Value ?? row.Cells["EmployeeId"]?.Value ?? row.Cells[0]?.Value;
                if (idVal != null && int.TryParse(idVal.ToString(), out int parsedId))
                    employeeId = parsedId;

                if (row.Cells["HoursWorked"]?.Value != null)
                    decimal.TryParse(row.Cells["HoursWorked"].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out currentHours);

                if (row.Cells["Rate_Per_Hour"]?.Value != null)
                    decimal.TryParse(row.Cells["Rate_Per_Hour"].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out currentRate);

                if (row.Cells["Name"]?.Value != null)
                    employeeName = row.Cells["Name"].Value.ToString() ?? "";
            }
            else
            {
                // No row selected — show the designer-backed FindEmployeeForm instead of InputBox
                using (var finder = new FindEmployeeForm())
                {
                    if (finder.ShowDialog(this) != DialogResult.OK)
                        return; // user cancelled

                    string name = finder.EmployeeName;
                    if (string.IsNullOrWhiteSpace(name))
                        return;

                    try
                    {
                        using var conn = new MySqlConnection(connectionString);
                        conn.Open();
                        using var cmd = new MySqlCommand("SELECT EmployeeID, HoursWorked, Rate_Per_Hour, Name FROM employees WHERE Name = @name LIMIT 1", conn);
                        cmd.Parameters.AddWithValue("@name", name);
                        using var rdr = cmd.ExecuteReader();
                        if (!rdr.Read())
                        {
                            MessageBox.Show("Employee with that name was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (rdr["EmployeeID"] != DBNull.Value)
                            employeeId = Convert.ToInt32(rdr["EmployeeID"]);
                        if (rdr["HoursWorked"] != DBNull.Value)
                            currentHours = Convert.ToDecimal(rdr["HoursWorked"]);
                        if (rdr["Rate_Per_Hour"] != DBNull.Value)
                            currentRate = Convert.ToDecimal(rdr["Rate_Per_Hour"]);
                        if (rdr["Name"] != DBNull.Value)
                            employeeName = rdr["Name"].ToString() ?? "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while looking up employee: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (employeeId <= 0)
            {
                MessageBox.Show("Could not determine EmployeeID for the selected/entered employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show edit dialog (EditSalaryForm must be the Designer-backed form with txtHours/txtRate)
            using (var dlg = new EditSalaryForm(employeeId, currentHours, currentRate, employeeName))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        using var conn = new MySqlConnection(connectionString);
                        conn.Open();
                        using var updateCmd = new MySqlCommand(
                            "UPDATE employees SET HoursWorked = @hours, Rate_Per_Hour = @rate WHERE EmployeeID = @id", conn);
                        updateCmd.Parameters.AddWithValue("@hours", dlg.HoursWorked);
                        updateCmd.Parameters.AddWithValue("@rate", dlg.RatePerHour);
                        updateCmd.Parameters.AddWithValue("@id", dlg.EmployeeId);

                        int rows = updateCmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show($"Updated {rows} record(s).", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Verify the record and try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while updating employee: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}


