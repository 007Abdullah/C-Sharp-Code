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
    public partial class Rocket : Form
    {
        Timer timeback = new Timer();
        Timer timerocket = new Timer();
        Timer timeball = new Timer();
        public Rocket()
        {
            InitializeComponent();
            timeback.Tick += new EventHandler(resource);
            timeball.Tick += new EventHandler(bal);
            timerocket.Tick += new EventHandler(rocketup);
            defaul();
        }

        //
        void defaul()
        {
            LineRocket.Height = 1; LineRocket.Width = 0; LineRocket.Left = 341;
            Ball.Top = 262; Ball.Visible = false; Ball.BringToFront();
            Rocktet.Height = 64; Rocktet.Top = 320; Rocktet.Visible = false;

            //Image Location
            Ball.ImageLocation = "C:/Users/Abdul Razzaq/Desktop/DISM PROJECT/PROJECT PIC/Ball.png";
            Rocktet.ImageLocation = "C:/Users/Abdul Razzaq/Desktop/DISM PROJECT/PROJECT PIC/Rocket.png";

            //Time Interval
            timeback.Interval = 30;
            timeball.Interval = 40;
            timerocket.Interval = 10;

            timeback.Start(); //First
        }

        //Initial
        int wd = 0; int down = 1, lt = 5; int rocketop = -1;
        void resource(object sender, EventArgs e)
        {
            LineRocket.Width += wd;

            if (LineRocket.Width < 1)
            {
                wd = 8;
            }
            if (LineRocket.Width > 104)
            {
                timeback.Stop();
                timerocket.Start();
            }

            //
            Anim.ShowSync(label1);
        }

        void bal(object sender, EventArgs e)
        {
            Ball.Top += down;
            if (Ball.Top < 265)
            {
                Ball.Visible = true;
                down = 1;
            }
            if (Ball.Top > 305)
            {
                timeball.Interval = 10; //MakeFast
                Rocktet.ImageLocation = "C:/Users/Abdul Razzaq/Desktop/DISM PROJECT/PROJECT PIC/Rocket.png";

                Ball.Visible = false;
                down = 5;
                Rocktet.Top -= down;
                if (Rocktet.Top < -60)
                {
                    LineRocket.Width -= lt;
                    LineRocket.Left += lt;
                    if (LineRocket.Left > 470)
                    {
                        down = 1;
                        timeball.Stop();
                        //New Form Open
                        Admin_Login admnlogin = new Admin_Login();
                        admnlogin.Show();
                        this.Hide();
                    }
                }
            }
        }

        void rocketup(object sender, EventArgs e)
        {
            Rocktet.Top += rocketop;
            if (Rocktet.Top > 318)
            {
                Rocktet.Visible = true;
                rocketop = -5;
            }
            if (Rocktet.Top < 250)
            {
                rocketop = -1;
                timerocket.Stop();
                timeball.Start();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
