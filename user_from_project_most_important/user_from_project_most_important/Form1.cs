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

namespace user_from_project_most_important
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create_Account obj = new Create_Account();
            obj.Show();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("server=.;database=reg;uid=sa;password=123");
           //  SqlCommand cmd = new SqlCommand("select name,passwod from usr where name='"+txtbox1.Text+"' and password='"+txtbox2.Text+"'",con);
             con.Open();
            DataTable obj = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select name,passwod from usr where name='"+txtbox1.Text+"' and passwod='"+txtbox2.Text+"'",con);
            dt.Fill(obj);
            if (obj.Rows.Count>0)
            {
                MessageBox.Show("Login Done");
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
            con.Close();
        }
    }
}
