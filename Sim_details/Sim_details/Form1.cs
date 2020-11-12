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

namespace Sim_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (txtbox1.Text == "" || txtbox2.Text == "" || txtbox3.Text == "" || txtbox4.Text == "" || txtbox5.Text == "" || txtbox6.Text == "" || txtbox7.Text == "")
            {
                MessageBox.Show("Please Fill These Filed");
            }
            else 
            {
                SqlConnection obj = new SqlConnection("server=.;database=users;uid=sa;password=123");
                SqlCommand cmd = new SqlCommand("insert into sameers values('" + txtbox1.Text + "','" + txtbox2.Text + "','" + txtbox3.Text + "','" + txtbox4.Text + "','" + txtbox5.Text + "','" + txtbox6.Text + "','" + txtbox7.Text + "')", obj);
                obj.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Has Been Submit");
                obj.Close();
            }

               
                            
         
               
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataview obj2 = new dataview();
            obj2.Show();
            this.Hide();
        }
    }
}
