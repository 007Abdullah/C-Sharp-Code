using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Connection_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string username;
        private void btnlogin_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtbox1.Text == "" && txtbox2.Text == "")
                {
                    MessageBox.Show("Please Fill This Textbox");
                }
                else
                {
                    login();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }

        private void login()
        {
            username = txtbox1.Text;
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter ad = new SqlDataAdapter("select * from userfrom where username='" + txtbox1.Text + "' and password='" + txtbox2.Text + "'", obj);
            obj.Open();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Welcome To login");
                User_Connection_detail obj2 = new User_Connection_detail();
                obj2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password ");
            }

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.Show();
            this.Hide();
        }

        private void txtbox1_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)*[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtbox1.Text, pattern))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.txtbox1, "Pleae Provide Valid Email Address");
            }
        }

      
    }
}