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
using Telephone_Connection_Systems.Properties;

namespace Telephone_Connection_Systems
{
    public partial class Register : Form
    {
        
        public Register()
        {
            
            InitializeComponent();
        }


        public static string name;
        
        public void button1_Click(object sender, EventArgs e)
        {
             
            if (name == "" || txtbox2.Text == "" || txtbox3.Text == "" || txtbox4.Text == "" || txtbox5.Text == "")
            {
                
                MessageBox.Show("Please Fill the Filed");
            }
            else if (!Regex.Match(txtbox1.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid  name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox1.Focus();
                return;
            }
            else   if (!Regex.Match(txtbox2.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // last name was incorrect
                MessageBox.Show("Invalid father name", "Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtbox2.Focus();
                return;
            }// end if       
            else if (!Regex.Match(txtbox4.Text, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)*[a-zA-Z]{2,9})$").Success)
            {
                MessageBox.Show("Invalid  username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox4.Focus();
            }
                
            
            else
            {
                    name = txtbox1.Text;
                    regter();
            }
        }

        public void regter()
        {
            name = txtbox1.Text;
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter sd = new SqlDataAdapter("insert into userfrom  values('" + txtbox1.Text + "','" + txtbox2.Text + "','" + txtbox3.Text + "','" + txtbox4.Text + "','" + txtbox5.Text + "')", obj);
            obj.Open();
            DataTable dt = new DataTable();
            sd.Fill(dt);
            MessageBox.Show("Your Data Has Been Submit");
            this.Hide();

        }

        public void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void txtbox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


    }
}


