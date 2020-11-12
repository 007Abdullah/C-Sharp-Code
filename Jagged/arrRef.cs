using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
    class arrRef
    {

        int a = 1;
        int b = 2;
        public arrRef()
        {

            //int[] val = new int[2];
            int[] v1 = { a, b, 3, 4, 5, 6, 7 };
            Console.WriteLine(v1.Rank);

            //foreach (var item in v1)
            //{
            //    Console.WriteLine(item);
            //}
            char s = 'a';


            //int forchange = Convert.ToInt32(s);
            //Console.WriteLine(forchange);

            int[] v2 = { s, 45, 67, 55, 77, 99, 88, 100 };
            //foreach (var item in v2)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < v1.Length; i++)
            {
                Console.WriteLine(v1[i] + "\t" + v2[i]);
            }
            v2 = v1; //array referencing
            for (int i = 0; i < v1.Length; i++)
            {
                Console.WriteLine(v1[i] + "\t" + v2[i]);
            }
            Console.WriteLine(v2.Rank);
            //v2 = v1; //array referencing
            //foreach (var item in v2)
            //{
            //    Console.WriteLine(item);
            //}
        }

    }
}
