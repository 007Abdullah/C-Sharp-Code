using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            rectangle obj = new rectangle();
            Console.WriteLine("area of retangle" + obj.area());
            rectangle obj1 = new rectangle(2.5, 6.6);
            Console.WriteLine(obj1.area());
        }
    }
    //constructor overloading
    public class rectangle
    {
        double length;
        double breath;

        public rectangle()
        {


            length = 13.5;
            breath = 20.5;

        }
        public rectangle(double len, double wide)
        {

            length = len;
            breath = wide;

        }
        public double area()
        {

            return length * breath;

        }

    }
}
