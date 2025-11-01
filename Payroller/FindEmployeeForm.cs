using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Payroller
{
    public partial class FindEmployeeForm : Form
    {
        public FindEmployeeForm()
        {
            InitializeComponent();
        }

        public string EmployeeName => txtName?.Text.Trim() ?? string.Empty;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = "server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;";
            int employeeId = -1;
            decimal hoursWorked = 0;
            decimal ratePerHour = 0;

            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT EmployeeID, HoursWorked, Rate_Per_Hour FROM employees WHERE Name = @name LIMIT 1";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                employeeId = Convert.ToInt32(reader["EmployeeID"]);
                                hoursWorked = reader.GetDecimal(reader.GetOrdinal("HoursWorked"));
                                ratePerHour = reader.GetDecimal(reader.GetOrdinal("Rate_Per_Hour"));
                            }
                            else
                            {
                                MessageBox.Show("Employee not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                }

                // Pass retrieved info into EditSalaryForm
                EditSalaryForm editForm = new EditSalaryForm(employeeId, hoursWorked, ratePerHour, txtName.Text.Trim());
                editForm.Show();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding employee: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Menu nextForm = new Menu();
            nextForm.Show();
            Close();
        }
    }
}
