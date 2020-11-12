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
namespace IMS_mangement_system
{
    public partial class PurshForm : MetroFramework.Forms.MetroForm
    {
        public PurshForm()
        {
            InitializeComponent();
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext obj = new DataClasses1DataContext();
                NewMethod();
                if (Regex.IsMatch(txtbox1.Text, "^[A-Z][a-zA-Z]*$") && Regex.IsMatch(txtbox2.Text, "^{30}$") && Regex.IsMatch(txtbox3.Text, "^{30}$"))
                {
                    NewMethod2(obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }                           
        }
        private void NewMethod2(DataClasses1DataContext obj)
        {
            purchse obj1 = new purchse()
            {
                itemofnam = txtbox1.Text,
                priceofitem = txtbox2.Text,
                noofitem = Text,
                date = dateTimePicker1.Text
            };
            obj.purchses.InsertOnSubmit(obj1);
            obj.SubmitChanges();
            MessageBox.Show("Submit Purchase");
            stokform dt = new stokform();
            dt.Show();
            this.Hide();
        }
        private void NewMethod()
        {
            if (txtbox1.Text == "" && txtbox2.Text == "" && txtbox3.Text == "")
            {
                MessageBox.Show("Please Fill The Field");
            }
        }
    }
}