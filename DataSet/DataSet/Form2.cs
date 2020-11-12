using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            razzaq obj1 = new razzaq() { 
                name = txtbox1.Text,
                fnam = txtbox2.Text,
                addres = txtbox3.Text,
                cnic = txtbox4.Text,
                salary = txtbox5.Text   
            };
            obj.razzaqs.InsertOnSubmit(obj1);
            obj.SubmitChanges();
            MessageBox.Show("Inserted Complete-");
            NewMethod();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            DataClasses1DataContext obj3 = new DataClasses1DataContext();
            var list = obj3.razzaqs.ToList();
            dataGridView1.DataSource = list;
        }
    }
}
