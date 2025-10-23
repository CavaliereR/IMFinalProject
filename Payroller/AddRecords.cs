using System;
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

            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone_num = txtPhoneNumber.Text;
            int salary = Convert.ToInt32(txtSalary.Text);

            //Declare URL
            MySqlConnection sqlconn = new MySqlConnection("server=LOCALHOST; database=employeemanagementdb; uid=root;");
            MySqlCommand sqlcmd = new MySqlCommand();

            //Setup connection
            sqlconn.Open();


            //Query Request
            sqlcmd.CommandText = $"INSERT INTO employees (Name, Email, PhoneNumber, Salary" +
                $")values('{name}', '{email}', '{phone_num}', '{salary}')";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconn;


            //SQL command execution
            sqlcmd.ExecuteNonQuery();

            //Close connection
            sqlconn.Close();

            MessageBox.Show("Record Added Successfully!", "Record saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    } }
