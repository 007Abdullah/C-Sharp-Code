using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_and_set_static_property
{
    class Program
    {
        static void Main(string[] args)
        {

            university obj = new university();
            university.MyProperty = "IQRA UNI";
            university.MyProperty2 = "HR MANAGER";
            Console.WriteLine("UNIVERSITY NAME : " + university.MyProperty);
            Console.WriteLine("UNIVERSITY DEPARTMENT :" + university.MyProperty2);
        }
    }



  public  class university
    {

         private static string department;
       private static string uniname;

        public static string MyProperty
        {


            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public static string MyProperty2 { 
            get 
            {
                return uniname;
            } 
            set
            {
                uniname = value;
            } 
        }

    }
}
