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
                Message2 m2 = new Message2();
                m2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password ");
            }

        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            Admin_Registration admnreg = new Admin_Registration();
            admnreg.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txt_pass_login.Text == "Password")
            {
                txt_pass_login.Text = "";
                ShowPassword();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txt_pass_login.Text == "")
            {
                txt_pass_login.Text = "Password";
                ShowPassword();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void ShowPassword()
        {
            if (checkBox1.Checked)
            {
                txt_pass_login.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass_login.UseSystemPasswordChar = true;
            }
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle,4000, WinAPI.HOR_POSITIVE);
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
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txt_email.Text == "")
            {
                Message3 m3 = new Message3();
                m3.Show();
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
                con.Open();
                SqlCommand com = new SqlCommand("select username from userfrom where username == '"+txt_email.Text+"'", con);
                con.Close();
                ForgetPassword fp = new ForgetPassword(txt_email.Text);
                fp.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
