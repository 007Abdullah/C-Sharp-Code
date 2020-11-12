using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do_while_and_starts_print
{
    class Program
    {
        static void Main(string[] args)
        {
            int j =1;
            while (j <= 100)
            {
                for (int i = 1 ; i < 4; i++)
                {

                    if (j <= 100)
                    {
                        Console.Write(j);
                        Console.Write("\t");
                        j++;
                    }
                    else break;

                }
                Console.WriteLine(); 
            }








            //for (int i = 0; i < 100; i += 3)
            //{
            //    Console.WriteLine("{0}        {1}        {2}", i, i + 1, i + 2);
            //}



            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(i + " ");
            //    if (i % 3 == 0 && i != 0) 
            //        Console.WriteLine();
            //}







            //start code even number while
            //int num = 1;
            //Console.WriteLine("The Number Is Even");
            //while (num <= 11)
            //{
            //    if ((num % 2 == 0))
            //    {
            //        Console.WriteLine(num);
            //    }
            //    num = num + 1;
            //}
            //and code is even number

            ////start code 
            //int i = 0;
            //int j;
            //while (i <= 10)
            //{
            //    j = 0;
            //    while (j <= i)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            //start code and..
        }
    }
}
