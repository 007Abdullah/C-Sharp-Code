using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqTosql_Where_Cluse_name_query
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            var list = obj.sameers.ToList();
            dataGridView1.DataSource = list;
        }

        private void txtbox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext obj1 = new DataClasses1DataContext();
            var c = from list in obj1.sameers where list.name == txtbox1.Text select list;
            dataGridView1.DataSource = c;






        }
    }
}
