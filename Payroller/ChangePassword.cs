using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroller
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtEnterUsername.Text.Trim();
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;";

            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {
                try
                {
                    sqlconn.Open();

                    // Step 1: Check if username and old password match
                    string checkQuery = "SELECT COUNT(*) FROM employees WHERE Name = @Name AND Password = @OldPassword";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, sqlconn))
                    {
                        checkCmd.Parameters.AddWithValue("@Name", username);
                        checkCmd.Parameters.AddWithValue("@OldPassword", oldPassword);

                        int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userExists == 0)
                        {
                            MessageBox.Show("Old password is incorrect or username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Step 2: Update password
                    string updateQuery = "UPDATE employees SET Password = @NewPassword WHERE Name = @Name";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, sqlconn))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@Name", username);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtOldPassword.Clear();
                            txtNewPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to change password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn nextForm = new LogIn();
            nextForm.Show();
            this.Close();
        }
    }
}

