using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THEME
{
    public partial class ProjectName : Form
    {
        public ProjectName()
        {
            InitializeComponent();
        }
        int counter = 0;
        int length = 0;
        string txt;

        private void Name_Load(object sender, EventArgs e)
        {
            txt = Pnl_Name.Text;
            length = txt.Length;
            Pnl_Name.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= length)
            {
                counter = 0;
                Pnl_Name.Text = "";
                timer1.Stop();
                Admin_Login admnlogin = new Admin_Login();
                admnlogin.Show();
            }
            else
            {
                Pnl_Name.Text = txt.Substring(0, counter);
                //if (Pnl_Name.ForeColor == Color.WhiteSmoke)
                //{
                //    Pnl_Name.ForeColor = Color.FromArgb(225, 14, 116);
                //}
                //else
                //{
                //    Pnl_Name.ForeColor = Color.WhiteSmoke;
                //}
            }
        }

    }
}
