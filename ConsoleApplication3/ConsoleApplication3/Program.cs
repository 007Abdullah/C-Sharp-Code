using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            int c = a+b;
            Console.WriteLine("added  {0} number  ",c);

            int num = 456;
            Console.WriteLine("{0:C}", num); 
            Console.WriteLine("{0:D}", num); 
            Console.WriteLine("{0:E}", num); 






            //int yrsOfService = 3;
            //double salary = 1500;
            //int bonus = 0;

            //if (yrsOfService  < 5)
            //{
            //    if (salary < 500)
            //    {
            //        bonus = 100; 
            //    }
            //    else
            //    {
            //        bonus = 200; 
            //    }
            //}
            //else
            //{
            //    bonus = 700;
            //}
            //Console.WriteLine("Bonus : " + bonus);



            //DateTime dt = DateTime.Now; 
            //// Returns short date and short time with seconds 
            //Console.WriteLine("Short date and short time with seconds (G):{0:G}", dt);
            //// Returns month and day - M can also be used 
            //Console.WriteLine("Month and day (m):{0:m}", dt); 
            //// Returns short time
            //Console.WriteLine("Short time (t):{0:t}", dt); 
            //// Returns short time with seconds
            //Console.WriteLine("Short time with seconds (T):{0:T}", dt); 
            //// Returns year and month - Y also can be used 
            //Console.WriteLine("Year and Month (y):{0:y}", dt); 

        }
    }
}
