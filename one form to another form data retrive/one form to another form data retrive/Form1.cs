using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace one_form_to_another_form_data_retrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string username;
        public static string password;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                username = txtbox1.Text;
                password = txtbox2.Text;
                Form2 obj = new Form2();
                obj.Show();
            }
            else {
                MessageBox.Show("please Remember me");
            }
        }

       

        
    }
}
