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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeSQL nextForm = new EmployeeSQL();
            nextForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rating nextForm = new Rating();
            nextForm.Show();
            this.Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

            LogIn nextForm = new LogIn();
            nextForm.Show();
            this.Hide();
        }

        private void salary_manager_Click(object sender, EventArgs e)
        {
            FindEmployeeForm nextForm = new FindEmployeeForm();
            nextForm.Show();
            this.Close();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
