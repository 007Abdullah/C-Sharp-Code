using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[][] a = new int[2][];
            //a[0] = new int[5]{1,2,3,4,5};
            //a[1] = new int[5] {2,4,6,8,10};
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a.GetLength(i));
            //}
            //    int[,] diamension = new int[4,5];
            //    int numberone = 0;
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            diamension[i, j] = numberone;
            //            numberone++;
            //        }
            //    }
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            Console.Write(diamension[i,j]+" ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
                
            string[][] a = new string[3][];
            a[0] = new string[] { "saf","adfa"};
            a[1] = new string[] { "saf", "adfa" ,"samakfjsak"};
            a[2] = new string[] { "saf", "adfa" ,"asfasd","adsfasfasfasd"};
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j <a[i].GetLength(0); j++)
                {
                    Console.WriteLine(a[i][j]+"");
                }
            }

        }
    }
}
