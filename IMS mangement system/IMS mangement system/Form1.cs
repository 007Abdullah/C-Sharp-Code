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
using System.Text.RegularExpressions;
using System.Configuration;
using MetroFramework.Forms;
using MetroFramework;
namespace IMS_mangement_system
{
    public partial class From :  MetroFramework.Forms.MetroForm
    {
        public From()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
    //        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
            DataClasses1DataContext obj = new DataClasses1DataContext();
            try
            {
                logn obj1 = new logn()
                {
                    username = txtbox1.Text,
                    password = txtbox2.Text
                };
                obj.logns.InsertOnSubmit(obj1);
                DataTable dt = new DataTable();
                obj.SubmitChanges();
                string patten = "^sameer@[a-zA-Z]{1,10}.(com|org)$";
                if (Regex.IsMatch(txtbox1.Text, patten) && txtbox2.Text == "123")
                {
                    NewMethod();
                }
                else
                {
                    errorProvider1.SetError(this.txtbox1, "Please Provide valid Email");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());                                    
            }              
        }
        private void NewMethod()
        {
            errorProvider1.Clear();
            MessageBox.Show("login done");
            PurshForm po = new PurshForm();
            po.Show();
            this.Hide();
        }
        private void btnreg_Click(object sender, EventArgs e)
        {
            regitr obj = new regitr();
            obj.Show();
        }
    }
}