using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Payroller
{
    public partial class Rating : Form
    {
        // Static container for logging employee records
        public static List<EmployeeRecord> EmployeeLog = new List<EmployeeRecord>();

        // Array to store employee names (resize as needed)
        private string[] employeeNames = new string[100];
        private int employeeCount = 0;

        public Rating()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EmployeeLog.Clear();
            employeeCount = 0;
            Array.Clear(employeeNames, 0, employeeNames.Length);
            cmbPerformanceRating.Items.Clear();
            cmbPerformanceRating.Items.AddRange(new string[] { "Excellent", "Good", "Average", "Poor" });
            if (cmbPerformanceRating.Items.Count > 0)
                cmbPerformanceRating.SelectedIndex = 0;
            lstEmployeeRecords.Items.Clear();
        }

        private void btnFInish_Click(object sender, EventArgs e)
        {

        }

        private decimal GetSalaryIncrease(string rating)
        {
            return rating switch
            {
                "Excellent" => 1000m,
                "Good" => 500m,
                "Average" => 200m,
                "Poor" => 0m,
                _ => 0m
            };
        }

        private void lstEmployeeRecords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFInish_Click_1(object sender, EventArgs e)
        {
            string name = txtEmployeeName.Text.Trim();
            string number = txtEmployeeNumber.Text.Trim();
            string rating = cmbPerformanceRating.SelectedItem.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            decimal increase = GetSalaryIncrease(rating);

            EmployeeLog.Add(new EmployeeRecord
            {
                Name = name,
                Number = number,
                Rating = rating,
                SalaryIncrease = increase
            });


            if (employeeCount < employeeNames.Length)
            {
                employeeNames[employeeCount] = name;
                employeeCount++;
            }
            else
            {
                MessageBox.Show("Employee name array is full.");
            }


            lstEmployeeRecords.Items.Clear();
            foreach (var record in EmployeeLog)
            {
                lstEmployeeRecords.Items.Add($"{record.Name} | {record.Number} | {record.Rating} | {record.SalaryIncrease:C}");
            }

            MessageBox.Show($"Logged: {name}, {number}, {rating}, Increase: {increase:C}");
            txtEmployeeName.Clear();
            txtEmployeeNumber.Clear();
            cmbPerformanceRating.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
