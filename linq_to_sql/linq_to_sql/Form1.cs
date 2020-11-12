using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq_to_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            emp obj1 = new emp() { 
            
                name = txtbox1.Text,
                fname = txtbox2.Text,
                salary = txtbox3.Text,
            };
            obj.emps.InsertOnSubmit(obj1);
            obj.SubmitChanges();
            MessageBox.Show("Inserted Data");
            NewMethod();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            DataClasses1DataContext dt = new DataClasses1DataContext();
            var list = dt.emps.ToList();
            dataGridView1.DataSource = list;
        }
    }
}
