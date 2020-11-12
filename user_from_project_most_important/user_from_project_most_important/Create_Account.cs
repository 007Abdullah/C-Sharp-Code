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

namespace user_from_project_most_important
{
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=reg;uid=sa;password=123");
            SqlCommand cmd = new SqlCommand("insert into usr values('"+txtbox1.Text+"','"+txtbox2.Text+"','"+txtbox3.Text+"','"+txtbox4.Text+"')",obj);
            obj.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("register complete");
        }
    }
}
