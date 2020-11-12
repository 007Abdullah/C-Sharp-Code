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

        private void txt_pnumber_check_OnValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=THEME;uid=sa;password=123");
            SqlDataAdapter adp = new SqlDataAdapter("select NAME,P_NO,U_ADDRESS,CITY,MD_CON,TP_CON from AddUser where P_NO = '"+txt_pnumber_check.Text+"'",con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            DataGrid_UserDetail.DataSource = dt;
        }
    }
}
