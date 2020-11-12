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

namespace telephone_registion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telephone_ConnectionDataSet.properties' table. You can move, or remove it, as needed.

            fromload();
            
           
        }

        private void fromload()
        {
            SqlConnection obj = new SqlConnection("server=.;database=telephone_Connection;uid=sa;password=123");
            SqlDataAdapter cmd = new SqlDataAdapter("select * from info", obj);
            obj.Open();
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            obj.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infomation();
            fromload();
        }

        private void infomation()
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            info dt = new info()
            {
                @Name = txtbox1.Text,
                @Telephoneno = txtbox2.Text,
                @Address = txtbox3.Text,
                City = txtbox4.Text,
                Mobile = txtbox5.Text,
                @Connection = comboBox1.Text
            };
            obj.infos.InsertOnSubmit(dt);
            obj.SubmitChanges();
             }
    }
}
