using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //abdullah obj = new abdullah();
        //    obj.main();
        //    //sameer obj1 = new sameer();
        //    //obj1.main();
            Student obj = new Student();
            Grade obj1 = new Grade();
            obj.PrintDetails(); 
            obj1.PrintDetails();

        }
    }
   //public class sameer
   // {
   //     public void main()
   //     {

   //         Console.WriteLine("parent class metgode");
   //     }

   // }
   //public class abdullah : sameer
   // {
   //      public new void main()
   //     {
   //         Console.WriteLine("child class methoe");
   //     }

   // }

    class Student
    {
        string name = "sameer";
        string address = "Germany";
        public virtual void PrintDetails()
        {

            Console.WriteLine("Student of NAme: " +name);
            Console.WriteLine("Address: " +address);

        }

    }
    class Grade:Student
    {
        string Class = "Four";
        float percent = 100.45F;

        public override void PrintDetails()
        {
            Console.WriteLine("Class :"+Class);
            Console.WriteLine("percent :"+percent);
        }



    }








    



}
