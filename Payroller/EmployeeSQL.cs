using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;

namespace Payroller
{
    public partial class EmployeeSQL : Form
    {
        private System.Windows.Forms.Timer refreshTimer;

        public EmployeeSQL()
        {
            InitializeComponent();
        }

        private void EmployeeSQL_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }


        private void LoadEmployeeData()
        {
            // URL Declaration and Instances and Connection
            MySqlConnection sqlcon = new MySqlConnection("server=192.168.56.1; database=employeemanagementdb; uid=root;");
            MySqlCommand sqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlda = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //SQL Connections
            sqlcon.Open();

            //Query Request
            sqlcmd.CommandText = "SELECT * FROM employees";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;


            //Execute of SQL Command
            sqlda.SelectCommand = sqlcmd;
            sqlda.Fill(DS, "tablefetch");
            sqlcmd.ExecuteNonQuery();

            //Fetch data from databse
            dataGridView1.DataSource = DS;
            dataGridView1.DataMember = "tablefetch";

            //close connection
            sqlcon.Close();

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (refreshTimer != null)
                refreshTimer.Stop();
            base.OnFormClosing(e);
        }

        private void btnaddrecord_Click(object sender, EventArgs e)
        {
            AddRecords addRecordsForm = new AddRecords();
            addRecordsForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
    }
}

