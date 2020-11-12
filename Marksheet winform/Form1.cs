using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marksheet_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            int eng, urdu, islam, phy, cheistry, maths,result,percent;
            urdu = Convert.ToInt32(txtUrdu.Text);
            islam = Convert.ToInt32(txtIslam.Text);
            phy = Convert.ToInt32(txtPhysic.Text);
            cheistry = Convert.ToInt32(txtChemistry.Text);
            maths = Convert.ToInt32(txtMatths.Text);
            eng = Convert.ToInt32(txtEnglish.Text);

            result = urdu + islam + phy + cheistry + maths + eng;
            percent = result * 100 / 600;
            lblobd.Text = result.ToString();
            lblpr.Text = percent.ToString();

            if (percent >= 80 && percent < 100)
            {
                string a = "A1";
                lblgrade.Text = a.ToString();
              
            }
            else if (percent > 70 && percent < 80)
            {
               char o = 'A';
               lblgrade.Text = o.ToString();
            }
            else if (percent >= 60 && percent < 70)
            {
                char b = 'B';
                lblgrade.Text = b.ToString();
            }
            else if (percent >= 50 && percent < 60)
            {
                char c = 'C';
                lblgrade.Text = c.ToString();
            }

            else
            {
                    string f = "Fail";
                    lblgrade.Text = f;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}
