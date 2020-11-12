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
        //Sliding Panel Variables
        int Panelwidth;
        bool Hidden;
        //Side Short Panel Variables
        int S_Panelwidth;
        bool S_Hidden;
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
            timer2.Start();
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
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (S_Hidden)
            {
                Panel_Short.Width = Panel_Short.Width + 50;
                if (Panel_Short.Width >= S_Panelwidth)
                {
                    timer2.Stop();
                    S_Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                Panel_Short.Width = Panel_Short.Width - 10;
                if (Panel_Short.Width <= 0)
                {
                    timer2.Stop();
                    S_Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btn_adduser_Click_1(object sender, EventArgs e)
        {
            MovePanel.Height = btn_adduser.Height;
            MovePanel.Top = btn_adduser.Top;
            bunifuTransition1.ShowSync(UC_AddUser);
            bunifuTransition1.HideSync(UC_UserDetails);
            bunifuTransition1.HideSync(UC_UserReporting);
        }

        private void btn_userdetail_Click(object sender, EventArgs e)
        {
            MovePanel.Height = btn_userdetail.Height;
            MovePanel.Top = btn_userdetail.Top;
            bunifuTransition1.ShowSync(UC_UserDetails);
            bunifuTransition1.HideSync(UC_AddUser);
            bunifuTransition1.HideSync(UC_UserReporting);
        }

        private void btn_report_Click_1(object sender, EventArgs e)
        {
            MovePanel.Height = btn_report.Height;
            MovePanel.Top = btn_report.Top;
            bunifuTransition1.ShowSync(UC_UserReporting);
            bunifuTransition1.HideSync(UC_UserDetails);
            bunifuTransition1.HideSync(UC_AddUser);
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            MovePanel.Height = btn_adduser.Height;
            MovePanel.Top = btn_adduser.Top;
            bunifuTransition1.ShowSync(UC_AddUser);
            bunifuTransition1.HideSync(UC_UserDetails);
            bunifuTransition1.HideSync(UC_UserReporting);
        }

        private void UserDetails_Click(object sender, EventArgs e)
        {
            MovePanel.Height = btn_userdetail.Height;
            MovePanel.Top = btn_userdetail.Top;
            bunifuTransition1.ShowSync(UC_UserDetails);
            bunifuTransition1.HideSync(UC_AddUser);
            bunifuTransition1.HideSync(UC_UserReporting);
        }

        private void UserReport_Click(object sender, EventArgs e)
        {
            MovePanel.Height = btn_report.Height;
            MovePanel.Top = btn_report.Top;
            bunifuTransition1.ShowSync(UC_UserReporting);
            bunifuTransition1.HideSync(UC_UserDetails);
            bunifuTransition1.HideSync(UC_AddUser);
        }

    }
}
