using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            fromload();
         
        }

        private void fromload()
        {
            SqlConnection obj = new SqlConnection("server=.;database=Companydata;uid=sa;password=123");
            SqlDataAdapter sd = new SqlDataAdapter("select * from record", obj);
            obj.Open();
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            obj.Close();
         

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtbox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtbox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtbox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            SqlConnection obj = new SqlConnection("server=.;database=Companydata;uid=sa;password=123");
            SqlCommand sd = new SqlCommand("insert into record values('"+txtbox1.Text+"','" + txtbox2.Text + "','" + txtbox3.Text + "','" + txtbox4.Text + "','" + txtbox5.Text + "')", obj);
            obj.Open();
            sd.ExecuteNonQuery();
            dataGridView1.DataSource = sd;
            MessageBox.Show("YOur Data Has Been Insert");
            fromload();
            obj.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            SqlConnection obj = new SqlConnection("server=.;database=Companydata;uid=sa;password=123");
            SqlDataAdapter db = new SqlDataAdapter("update record set name = '" + txtbox2.Text + "',fname ='" + txtbox3.Text + "',salary='" + txtbox4.Text + "',cnic='" + txtbox5.Text + "' where id = '" + txtbox1.Text + "'", obj);
            obj.Open();
            DataTable dt = new DataTable();
            db.Fill(dt);
            dataGridView1.DataSource = dt;

            MessageBox.Show("Your Data Update");
            fromload();
            obj.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=Companydata;uid=sa;password=123");
            SqlCommand sd = new SqlCommand("delete from record where id='"+txtbox1.Text+"'",obj);
            obj.Open();
            sd.ExecuteNonQuery();
            dataGridView1.DataSource = sd;
            MessageBox.Show("Your Data Has been Delet");
            fromload();
            obj.Close();

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=Companydata;uid=sa;password=123");
            SqlDataAdapter db = new SqlDataAdapter("select * from record where name like '%"+txtsearch.Text+"%'",obj);
            obj.Open();
            DataTable dt = new DataTable();
            db.Fill(dt);
            dataGridView1.DataSource = dt;
            obj.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            update();
        }

        

      

    }
}
