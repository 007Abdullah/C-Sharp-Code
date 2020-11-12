using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                 int a = +1;
                
            }
            else if (radioButton4.Checked)
            {
                int b = +1;
                int result;
                
            }
            else
            {
                MessageBox.Show("Your Answer Is wrong");
            }
           
           

        }
    }
}
