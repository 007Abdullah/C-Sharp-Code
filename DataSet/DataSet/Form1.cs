using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.razzaq' table. You can move, or remove it, as needed.
            this.razzaqTableAdapter.Fill(this.DataSet1.razzaq);

            this.reportViewer1.RefreshReport();
        }
    }
}
