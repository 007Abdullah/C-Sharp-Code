using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void fillgrid()
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            var list = obj.razzaqs.ToList();
            dataGridView1.DataSource = list;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            razzaq obj1 = new razzaq()
            {
                name = txtbox2.Text,
                fnam = txtbox3.Text,
                addres = txtbox4.Text,
                cnic = txtbox5.Text,
                salary = txtbox6.Text
            };
            obj.razzaqs.InsertOnSubmit(obj1);
            obj.SubmitChanges();
            MessageBox.Show("Ineserted");
            fillgrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillgrid();
        }
    }
}