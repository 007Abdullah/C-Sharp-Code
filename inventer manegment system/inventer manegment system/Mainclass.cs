using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventer_manegment_system
{
    class Mainclass
    {
        public static void main(Form openwith,Form clswin, Form MDIwin) {

            clswin.Close();
            MDIwin.MdiParent = MDIwin;
            openwith.WindowState = FormWindowState.Maximized; 
            openwith.Show();
        
        }
        public static void main(Form openwith, Form MDIwin)
        {
            openwith.MdiParent = MDIwin;
            openwith.WindowState = FormWindowState.Maximized;
            openwith.Show();
        }
    }
}
