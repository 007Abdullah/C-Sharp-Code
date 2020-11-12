using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            //object initializers
            Employee obj = new Employee
            {
                name = "Sameer",
                age = 20,
                designation = "IT Manager",
                Start = "Abdullah",
                Test = "Sameer",
                est = "sadfsaf",
                stgh = "sameer",
                sa = "Adullah"
            };
            Console.WriteLine("Name: {0}, Age: {1}, Designation: {2} , Start: {3}", obj.name, obj.age, obj.designation,obj.Start);
        }
    }
    public class Employee
    {
        public string name { 
            get; set; 
        }
        public int age { 
            get; set;
        }
        public string designation { 
            get; set;
        }
        public string Start { 
            get; set;
        }
        public string Test { 
            get; set;
        }
        public string est { 
            get; set;
        }
        public string stgh { 
            get; set;
        }
        public string sa_khan { 
            get; set;
        }
        public string sa {
            get; set;
        }
    }
}
