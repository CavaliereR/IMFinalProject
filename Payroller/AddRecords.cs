﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Payroller
{
    public partial class AddRecords : Form
    {
        public AddRecords()
        {
            InitializeComponent();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone_num = txtPhoneNumber.Text.Trim();

            // Basic phone number validation (Philippine format)
            if (!(phone_num.StartsWith("+63") || phone_num.StartsWith("09")))
            {
                MessageBox.Show("Invalid phone number format. It should start with +63 or 09.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phone_num.Length < 10 || phone_num.Length > 13)
            {
                MessageBox.Show("Phone number must be between 10 and 13 digits (including +63).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill out all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aiven connection string
            string connectionString = "server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;";
            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {
                try
                {
                    sqlconn.Open();

                    string query = "INSERT INTO employees (Name, Email, PhoneNumber, HoursWorked, Rate_Per_Hour, Photo) " +
                                   "VALUES (@Name, @Email, @PhoneNumber, 0, 0, @Photo)";


                    using (MySqlCommand sqlcmd = new MySqlCommand(query, sqlconn))
                    {
                        sqlcmd.Parameters.AddWithValue("@Photo", (object)imageBytes ?? DBNull.Value);
                        sqlcmd.Parameters.AddWithValue("@Name", name);
                        sqlcmd.Parameters.AddWithValue("@Email", email);
                        sqlcmd.Parameters.AddWithValue("@PhoneNumber", phone_num);

                        sqlcmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("New employee record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] imageBytes = null;
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
                ofd.Title = "Select Employee Photo";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Display Preview of selected image
                    picEmployeePhoto.Image = Image.FromFile(ofd.FileName);

                    // Convert image to byte array for database storage
                    imageBytes = System.IO.File.ReadAllBytes(ofd.FileName);
                }
            }
        }
    }
}
