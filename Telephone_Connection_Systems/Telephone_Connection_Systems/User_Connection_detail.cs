using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telephone_Connection_Systems.Properties;

namespace Telephone_Connection_Systems
{
    public partial class User_Connection_detail : Form
    {
        public User_Connection_detail()
        {
            InitializeComponent();
        }

        private void User_Connection_detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telephoneDataSet.infoation' table. You can move, or remove it, as needed.
            this.infoationTableAdapter.Fill(this.telephoneDataSet.infoation);

            label1.Text ="welcome " + Form1.username;
            filldata();
       
      
         
        }

        private void filldata()
        {
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter dp = new SqlDataAdapter("select * from infoation", obj);
            obj.Open();
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
          

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                txtempty();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
            
        }

        private void txtempty()
        {
            if (txtbox1.Text == "" || txtbox2.Text == "" || txtbox3.Text == "" || txtbox4.Text == "" ||comboBox1.Text  == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Invalid Feilds");
            }
            else if (!Regex.Match(txtbox1.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox1.Focus();
                return;
      
            }
           
            // end if 
            
            else if (!Regex.Match(txtbox4.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                // city was incorrect
                MessageBox.Show("Invalid city", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox4.Focus();
                return;
            }// end if 
            else
            {
                information();
                filldata();
                

            }
        }

        private void information()
        {
            SqlConnection obj2 = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            DataClasses1DataContext obj = new DataClasses1DataContext();
            SqlDataAdapter sd = new SqlDataAdapter("select * from infoation where TelephoneNO='"+txtbox2.Text+"'", obj2);
            infoation obj1 = new infoation()
            {
                name = txtbox1.Text,
                TelephoneNO = txtbox2.Text,
                Addres = txtbox3.Text,
                City = txtbox4.Text,
                Mode_of_connection = comboBox1.Text,
                type_of_conntion = comboBox2.Text

            };
            obj.infoations.InsertOnSubmit(obj1);
            DataSet db = new DataSet();
            sd.Fill(db);
            int i = db.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Mobile No "+ txtbox2.Text + "  Already Exit  ");
                db.Clear();
                txtbox1.Clear();
                txtbox2.Clear();
                txtbox3.Clear();
                txtbox4.Clear();
                comboBox1.Text = string.Empty;
                comboBox2.Text = string.Empty;
            }
            else
            {
                
                MessageBox.Show("Your Data Has Been Submit");
                obj.SubmitChanges();
                txtbox1.Clear();
                txtbox2.Clear();
                txtbox3.Clear();
                txtbox4.Clear();
                comboBox1.Text = string.Empty;
                comboBox2.Text = string.Empty;
                filldata();
            }
        }

        private void txtserch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var data = from c in db.infoations where c.name == txtserch.Text  select c;
            dataGridView1.DataSource = data;
        }

        private void txtbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8  && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtserch_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter db = new SqlDataAdapter("select * from infoation where TelephoneNO like '%" + txtserch.Text + "%'  ", obj);
            obj.Open();
            DataTable dt = new DataTable();
            db.Fill(dt);
            dataGridView1.DataSource = dt;
        }

   

      

     

      
      
    }
}
