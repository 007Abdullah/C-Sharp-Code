using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_chaning
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class A
    {

        public A()
        {

            Console.WriteLine("Consturtor Without Parameter");


        }
        public A(int a)
        {

            Console.WriteLine("Consturtor  Parameter");


        }
    }
    public class B : A
    {
        public B()
            : base(45)
        {
            Console.WriteLine("child class construdtor");
        }
    }
    public class C : A
    {
        public C()
        {

            Console.WriteLine("c ka consturtor");


        }



    }
}
