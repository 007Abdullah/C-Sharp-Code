using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_and_set_property
{
    class Program
    {
        static void Main(string[] args)
        {
            departname obj = new departname();
            obj.deptname = "HR Manager";
            obj.deptid = 45;
            obj.Dispolay();
        }
    }
   public class departname
    {
       public string deptname;
       public int deptid;
        public string mian
        {
            set{

                deptname = value;
            }
        }
        public int main1
        {

            set
            {
                deptid = value;
            }
        }
        public void Dispolay()
        {
            Console.WriteLine("Department Name"+deptname);
            Console.WriteLine("Department ID"+deptid);
        }


    }










}
