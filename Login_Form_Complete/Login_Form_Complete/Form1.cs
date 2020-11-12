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

namespace Login_Form_Complete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=form;uid=sa;password=123");

            SqlCommand con = new SqlCommand("insert into info values('"+txtuser.Text+"','"+txtpassword.Text+"')",obj);
            obj.Open();
            con.ExecuteNonQuery();
            obj.Close();
           
            MessageBox.Show("row has been insert");
        }
    }
}
