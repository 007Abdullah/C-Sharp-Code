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
    public partial class Salefrom : MetroFramework.Forms.MetroForm
    {
        public Salefrom()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtbox1.Text, "^[A-Z][a-zA-Z]*$"))
                {
                    NewMethod();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void NewMethod()
        {
            int a = int.Parse(txtbox2.Text);
            int b = int.Parse(txtbox3.Text);
            int sum = a * b;

            DataClasses1DataContext obj = new DataClasses1DataContext();
            sal obj1 = new sal()
            {
                itemname = txtbox1.Text,
                noofitm = txtbox2.Text,
                amount = txtbox3.Text
            };
            obj.sals.InsertOnSubmit(obj1);
            obj.SubmitChanges();
            MessageBox.Show("Sales Done \b" + "Your Price is" + sum);
        }
    }
}