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

namespace user_details
{
    public partial class registr : Form
    {
        public registr()
        {
            InitializeComponent();
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            SqlConnection obj1 = new SqlConnection("server=.;database=uset;uid=sa;password=123");
            SqlCommand cmd = new SqlCommand("insert into sameer values('"+txtbox1.Text+"','"+txtbox2.Text+"','"+txtbox3.Text+"','"+txtbox4.Text+"')",obj1);
            obj1.Open();
            cmd.ExecuteNonQuery();
           
            MessageBox.Show("Registion Has Been Complete");
            obj1.Close();
        }
    }
}
