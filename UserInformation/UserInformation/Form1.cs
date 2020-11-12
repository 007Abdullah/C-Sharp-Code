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

namespace UserInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtfather.Text == "" || txtphone.Text == "" || txtaddress.Text == "" || txtemail.Text == "" || txtpasword.Text == "")
            {

                MessageBox.Show("plese fill the feild");

            }
            else 
            {
                SqlConnection obj = new SqlConnection("server=.;database=userinfo;uid=sa;password=123");
                SqlCommand cmd = new SqlCommand("insert into userfom values('" + txtname.Text + "','" + txtfather.Text + "','" + txtphone.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "','" + txtpasword.Text + "')", obj);
                obj.Open();
                cmd.ExecuteNonQuery();
                obj.Close();
                MessageBox.Show("Your Data Has Been Submint");
            }




        }
    }
}