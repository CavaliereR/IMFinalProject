using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Payroller
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SearchName = searchName.Text;

            string connectionString = "server=mysql-8e60174-payroll-6c5f.f.aivencloud.com;port=28063;database=employeemanagementdb;uid=avnadmin;pwd=AVNS_oL7eujRP_tyTsVY7OPl;SslMode=Required;";

            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {
                sqlconn.Open();

                string query = "DELETE FROM employees WHERE Name = @Name";
                using (MySqlCommand sqlcmd = new MySqlCommand(query, sqlconn))
                {
                    // Use parameters safely
                    sqlcmd.Parameters.AddWithValue("@Name", SearchName);

                    int rowsAffected = sqlcmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully!", "Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with that name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
