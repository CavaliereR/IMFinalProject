using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Payroller
{
    public partial class EditSalaryForm : Form
    {
        public decimal HoursWorked { get; private set; }
        public decimal RatePerHour { get; private set; }
        public int EmployeeId { get; }

        // Constructor used when selecting employee directly
        public EditSalaryForm(int employeeId, decimal currentHours, decimal currentRate, string employeeName)
        {
            InitializeComponent();
            EmployeeId = employeeId;
            txtHours.Text = currentHours.ToString("G");
            txtRate.Text = currentRate.ToString("G");
            lblEmployeeName.Text = employeeName ?? string.Empty;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtHours.Text.Trim(), out var h))
            {
                MessageBox.Show("Invalid hours value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtRate.Text.Trim(), out var r))
            {
                MessageBox.Show("Invalid rate value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HoursWorked = h;
            RatePerHour = r;

            // SQL update logic goes here
            string connStr = "server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;";

            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "UPDATE employees SET HoursWorked = @hours, Rate_Per_Hour = @rate WHERE EmployeeID = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@hours", HoursWorked);
                        cmd.Parameters.AddWithValue("@rate", RatePerHour);
                        cmd.Parameters.AddWithValue("@id", EmployeeId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Employee salary details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No employee record was updated. Please check the Employee ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                DialogResult = DialogResult.OK;
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindEmployeeForm findEmployeeForm = new FindEmployeeForm();
            findEmployeeForm.Show();
            this.Close();
        }
    }
}

