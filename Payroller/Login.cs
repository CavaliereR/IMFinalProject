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
            string correctUsername = "Administrator";
            string correctPassword = "RedTech123";
            int attempts = 4;

            // ADMIN LOGIN
            if (txtUsername.Text == correctUsername && txtPassword.Text == correctPassword)
            {
                MessageBox.Show("Welcome, Administrator.");
                txtPassword.Clear();
                Menu nextForm = new Menu();
                nextForm.Show();
                this.Close();
                return;
            }

            // EMPLOYEE LOGIN (check database)
            try
            {
                using (var sqlcon = new MySqlConnection("server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;"))
                {
                    sqlcon.Open();

                    string query = "SELECT Name FROM employees WHERE Username = @user AND Password = @pass";
                    using (var cmd = new MySqlCommand(query, sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string employeeName = result.ToString();
                            MessageBox.Show($"Welcome, {employeeName}.");

                            txtPassword.Clear();

                            // Open employee POV window
                            EmployeePov employeeForm = new EmployeePov(employeeName);
                            employeeForm.Show();
                            this.Close();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to authenticate: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // LOGIN FAIL
            attempts--;
            if (attempts > 0)
            {
                MessageBox.Show($"Access Denied. You have {attempts} attempts left.",
                                 "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("You have been locked out due to too many failed login attempts.");
                btnLogin.Enabled = false;
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword nextForm = new ChangePassword();
            nextForm.Show();
            this.Hide();
        }



        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

    }
}


