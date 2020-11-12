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

namespace one_from_to_another_from_message_show
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=userfrom;uid=sa;password=123");
            SqlDataAdapter obj1 = new SqlDataAdapter("select username,password from logn where username='"+txtbox1.Text+"' and password='"+txtbox2.Text+"'",obj);
            obj.Open();
            DataTable dt = new DataTable();
            obj1.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Done");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
          
           
        }
    }
}
