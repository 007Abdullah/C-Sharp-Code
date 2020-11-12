using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stateicmethode
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 10; 
            int numTwo = 20;  
            Console.WriteLine("Value of Num1 and Num2 before calling method " + numOne + ", " + numTwo);   
            Console.WriteLine("Value of Num1 and Num2 after calling method " + numOne + ", " + numTwo);
            

            //Console.WriteLine("square = {0}",square(4));
        }
        //public static int square(int num)
        //{
        //    return num * num;
        //}
    }
   public class sameer
    {
      public static void Calculate(ref int numValueOne, ref int numValueTwo)
        {
            numValueOne = numValueOne * 2;
            numValueTwo = numValueTwo / 2;
        }
    }
}