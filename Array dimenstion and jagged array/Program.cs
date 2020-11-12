using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_dimenstion_and_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {

            //Class1 a = new Class1();
            //Console.WriteLine("afiahsfuibsaiuhfsub5");


            //int[] count  = new int[10];
            //int counter = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    count[i] = counter++;
            //    Console.WriteLine("This value is :"+ count[i]);
            //}


            ////single dimension array
            //string[] student = new string[3]{"james","sameer","abdullah"};
            //for (int i = 0; i < student.Length; i++)
            //{
            //    Console.WriteLine(student[i]);
            //}


            //int[,] arry = new int[2, 3];

            //arry[0, 0] = 45;
            //arry[0, 1] = 10;
            //arry[0, 2] = 28;
            //arry[1, 1] = 85;
            //arry[1, 2] = 99;
            //arry[1, 3] = 100;
           

            //foreach (var item in arry)
            //{
            //    Console.WriteLine(item);
            //}

            //int[,] dimension = new int[4,5];

            //int numberone = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        dimension[i, j] = numberone;
            //        numberone++;
            //    }
            //}

            //Array obj = Array.CreateInstance(typeof(string) , 5);

            //obj.SetValue("savasv",0);
           
            //foreach (var item in obj)
            //{
            //    Console.WriteLine(item);
            //}



            sameer obj = new sameer();
            obj.input("safdsafas");
            Console.WriteLine(obj.main());



















        }
    }
    class sameer
    {

     public   string name;

       public string main()
        {

            return name;

        }
       public void input(string bkname)
        {

            bkname = name;



        }
    }
}
