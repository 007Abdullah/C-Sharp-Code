using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7
{
    class Program
    {
        static void Main(string[] args)
        {
            Canine c = new Canine();

        //    A obja1 = new A();
        //    A obja2 = new A(" stud1");
          //  B objb = new B();



            Console.ReadLine();
        }
    }
    class Animal { 
    
        public Animal() { Console.WriteLine("Animal constructor without parameters"); }
        public Animal(String name) 
        { Console.WriteLine("Animal constructor with a string parameter"+name); }

    }
    class Canine :Animal {

       public Canine() : base("Elephant") {
           Console.WriteLine("Canine  Class");
       }
    }


}
