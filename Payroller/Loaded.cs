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
    public partial class Loaded : Form
    {
        public Loaded()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn NextForm = new LogIn();
            NextForm.Show();
            this.Hide();
        }
    }
}
