using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Implemented__Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.name = "MUhammad ABdullah";
            obj.age = 20;
            obj.designation = "Manager For the IT ";
            Console.WriteLine("Name  :{0}, Age : {1} , Designation : {2}",obj.name,obj.age,obj.designation);
        }
    }
    public class Employee
    {
     
        public string name { get; set; }
        public int age { get; set; }
        public string designation { get; set; }
 

    }
}
