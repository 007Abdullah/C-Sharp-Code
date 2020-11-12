using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater_Calculater
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string oprationform = "";
        bool isoprationform = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isoprationform))
            
                textBox1.Clear();
            
            isoprationform = true;
            Button obj = (Button)sender;
            textBox1.Text = textBox1.Text + obj.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            oprationform = obj.Text;
            result = Double.Parse(textBox1.Text);
            lbltxt.Text = result + " " + oprationform;
            isoprationform = true;

        }

        private void button_click29(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void equal_clickes(object sender, EventArgs e)
        {
            switch (oprationform)
            {
                case "+":
                    {
                       
                        textBox1.Text = (result+Double.Parse(textBox1.Text).ToString());
                        break;    
                    }
                case "-":
                    {
                        textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                        break;

                    }
                case "*":
                    {
                        textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                        break;

                    }

                    
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

    }
}
