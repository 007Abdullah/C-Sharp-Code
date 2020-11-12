using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculater
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c =0;
            Console.WriteLine("(1)  ADDITION");
            Console.WriteLine("(2)  SUBTRACT");
            Console.WriteLine("(3)  MULTIPILICATION");
            Console.WriteLine("(4)  DIVISION");
            Console.WriteLine("(5)  MODOULOUS");
            Console.WriteLine("Take The Selecet Number");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value one"); 
            a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter value two");
            b = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    {
                        c=a+b;
                        Console.WriteLine(c);
                        break;
                    }
                case 2:
                    {
                        c = a-b;
                        Console.WriteLine(c);
                        break;
                    }
                case 3:
                    {
                        c = a*b;
                        Console.WriteLine(c);
                        break;
                    }
                case 4:
                    {
                        c = a/b;
                        Console.WriteLine(c);
                        break;
                    }
                case 5:
                    {
                        c = a%b;
                        Console.WriteLine(c);
                        break;
                    }
                
                    
      }

            



        }
    }
}
