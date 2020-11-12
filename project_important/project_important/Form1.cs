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

namespace project_important
{
    public partial class Form1 : Form
    {
        public string a;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            a = txtbox1.Text;
            SqlConnection obj = new SqlConnection("server=.;database=getup;uid=sa;password=123");
            obj.Open();
            SqlDataAdapter dt = new SqlDataAdapter("select username,pasword from data where username='"+txtbox1.Text+"' and pasword='"+txtbox2.Text+"'",obj);
            DataTable obj1 = new DataTable();
            dt.Fill(obj1);            
            obj.Close();
            if (obj1.Rows.Count > 0)
            {
                MessageBox.Show("Welcome To Login");
                UForm2 obj3 = new UForm2();
                obj3.Show();
            }           
            else
            {

                MessageBox.Show("invald data");
            }

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            RForm2 obj = new RForm2();
            obj.Show();
            this.Hide();

        }

        private void btnmodifiy_Click(object sender, EventArgs e)
        {
            
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
