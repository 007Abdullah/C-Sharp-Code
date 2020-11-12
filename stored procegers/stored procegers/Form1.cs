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

namespace stored_procegers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=procger;uid=sa;password=123");
            SqlCommand cmd = new SqlCommand("same",obj);
            obj.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",txtbox1.Text);
            cmd.Parameters.AddWithValue("@name",txtbox2.Text);
            cmd.Parameters.AddWithValue("@fname",txtbox3.Text);
            cmd.Parameters.AddWithValue("@gender",txtbox4.Text);
            cmd.Parameters.AddWithValue("@city",txtbox5.Text);
            cmd.Parameters.AddWithValue("@cnic",txtbox6.Text);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Update");
                NewMethod();
            }
            else
            {
                MessageBox.Show("Invalied Update");
            }
            obj.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            SqlConnection obj = new SqlConnection("server=.;database=procger;uid=sa;password=123");
            SqlDataAdapter db = new SqlDataAdapter("select * from datas", obj);
            obj.Open();
            DataTable dn = new DataTable();
            db.Fill(dn);
            dataGridView1.DataSource = dn;
          
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtbox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    txtbox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    txtbox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //    txtbox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //    txtbox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //    txtbox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        //}

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtbox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtbox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtbox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtbox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtbox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
