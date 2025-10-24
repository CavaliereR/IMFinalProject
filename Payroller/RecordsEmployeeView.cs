using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Payroller
{
    public partial class RecordsEmployeeView : Form
    {
        private readonly string employeeUsername;
        public RecordsEmployeeView(string username)
        {
            InitializeComponent();
            employeeUsername = username ?? string.Empty;
        }

        private void RecordsEmployeeView_Load(object sender, EventArgs e)
        {
            LoadEmployeeRecord();
        }

        private void LoadEmployeeRecord()
        {
            const string connString = "server=192.168.56.1; database=employeemanagementdb; uid=root;";

            try
            {
                using var con = new MySqlConnection(connString);
                using var cmd = new MySqlCommand(
                    "SELECT Name, Number, Rating, SalaryIncrease FROM employees WHERE username = @username LIMIT 1",
                    con);
                cmd.Parameters.AddWithValue("@username", employeeUsername);
                con.Open();

                using var rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    // Map DB fields to the EmployeeRecord model
                    var record = new EmployeeRecord
                    {
                        Name = rdr["Name"]?.ToString() ?? string.Empty,
                        Number = rdr["Number"]?.ToString() ?? string.Empty,
                        Rating = rdr["Rating"]?.ToString() ?? string.Empty,
                        SalaryIncrease = rdr["SalaryIncrease"] != DBNull.Value
                            ? Convert.ToDecimal(rdr["SalaryIncrease"])
                            : 0m
                    };

                    // Populate read-only UI
                    txtName.Text = record.Name;
                    txtNumber.Text = record.Number;
                    txtRating.Text = record.Rating;
                    txtSalaryIncrease.Text = record.SalaryIncrease.ToString("F2");
                }
                else
                {
                    MessageBox.Show("No record found for the current user.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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