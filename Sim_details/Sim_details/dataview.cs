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
    public partial class dataview : Form
    {
        public dataview()
        {
            InitializeComponent();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text ==  "" || txtbox2.Text == "")
            {
                MessageBox.Show("Please Any One Filed Insert");
            }
            else
            {
                SqlConnection obj = new SqlConnection("server=.;database=users;uid=sa;password=123");
                SqlDataAdapter adp = new SqlDataAdapter("select * from sameers where name='"+txtbox1.Text+"'and nic='"+txtbox2.Text+"'", obj);
                obj.Open();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                
                
                
            }
        }

        private void btn_gride(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
