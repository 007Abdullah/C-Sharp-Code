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
    public partial class UForm2 : Form
    {
        public UForm2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                   
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=getup;uid=sa;password=123;");
            SqlDataAdapter adp = new SqlDataAdapter("select * from data where username='"+textBox1.Text+"'", con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //private void fillgrid()
        //{
        //    newmethod();
        //}
        //private void NewMethod()
        //{
        //    SqlConnection con = new SqlConnection("server=.;database=getup;uid=sa;password=123;");
        //    SqlDataAdapter adp = new SqlDataAdapter("select * from  data", con);
        //    con.Open();
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                MessageBox.Show("PLease Enter Email");
            }
            else
            {
                SqlConnection con1 = new SqlConnection("server=.;database=getup;uid=sa;password=123;");
                SqlDataAdapter adb = new  SqlDataAdapter("select id,username,pasword,name,fname,addres,gender,phoneno,nic from data where username='" + textBox1.Text+ "'", con1);
                DataTable dh = new DataTable();
                con1.Open();
                adb.Fill(dh);
                dataGridView1.DataSource = dh;
                
            }
         
            
        }
        //private void UForm2_Load(object sender, EventArgs e)
        //{
        //    fillgrid();
        //}

        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtbox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtbox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtbox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtbox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtbox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtbox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtbox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
           
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=getup;uid=sa;password=123;");
            SqlDataAdapter dt = new SqlDataAdapter("Update data set username = '"+txtbox1.Text+"', pasword = '"+txtbox2.Text+"', name = '"+txtbox3.Text+"', fname = '"+txtbox4.Text+"',addres='"+txtbox5.Text+"',gender='"+txtbox6.Text+"',phoneno='"+txtbox7.Text+"',nic='"+txtbox8.Text+"' where id = '"+txtid.Text+"'",con);
            con.Open();
            DataTable obj = new DataTable();
            dt.Fill(obj);
            con.Close();
            MessageBox.Show("YOur Pagal wala data update");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=getup;uid=sa;password=123;");
            SqlDataAdapter dt = new SqlDataAdapter("Delete  from data where id = '" + txtid.Text + "'", con);
            con.Open();
            DataTable obj = new DataTable();
            dt.Fill(obj);
            con.Close();
            MessageBox.Show("Your Data Delete");
        }

       
    }
}