using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boosk_ANY_THING_CHAPTER_CODe
{
    class Program
    {
        static void Main(string[] args)
        {
            //first obj1 = new first();
            //obj1.main();
            //second obj2 = new second();
            //obj2.main2();
            //third obj3 = new third();
            //obj3.cont();
            //four obj4 = new four();
            //obj4.place();
            //five obj5 = new five();
            //obj5.input();
            //six obj6 = new six();
            //seven obj7 = new seven();
            //obj7.sevn();

            //int num = 456;
            //Console.WriteLine("{0:F}",num); 
            //Console.WriteLine("{0:N}", num); 
            //Console.WriteLine("{0:X}", num); 
            //DateTime dt = DateTime.Now; 
            //// Returns short date (MM/DD/YYYY) 
            //Console.WriteLine("Short date format(d): {0:d}", dt); 
            //// Returns long date (Day, Month Date, Year)
            //Console.WriteLine("Long date format (D): {0:D}", dt);
            //// Returns full date with time without seconds 
            //Console.WriteLine("Full date with time without seconds (f):{0:f}", dt); 
            //// Returns full date with time with seconds 
            //Console.WriteLine("Full date with time with seconds (F):{0:F}", dt);
            //// Returns short date and short time without seconds 
            //Console.WriteLine("Short date and short time without seconds (g):{0:g}", dt); 

        }
    }
    //Chapter No 2
    //	Declaration 
    public class first
    {
        //bool boolTest = true;
        //short byteTest = 19;
        //int intTest;
        //string stringTest = "David";
        //float floatTest;

        //public void main()
        //{
        //    floatTest = 14.5f;
        //    intTest = 45;
        //    Console.WriteLine("boolTest = {0}", boolTest);
        //    Console.WriteLine("byteTest = " + byteTest);
        //    Console.WriteLine("intTest = " + intTest);
        //    Console.WriteLine("stringTest = " + stringTest);
        //    Console.WriteLine("floatTest = " + floatTest);

        //}

    }
    //	Implicitly	Typed	Variables
    //include xml comment
    public class second
    {
        //public void main2()
        // {
        //    ///<summary>
        //    ///ABy bhai tu pagal han
        //    ///</summary>


        //     var boolTest = true;
        //     var byteTest = 19;
        //     var intTest = 140000;
        //     var stringTest = "David";
        //     var floatTest = 14.5f;
        //     Console.WriteLine("boolTest = {0}", boolTest);
        //     Console.WriteLine("byteTest = " + byteTest);
        //     Console.WriteLine("intTest = " + intTest);
        //     Console.WriteLine("stringTest = " + stringTest);
        //     Console.WriteLine("floatTest = " + floatTest);
        // }
    }
    //constant
    public class third
    {
        // const float _pi = 3.14F;
        // float radius = 5;
        //public void cont()
        // {
        //     float area = _pi * radius * radius;

        //     Console.WriteLine("Area of the circle is " + area);
        // }

    }
    //Place Holder
    public class four
    {
        // int number, result;
        //public void place()
        // {
        //     number = 5;
        //     result = 100 * number;
        //     Console.WriteLine("Result is {0} when 100 is multiplied by {1}", result, number); 
        //     result = 150 / number; 
        //     Console.WriteLine("Result is {0} when 150 is divided by {1}", +result, number);
        // }
    }
    //User Input
    public class five
    {
        //    string custName;
        //    double loanAmount;
        //    float interest = 0.09F;
        //    double interestAmount = 0;
        //    double totalAmount = 0;
        //    public void input()
        //    {
        //        Console.Write("Enter the name of the customer : ");
        //        custName = Console.ReadLine();
        //        Console.Write("Enter loan amount : ");
        //        loanAmount = Convert.ToDouble(Console.ReadLine());
        //        interestAmount = loanAmount * interest;
        //        totalAmount = loanAmount + interestAmount;
        //        Console.WriteLine("\nCustomer Name : {0}", custName);
        //        Console.WriteLine("Loan amount : ${0:#,###.#0} \nInterest rate  : {1:0#%} \nInterest Amount : ${2:#,###.#0}", loanAmount, interest, interestAmount);
        //        Console.WriteLine("Total amount to be paid : ${0:#,###.#0} ", totalAmount);
        //    }

    }
    //Convert Mehtod
    //public class six
    //{
    //    string userName;
    //    int age;
    //    double salary;
    //   public six()
    //    {
    //        Console.Write("Enter your name: ");
    //        userName = Console.ReadLine();
    //        Console.Write("Enter your age: ");
    //        age = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the salary: ");
    //        salary = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine("Name: {0}, Age: {1}, Salary: {2} ", userName, age, salary);
    //    }

    //}
    //public class seven
    //{
    //    double loanAmount = 15590;
    //    float interest = 0.09F;
    //    double interestAmount = 0; 
    //    double totalAmount = 0;
    // public   void sevn()
    //    {
    //        interestAmount = loanAmount * interest;
    //        totalAmount = loanAmount + interestAmount;
    //        Console.WriteLine("Loan amount : ${0:#,###.#0} ", loanAmount);
    //        Console.WriteLine("Interest rate : {0:0#%} ", interest);
    //        Console.WriteLine("Total amount to be paid :${0:#,###.#0}", totalAmount);
    //    }
    //}
}
