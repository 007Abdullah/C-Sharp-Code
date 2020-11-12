using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j;
            while (i <= 10)
            {
                j = 0;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            //int i;
            //int j;
            //for (i = 0; i <= 10 ; i++)
            //{
            //    for (j = 0; j <= i;j++ )
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////int num = 8;
            //int result;
            //result = Square(num);
            //Console.WriteLine("Square of {0} = {1}", num, result);

            //////float f = 1.5F;
            ////string stn = f.ToString();
            ////Console.WriteLine(stn);
        }
        //static int Square(int inum)
        //{
        //    return inum * inum;
        //}
        
            //for (int counter = 1; counter <= 10; counter++)
            //{
            //    Console.WriteLine(counter * counter);
            //}
            //Console.ReadLine();
            //int num;
            //num = convert.toint32(console.readline());
            //int result;
            //result = square(num);
            //console.writeline("square of {0} = {1}", num, result);
            //console.writeline("enter the number of terms : ");
            //int n = convert.toint32(console.readline());

            //int square = 0;
            //while (square < n)
            //{
            //    square = n * square;

            //    console.write(" {0} ", square);
            //}

            //    Console.ReadLine();
            //}
            //static int Square(object inum)
            //{

            //    return (int)inum * (int)inum;


            //}
        }
    }


