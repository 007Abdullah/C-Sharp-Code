using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_and_set
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryDetails obj = new SalaryDetails();
            obj.Employye = "sammer";
            Console.WriteLine( "Employee Name" +"\t"+  obj.Employye);
  
        }
    }
   public class SalaryDetails
    {
        private string employee;
        public string Employye
        {
            get
            {

                return employee;
            }
            set
            {
                employee = value;
            }

        }


    }
}
