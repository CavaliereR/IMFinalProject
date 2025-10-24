using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Payroller
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Passwordscreen_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private int attempts = 4; // Number of allowed attempts

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Credentials
            string correctUsername = "Administrator";
            string correctPassword = "RedTech123";

            // Dummy employee credentials (for testing)
            // Replace/remove these when you have real employee accounts in the DB
            string dummyEmployeeUsername = "employee1";
            string dummyEmployeePassword = "EmpPass123";

            if (txtUsername.Text == correctUsername && txtPassword.Text == correctPassword)
            {
                MessageBox.Show("Welcome, Administrator.");
                txtPassword.Clear(); // Clear the password field for security
                Menu nextForm = new Menu();
                nextForm.Show();
                this.Close();
                return;
            }

            // Check dummy employee credentials first (local test account)
            if (txtUsername.Text == dummyEmployeeUsername && txtPassword.Text == dummyEmployeePassword)
            {
                MessageBox.Show($"Welcome, {dummyEmployeeUsername}.");
                txtPassword.Clear();

                // Open EmployeePov (read-only employee POV)
                EmployeePov employeeForm = new EmployeePov(dummyEmployeeUsername);
                employeeForm.Show();
                this.Close();
                return;
            }

            // Try to authenticate as an employee in the database
            try
            {
                using (var sqlcon = new MySqlConnection("server=192.168.56.1; database=employeemanagementdb; uid=root;"))
                {
                    sqlcon.Open();
                    using (var cmd = new MySqlCommand("SELECT username FROM employees WHERE username = @user AND password = @pass", sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            // Employee authenticated — open EmployeePov (employee-only view)
                            string username = result.ToString();
                            MessageBox.Show($"Welcome, {username}.");
                            txtPassword.Clear();

                            EmployeePov employeeForm = new EmployeePov(username);
                            employeeForm.Show();
                            this.Close();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to authenticate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If neither admin nor employee matched
            attempts--;
            if (attempts > 0)
            {
                MessageBox.Show(
                   $"Access Denied. You have {attempts} attempts left.",
                   "Access Denied",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                txtPassword.Clear(); // Clear the password field for security
            }
            else
            {
                MessageBox.Show("You have been locked out due to too many failed login attempts.");
                btnLogin.Enabled = false;
                Application.Exit();
            }
        }
    }
}


