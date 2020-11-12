using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_mangement_system
{
    public partial class regitr : Form
    {
        public regitr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtbox1.Text == "" && txtbox2.Text == "" && txtbox3.Text == "" && txtbox4.Text == "")
            {
                MessageBox.Show("fill all field");
                
            }
            DataClasses1DataContext obj = new DataClasses1DataContext();
            regiter obj1 = new regiter()
            {
                name = txtbox1.Text,
                fname = txtbox2.Text,
                username = txtbox3.Text,
                password = txtbox4.Text
            };
            obj.SubmitChanges();
            obj.regiters.InsertOnSubmit(obj1);
            MessageBox.Show("Data Has Been Submit");
            this.Hide();
            
        }
    }
}
