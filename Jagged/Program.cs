using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            //jagged3 j3 = new jagged3();

            //jagged2 j2 = new jagged2();
            //j2.j2();
        
            ////fordays fd = new fordays();
            //arrRef ar = new arrRef();
            ////forcast fc = new forcast();

        }
    }
    class forcast {
        public forcast() {

            string s = "abc";
            int forchange = Convert.ToInt32(s);
            Console.WriteLine(forchange);
        
        }
    }
    class arrRef {

        int a = 1;
        int b = 2;
        public arrRef() {

            //int[] val = new int[2];
            int[] v1 = {a,b,3,4,5,6,7 };
            Console.WriteLine(v1.Rank);

            //foreach (var item in v1)
            //{
            //    Console.WriteLine(item);
            //}
            char s = 'a';


            //int forchange = Convert.ToInt32(s);
            //Console.WriteLine(forchange);
            
           int[] v2 = {s, 45, 67,55,77,99,88,100};
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
    


    class fordays {

        public fordays() {

            string[] days = { "Monday","Tue","Wed","Thurs","Fri","Sat", "Sunday" };

        //for collections only 
            foreach (var item in days)
            {
                Console.WriteLine(item);
                
            }
        
        }
    }
    class jagged2
    {

        public void j2(){

           //int[] arr = new int[] { 1, 2, 3 };
           //for (int i = 0; i < arr.Length; i++)
           //{
           //    Console.Write(arr[i]);   
           //}
            int[][] jaggedArray2 = new int[3][];
            jaggedArray2[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray2[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray2[2] = new int[] { 11, 22 };

            for (int r = 0; r < jaggedArray2.Length;r++)
            {
                for (int c = 0; c < jaggedArray2[r].Length ; c++)
                {
                    Console.Write(jaggedArray2[r][c] +"\t \a");
                }
                Console.WriteLine();
            }

        }

    }
 

   
}
