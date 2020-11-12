using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datdatypes
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter Your Age ?");
            byte age;
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter a Year :");
            short year;
            year = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("What is This");


            Console.WriteLine("Your Age  :" + age);
            Console.WriteLine("This Year :" + year);


        }
    }
}
