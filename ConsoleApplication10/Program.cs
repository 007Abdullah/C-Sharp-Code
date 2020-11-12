using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int[,] dimension = new int[4, 5];
            //    int numOne = 0; 
            //    for (int i = 0; i < 4; i++) 
            //    { 
            //        for (int j = 0; j < 5; j++) 
            //        {
            //            dimension[i, j] = numOne; 
            //            numOne++; 
            //        }
            //    }
            //    for (int i=0; i<4; i++) 
            //    {

            //        for (int j=0; j<5; j++)
            //        { 

            //            Console.Write(dimension [i, j] + " ");
            //        }

            //    }
            //    Console.WriteLine(); 
            //} 

            //string[] classone = { "Sameer ", "ABdullah ", "Younus" };
            //string[] classtwo = { "Razaaq ", "Abdul Razzaq ", "Madam" };

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(classone[i]+"\t\t\t"+classtwo[i]);
            //}
            //classtwo = classone;
            //Console.WriteLine("\nStudents of Class II after referencing Class I :");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(classtwo[i]+"");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Students of Class I after changing the third student in Class II:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(classone[i]+"");
            //}
            //string[][] comparsion = new string[3][];
            //comparsion[0] = new string[] { "sameer" ,"abdullah"};
            //comparsion[1] = new string[] { "sameer", "abdullah","sasfasd" };
            //comparsion[2] = new string[] { "sameer", "abdullah" ,"asdfsad","sadfasdfsa"};
            //comparsion.IsFixedSize();
            //for (int i = 0; i < comparsion.IsFixedSize(); i++)
            //{
            //    Console.Write("List of companies in group " + (i + 1) + ":\t");
            //    //for (int j = 0; j < comparsion[i].GetLength(0); j++)
            //    //{
            //    //    Console.Write(comparsion[i][j] + "    ");
            //    //}
            //    Console.WriteLine();
            //}
            //Array objArray = Array.CreateInstance(typeof(string), 5);
            //objArray.SetValue("sadfasdvas",0);
            //objArray.SetValue("sadfasdvas", 1);
            //objArray.SetValue("sadfasdvas", 2);
            //objArray.SetValue("sadfasdvas", 3);
            //objArray.SetValue("sadfasdvas", 4);
            //for (int i = 0; i < objArray.GetUpperBound(0); i++)
            //{
            ////    Console.WriteLine(objArray.GetValue(i));
            //}

            




            //int[] array = new int[4];
            //Console.WriteLine(array.IsFixedSize);
            //Console.WriteLine(array.IsReadOnly);
            //Console.WriteLine(array.IsSynchronized);
            //Console.WriteLine(array.LongLength);
            //Console.WriteLine(array.Rank);


            Array objArray = Array.CreateInstance(typeof (string), 5);
            objArray.SetValue("Marketing", 0); 
            objArray.SetValue("Finance", 1); 
            objArray.SetValue("Human Resources", 2); 
            objArray.SetValue("Information Technology", 3);
            objArray.SetValue("Business Administration", 4); 
            for (int i = 0; i <= objArray.GetUpperBound(0); i++) 
            { 
                Console.WriteLine(objArray.Clone()); 
            }



            






















            sameer obj = new sameer();
            


        }
    }
    class sameer
    {
       public sameer()
        {


            int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };

            if (myIntArray.IsReadOnly)
                Console.WriteLine("Array is of Fixed Size");
            else
                Console.WriteLine("Array is NOT of Fixed Size");

            Console.ReadLine();




        }
       //public void main()
       // {
       //     Console.WriteLine("Enter a Student No :");
       //     int nostud = Convert.ToInt32(Console.ReadLine());
       //     Console.WriteLine("Enter a numebr of Exam: ");
       //     int exams = Convert.ToInt32(Console.ReadLine());
       //     string[] stdName = new string[nostud];
       //     string[,] details = new string[nostud, exams];
       //     for (int i = 0; i < nostud; i++)
       //     {
       //         Console.WriteLine();
       //         Console.WriteLine("ENter the student Name");
       //         stdName[i] = Convert.ToString(Console.ReadLine()); 
       //         for (int y = 0; y < exams; y++)
       //         { 
       //             Console.Write("Enter Score in Exam " + (y + 1) + ": "); 
       //             details[i, y] = Convert.ToString(Console.ReadLine()); 
       //         } 
       //     }
       //     Console.WriteLine();
       //     Console.WriteLine("Student Exam Details"); 
       //     Console.WriteLine("--------------------"); 
       //     Console.WriteLine(); 
       //     Console.WriteLine("Student\t\tMarks");
       //     Console.WriteLine("-----\t\t-------");
       //     for (int i = 0; i < stdName.Length; i++)
       //     {
       //         Console.WriteLine(stdName[i]); 
       //         for (int j = 0; j < exams; j++) 
       //         { 
       //             Console.WriteLine("\t\t" + details[i, j]); 
       //         } 
       //         Console.WriteLine(); 
       //     }
            
       // }


    } 
}