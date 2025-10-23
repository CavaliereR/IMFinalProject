using System;
using System.Windows.Forms;

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

            if (txtUsername.Text == correctUsername && txtPassword.Text == correctPassword)
            {
                MessageBox.Show("Welcome, Administrator.");
                txtPassword.Clear(); // Clear the password field for security
                Menu nextForm = new Menu();
                nextForm.Show();
                this.Close();    
            }
            else
            {
                attempts--;
                if (attempts >0)
                {
                    MessageBox.Show(
                       $"Accsess Denied. You have {attempts} attempts left.",
                       "Accsess Denied",
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
}


