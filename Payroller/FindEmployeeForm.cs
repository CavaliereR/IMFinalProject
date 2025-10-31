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

        // Caller reads this after DialogResult == OK
        public string EmployeeName => txtName?.Text.Trim() ?? string.Empty;

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            EditSalaryForm EditSalaryForm = new EditSalaryForm();
            EditSalaryForm.Show();
            DialogResult = DialogResult.OK;
            Close();
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
