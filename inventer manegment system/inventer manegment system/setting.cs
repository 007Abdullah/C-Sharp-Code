using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventer_manegment_system
{
    public partial class setting : Sample
    {
        public setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (integratedtxt.Checked)
            {
                if (servertxt.Text != "" && databasetxt.Text != "")
                {
                    s = "Data Source=" + servertxt.Text + ";Initial Catalog=" + databasetxt.Text + ";Integrated Security=true;";
                    File.WriteAllText(path+"\\connect",s);
                    DialogResult dr = MessageBox.Show("Setting Save Succesfully....", "Information.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        Mainclass.main(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give COmplete data to continue.....");
                }
            }
            else
            {
                if (servertxt.Text != "" && databasetxt.Text != "" && useridtxt.Text != "" && passeordtxt.Text != "")
                {
                    s = "Data Source=" + servertxt.Text + ";Initial Catalog=" + databasetxt.Text + ";User ID=" + useridtxt.Text + ";Password=" + passeordtxt.Text + ";";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Setting Save Succesfully....", "Information.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        Mainclass.main(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give COmplete data to continue.....");
                }

            }
            
        }

        private void integratedtxt_CheckedChanged(object sender, EventArgs e)
        {
            if (integratedtxt.Checked)
            {
                useridtxt.Enabled = false;
                passeordtxt.Enabled = false;
                useridtxt.Text = "";
                passeordtxt.Text = "";
            }
            else
            {
                useridtxt.Enabled = true;
                passeordtxt.Enabled = true;

            }
        }
    }
}
