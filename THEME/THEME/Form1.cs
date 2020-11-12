using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THEME
{
    public partial class Form1 : Form
    {
        int Panelwidth;
        bool Hidden;
        public Form1()
        {
            InitializeComponent();
            Panelwidth = Panel_Slide.Width;
            Hidden = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                Panel_Slide.Width = Panel_Slide.Width + 10;
                if (Panel_Slide.Width >= Panelwidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                Panel_Slide.Width = Panel_Slide.Width - 10;
                if (Panel_Slide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            MovePanel.Height = btn_adduser.Height;
            MovePanel.Top = btn_adduser.Top;
            bunifuTransition1.ShowSync(UC_AddUser);
            bunifuTransition1.HideSync(UC_UserDetails);
            bunifuTransition1.HideSync(UC_UserReport);
        }

        private void btn_userdetail_Click_1(object sender, EventArgs e)
        {
            
            MovePanel.Height = btn_userdetail.Height;
            MovePanel.Top = btn_userdetail.Top;
            bunifuTransition1.ShowSync(UC_UserDetails);
            bunifuTransition1.HideSync(UC_AddUser);
            bunifuTransition1.HideSync(UC_UserReport);
        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            MovePanel.Height = btn_report.Height;
            MovePanel.Top = btn_report.Top;
            bunifuTransition1.ShowSync(UC_UserReport);
            bunifuTransition1.HideSync(UC_UserDetails);
            bunifuTransition1.HideSync(UC_AddUser);
        }

        private void UC_UserReport_Load(object sender, EventArgs e)
        {

        }

        private void uC_UserDetails1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
