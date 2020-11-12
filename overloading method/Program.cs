using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_method
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int length = 10;
            int breath = 22;
            double tbase = 2.5;
            double theight = 1.5;

            Console.WriteLine("Area Of Retangle :"+Area.CalculateArea(length, breath));
            Console.WriteLine("Area of triangle: " + Area.CalculateArea(tbase, theight));
        }
    }
     public class Area
    {

      public static int CalculateArea(int len,int wid)
        {
            return len * wid;
        }
       public static double CalculateArea(double valone,double valtwo)
        {

            return 0.5 * valone * valtwo;
        }   


    }






}
