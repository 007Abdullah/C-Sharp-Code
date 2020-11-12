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
using THEME.UserControles;
using THEME.Properties;
using THEME.TelephoneDataSetTableAdapters;


namespace THEME.UserControles
{
    public partial class UC_UserDetails : UserControl
    {
        public UC_UserDetails()
        {
            InitializeComponent();
        }

          
        private void UC_UserDetails_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext obj5 = new DataClasses1DataContext();
            var lit = obj5.infoations.ToList();
            bunifuCustomDataGrid1.DataSource = lit;
           
            
        }

        

        private void txt_pnumber_check_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter db = new SqlDataAdapter("select * from infoation where TelephoneNO like '%" + txt_pnumber_check.Text + "%'  ", obj);
            obj.Open();
            DataTable dt = new DataTable();
            db.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
        }
    }
}
