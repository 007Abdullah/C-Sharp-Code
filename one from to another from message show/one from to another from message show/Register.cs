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

namespace one_from_to_another_from_message_show
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=userfrom;uid=sa;password=123");
            SqlDataAdapter dt = new SqlDataAdapter("insert into logn values('"+txtbox1.Text+"','"+txtbox2.Text+"','"+txtbox3.Text+"','"+txtbox4.Text+"','"+txtbox5.Text+"')",obj);
            obj.Open();
            DataTable db = new DataTable();
            dt.Fill(db);
            MessageBox.Show("Your Data Has Been Submit");
            obj.Close();
            this.Hide();

        }
    }
}
