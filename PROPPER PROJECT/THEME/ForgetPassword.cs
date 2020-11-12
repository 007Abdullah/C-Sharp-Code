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

namespace THEME
{
    public partial class ForgetPassword : Form
    {
        string Email;
        public ForgetPassword(string Em)
        {
            InitializeComponent();
            Email = Em;
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            if (txt_rpass.Text == txt_pass.Text)
            {
                lbl_err.Text = "";
                SqlConnection con = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
                con.Open();
                SqlCommand com = con.CreateCommand();
                com.CommandText = "update userfrom set [password] = '"+txt_rpass.Text+"' where username='"+txt_email.Text+"'";
                com.ExecuteNonQuery();
            }
            else
            {
                lbl_err.Text = "Not Match";
            }
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            if (Email != "")
            {
                txt_email.Text = Email;
            }
            else
            {
                txt_email.Enabled = true; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Enter Password")
            {
                txt_pass.Text = "";
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Enter Password";
            }
        }

        private void txt_rpass_Enter(object sender, EventArgs e)
        {
            if (txt_rpass.Text == "Re-Enter Password")
            {
                txt_rpass.Text = "";
            }
        }

        private void txt_rpass_Leave(object sender, EventArgs e)
        {
            if (txt_rpass.Text == "")
            {
                txt_rpass.Text = "Re-Enter Password";
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
                txt_pass.UseSystemPasswordChar = false;
                txt_rpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
                txt_rpass.UseSystemPasswordChar = true;
            }
        }
    }
}