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
using System.Text.RegularExpressions;
namespace IMS_mangement_system
{
    public partial class stokform : MetroFramework.Forms.MetroForm
    {
        public stokform()
        {
            InitializeComponent();
        }

        private void stokform_Load(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext obj = new DataClasses1DataContext();
                var lit = obj.stocks.ToList();
                dataGridView1.DataSource = lit;
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

          

        }

        private void txtbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            SqlConnection obj = new SqlConnection("server=.;database=IMS;uid=sa;password=123");
            SqlDataAdapter dt = new SqlDataAdapter("select * from stock where itemofnams like '" + txtbox1.Text + "' ", obj);
            obj.Open();
            DataTable dtb = new DataTable();
            dt.Fill(dtb);
            dataGridView1.DataSource = dtb;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salefrom obj = new Salefrom();
            obj.Show();
            this.Hide();
            
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtbox1.Text, "^[A-Z][a-zA-Z]*$"))
            {
                NewMethod();    
            }
            
        }
    }
}
