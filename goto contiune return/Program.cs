using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto_contiune_return
{
    class Program
    {
        static void Main(string[] args)
        {
            //int length = 45;
            //int breath = 45;
            //int area;
            //area = length * breath;
            //object o = area;
            //int num = (int)o;
            //Console.WriteLine(o);
            int num = 8; 
            int result; 
            result = Square(num);
            Console.WriteLine("Square of {0} = {1}", num, result);
        } 
        static int Square(object inum) 
        { 
            return (int)inum * (int)inum;
        }

        }
    }




//        //sameer obj = new sameer();
//        //obj.main();

//        //Console.WriteLine("the prime number 1 to 10");
//        //for (int i = 0; i <=10 ; i++)
//        //{
//        //    if (i % 2 !=0)
//        //    {   
//        //        continue;
//        //    }
//        //    Console.Write(i + "\t");
//        //}
//        //for (int i = 0; i <= 10; i++)
//        //{
//        //    if (i == 10)
//        //    {
//        //        return;
//        //    }
//        //    Console.WriteLine(i);
//        //}
//        //    int i = 0;
//        //display:
//        //    {

//        //        Console.WriteLine("HEllo  Word");

//        //    }
//        //i++;
//        //    if (i <= 5)

//        //    {
//        //        goto display;

//        //    }

//    }

//public class sameer
//{

//    public void main()
//    {
//        int num = 8;
//            int result; 
//            result = Square(num);
//            Console.WriteLine("Square of {0} = {1}", num , result);
//            static int Square(object inum) 
//            { 
//                return (int)inum * (int)inum;
//            }
//        //int numone = 17;
//        //int numtwo = 2;
//        //while (numone <= numtwo - 1)
//        //{
//        //    if (numone % numtwo == 0)
//        //    {
//        //        Console.WriteLine("Not a Prime Number");
//        //        break;
//        //    }
//        //    numtwo++;
//        //}
//        //if (numtwo == numone)
//        //{
//        //    Console.WriteLine("Prime number");
//        //}

//    }

//}

