using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    class Program
    {
        static void Main(string[] args)
        {
            destructor obj = new destructor(1,"Abdullah",45,100000);
            
        }
    }
  public class destructor
    {
       private int employeid;
       private string employename;
       private int employeage;
       private int employesalary;
        public destructor(int id,string name,int age,int salary)
        {
           employeid = id;
           employename = name;
           employeage = age;
           employesalary = salary;
        }
        ~destructor()
        {
            Console.WriteLine("Destructor for emplyoee called");
        }
    }
}
