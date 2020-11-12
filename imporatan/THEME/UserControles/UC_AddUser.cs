using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace THEME.UserControles
{
    public partial class UC_AddUser : UserControl
    {
        public UC_AddUser()
        {
            InitializeComponent();
        }
        private void UC_AddUser_Load(object sender, EventArgs e)
        {
            label1.Text = "welcome " + Form1.username;
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                txtempty();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void txtempty()
        {
            if (txt_uname_user.Text == "" || txt_tphone_user.Text == "" || txt_address_user.Text == "" || txt_ciyt_user.Text == "" || comboBox1.Text == "" || cmbox_typcon_user.Text == "")
            {
                MessageBox.Show("Invalid Feilds");
            }
            else if (!Regex.Match(txt_uname_user.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_uname_user.Focus();
                return;

            }

            // end if 

            else if (!Regex.Match(txt_ciyt_user.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                // city was incorrect
                MessageBox.Show("Invalid city", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ciyt_user.Focus();
                return;
            }// end if 
            else
            {
                information();



            }
        }
        private void information()
        {
            SqlConnection obj2 = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            DataClasses1DataContext obj = new DataClasses1DataContext();
            SqlDataAdapter sd = new SqlDataAdapter("select * from infoation where TelephoneNO='" + txt_tphone_user.Text + "'", obj2);
           infoation obj1 = new infoation()
            {
               na  
            };
        }

       
    }
}