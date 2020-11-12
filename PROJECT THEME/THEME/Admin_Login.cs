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

namespace THEME
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }
        public static string username;
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_email.Text == "" && txt_pass_login.Text == "")
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
            username = txt_email.Text;
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter ad = new SqlDataAdapter("select * from userfrom where username='" + txt_email.Text + "' and password='" + txt_pass_login.Text + "'", obj);
            obj.Open();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Welcome To login");
                Form1 obj2 = new Form1();
                obj2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password ");
            }

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Admin_Registration obj = new Admin_Registration();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txt_email_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)*[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txt_email.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_email, "Pleae Provide Valid Email Address");
            }
        }

    }
}
