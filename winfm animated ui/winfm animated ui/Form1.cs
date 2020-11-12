using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace winfm_animated_ui
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!Regex.IsMatch(txtbox1.Text, "^[a-zA-Z]*$"))
            {
                MetroFramework.MetroMessageBox.Show(this , "Match");
              
            }
            else
            {
                label2.Text = "Not Match";
                label2.ForeColor = System.Drawing.Color.Red; 

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
