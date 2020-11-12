using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            registr obj = new registr();
            obj.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection obj2 = new SqlConnection("server=.;database=uset;uid=sa;password=123");
            obj2.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dts = new SqlDataAdapter("select username,pass from sameer where username='"+txtbox1.Text+"'and pass='"+txtbox2.Text+"'",obj2);
            dts.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Done");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
            obj2.Close();
        }
    }
}
