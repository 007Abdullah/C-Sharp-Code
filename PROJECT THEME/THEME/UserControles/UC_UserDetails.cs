using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THEME.UserControles
{
    public partial class UC_UserDetails : UserControl
    {
        public UC_UserDetails()
        {
            InitializeComponent();
        }

     

        private void txt_pnumber_check_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter db = new SqlDataAdapter("select * from infoation where TelephoneNO like '%" + txt_pnumber_check.Text + "%'  ", obj);
            obj.Open();
            DataTable dt = new DataTable();
            db.Fill(dt);
            DataGrid_UserDetail.DataSource = dt;
        }

        private void UC_UserDetails_Load(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter dp = new SqlDataAdapter("select * from infoation", obj);
            obj.Open();
            DataTable dt = new DataTable();
            dp.Fill(dt);
            DataGrid_UserDetail.DataSource = dt;
        }
    }
}
