using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculater__New_Full_Code
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operatrionForm = "";
        bool isoperatrionForm = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isoperatrionForm))
            
                textBox_Result.Clear();
            
            isoperatrionForm = false;
            Button obj = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + obj.Text;
        }

        private void opartor_click(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            operatrionForm = obj.Text;
            resultValue = Double.Parse(textBox_Result.Text);
           
            txtlbl.Text = resultValue + " " + operatrionForm;
            isoperatrionForm = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }


        private void button_click15(object sender, EventArgs e)
        {
            switch (operatrionForm)
            {
                case "+":
                    {
                        textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                        break;

                    }
                case "-":
                    {
                        textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                        break;

                    }
                case "*":
                    {
                        textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                        break;

                    }
                case "/":
                    {
                        textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                        break;

                    }
                default:
                    break;
            }
        }





    }
}
