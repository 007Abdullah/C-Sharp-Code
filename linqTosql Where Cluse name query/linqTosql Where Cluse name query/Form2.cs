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

namespace linqTosql_Where_Cluse_name_query
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtbox1.Text, "^[A-Za-z0-9]$"))
            {
                label2.Text ="Match";
                label2.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                label2.Text = "Not Match";
                label2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
