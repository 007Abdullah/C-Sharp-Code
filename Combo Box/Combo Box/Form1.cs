using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Combo_Box
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comboxDataSet.batch' table. You can move, or remove it, as needed.
            this.batchTableAdapter.Fill(this.comboxDataSet.batch);
           
            this.teacherTableAdapter.Fill(this.comboxDataSet.teacher);
        }
        //private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    SqlConnection obj = new SqlConnection("server=.;database=combox;uid=sa;password=123");
        //    SqlDataAdapter da = new SqlDataAdapter("select * from teacher where tname='" + comboBox1.Text + "'", obj);
        //    obj.Open();
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    obj.Close();
        //}

        //private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    SqlConnection obj = new SqlConnection("server=.;database=combox;uid=sa;password=123");
        //    SqlDataAdapter da = new SqlDataAdapter("select teacher.tname,batch.bcode,student.sname from batch join teacher on teacher.tid=batch.tech_id join student on batch.bid=student.batch_id where bcode='"+comboBox2.Text+"'" , obj);
        //    obj.Open();
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    obj.Close();
        //}

        private void btnSumit_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sir Talha" && comboBox2.Text == "1071644")
            {
                SqlConnection obj = new SqlConnection("server=.;database=combox;uid=sa;password=123");
                SqlDataAdapter da = new SqlDataAdapter("select teacher.tname,batch.bcode,student.sname from batch join teacher on teacher.tid=batch.tech_id join student on batch.bid=student.batch_id where tname = 'Sir Talha' and bcode = '1071644'", obj);
                obj.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                obj.Close();
            }
            else if (comboBox1.Text == "Sir Taimoor" && comboBox2.Text == "107417")
            {
                SqlConnection obj = new SqlConnection("server=.;database=combox;uid=sa;password=123");
                SqlDataAdapter da = new SqlDataAdapter("select teacher.tname,batch.bcode,student.sname from batch join teacher on teacher.tid=batch.tech_id join student on batch.bid=student.batch_id where tname = 'Sir Taimoor' and bcode = '107417'", obj);
                obj.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                obj.Close();
            }
            else if (comboBox1.Text == "Sir Salman" && comboBox2.Text == "1071")
            {
                SqlConnection obj = new SqlConnection("server=.;database=combox;uid=sa;password=123");
                SqlDataAdapter da = new SqlDataAdapter("select teacher.tname,batch.bcode,student.sname from batch join teacher on teacher.tid=batch.tech_id join student on batch.bid=student.batch_id where tname = 'Sir Salman' and bcode = '1071'", obj);
                obj.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                obj.Close();
            }
            else
            {
                MessageBox.Show("Invaled Data");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
