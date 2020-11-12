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
    public partial class Admin_Registration : Form
    {
        public Admin_Registration()
        {
            InitializeComponent();
        }
        public static string name;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (name == "" || txt_Fname.Text == "" || txt_age.Text == "" || txt_email.Text == "" || txt_pass.Text == "")
            {

                MessageBox.Show("Please Fill the Filed");
            }
            else if (!Regex.Match(txt_Name.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid  name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Name.Focus();
                return;
            }
            else if (!Regex.Match(txt_Fname.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // last name was incorrect
                MessageBox.Show("Invalid father name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Fname.Focus();
                return;
            }// end if       
            else if (!Regex.Match(txt_email.Text, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)*[a-zA-Z]{2,9})$").Success)
            {
                MessageBox.Show("Invalid  username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
            }


            else
            {
                name = txt_Name.Text;
                regter();
            }
        }
        public void regter()
        {
            name = txt_email.Text;
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter sd = new SqlDataAdapter("insert into userfrom  values('" + txt_Name.Text + "','" + txt_Fname.Text + "','" + txt_age.Text + "','" + txt_email.Text + "','" + txt_pass.Text + "')", obj);
            obj.Open();
            DataTable dt = new DataTable();
            sd.Fill(dt);
            MessageBox.Show("Your Data Has Been Submit");
            this.Hide();

        }
    }
}
