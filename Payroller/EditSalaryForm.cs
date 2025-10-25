using System;
using System.Windows.Forms;

namespace Payroller
{
    public partial class EditSalaryForm : Form
    {
        public decimal HoursWorked { get; private set; }
        public decimal RatePerHour { get; private set; }
        public int EmployeeId { get; }

        // Keep this file free of Designer declarations; Designer partial defines controls and InitializeComponent.
        public EditSalaryForm(int employeeId, decimal currentHours, decimal currentRate, string employeeName)
        {
            InitializeComponent();
            EmployeeId = employeeId;

            // txtHours and txtRate are defined in EditSalaryForm.Designer.cs
            txtHours.Text = currentHours.ToString("G");
            txtRate.Text = currentRate.ToString("G");

            // Display the employee name in the label added in the designer
            lblEmployeeName.Text = employeeName ?? string.Empty;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtHours.Text.Trim(), out var h))
            {
                MessageBox.Show("Invalid hours value.");
                return;
            }
            if (!decimal.TryParse(txtRate.Text.Trim(), out var r))
            {
                MessageBox.Show("Invalid rate value.");
                return;
            }

            HoursWorked = h;
            RatePerHour = r;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
