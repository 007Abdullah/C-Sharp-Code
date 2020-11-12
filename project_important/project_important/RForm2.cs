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
    public partial class RForm2 : Form
    {
        public RForm2()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "" || txtbox2.Text == "" || txtbox3.Text == "" || txtbox4.Text == "" || txtbox5.Text == "" || txtbox6.Text == "" || txtbox7.Text == "" || txtbox8.Text == "")
            {
                MessageBox.Show("Please Fill All Data");
            }
            else
            {
                SqlConnection obj = new SqlConnection("server=.;database=getup;uid=sa;password=123");
                SqlCommand dt = new SqlCommand("insert into data values('" + txtbox1.Text + "','" + txtbox2.Text + "','" + txtbox3.Text + "','" + txtbox4.Text + "','" + txtbox5.Text + "','" + txtbox6.Text + "','"+txtbox7.Text+"','"+txtbox8.Text+"')", obj);
                obj.Open();
                dt.ExecuteNonQuery();
                obj.Close();
                MessageBox.Show("Data Submit");
            }
        }

        private void RForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
