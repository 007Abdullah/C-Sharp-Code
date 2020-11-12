using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace fingerprint_project
{
    public partial class Form1 : Form
    {
        Bitmap bitmap1, bitmap2;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void BtnFirstpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openflg.FileName;
                bitmap1 = new Bitmap(openflg.FileName);
            }
        }

        private void BtnSecondpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openflg.FileName;
                bitmap2 = new Bitmap(openflg.FileName);
            }
        }

        private void Btncompare_Click(object sender, EventArgs e)
        {
            bool compare = ImageCompareString(bitmap1, bitmap2);
            if (compare == true)
            {
                MessageBox.Show("Two Finger Print Match");
            }
            else
            {
                MessageBox.Show("Two Finger Print Not Match");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool ImageCompareString(Bitmap bit1, Bitmap bit2)
        {
            MemoryStream ms = new MemoryStream();
            bit1.Save(ms, ImageFormat.Png);
            string first = Convert.ToBase64String(ms.ToArray());
            ms.Position = 0;
            bit2.Save(ms, ImageFormat.Png);
            string second = Convert.ToBase64String(ms.ToArray());
            if (first.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
