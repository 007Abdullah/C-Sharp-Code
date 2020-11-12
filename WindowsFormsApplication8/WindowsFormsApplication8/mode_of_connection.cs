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

namespace WindowsFormsApplication8
{
    public partial class mode_of_connection : Form
    {
        public mode_of_connection()
        {
            InitializeComponent();
        }

        private void mode_of_connection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telephoneDataSet.infoation' table. You can move, or remove it, as needed.
            this.infoationTableAdapter.Fill(this.telephoneDataSet.infoation);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter obj1 = new SqlDataAdapter("select * from infoation where Mode_of_connection like '%" + comboBox1.Text + "%'", obj);
            obj.Open();
            DataTable dt = new DataTable();
            obj1.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
