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

namespace fingerprint
{
    public partial class Form1 : Form
    {
        private ServiceReference1.UranusCoreClient tng;
        private string SessionKey;
        public Form1()
        {
            InitializeComponent();
            tng = new ServiceReference1.UranusCoreClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var ret = tng.Search();
            SqlConnection obj = new SqlConnection("server=.;database=fingetb;uid=sa;password=123");
            SqlDataAdapter sd = new SqlDataAdapter("insert into info values('"+txtbox1.Text+"','"+txtbox2.Text+"')", obj);
            obj.Open();
            DataTable dt = new DataTable();
            sd.Fill(dt);
            MessageBox.Show("User Add");
            
            if (ret.ResponseCode == ServiceReference1.BFSClientReturnErrorCode.HIT_CONFIRMED)
            {
             
            }
            obj.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ret = tng.CreateSession(new ServiceReference1.AuthRequestInfo());
            if (ret.ResponseCode == ServiceReference1.BFSClientReturnErrorCode.SUCCESS)
            {
                MessageBox.Show("Session Created");
                SessionKey = ret.SessionKey;
            }
            else
            {
                MessageBox.Show(ret.ReturnMessage);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ret = tng.RegisterPerson(SessionKey, txtbox1.Text);
            if (ret.ResponseCode == ServiceReference1.BFSClientReturnErrorCode.SUCCESS)
            {
                MessageBox.Show("Fingerprint Capture");
            }
            else
            {
                MessageBox.Show(ret.ReturnMessage);
            }
        }
    }
}
