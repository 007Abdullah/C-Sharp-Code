using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        //protected string food;
        //protected string activity;

        static void Main(string[] args)
        {
            //abdullah obj = new abdullah();
            //obj.food = "sasavs";
            //obj.activity = "safsadfsfasfasd";
            //Console.WriteLine(obj.food + "..");
            //Console.WriteLine(obj.activity);
            //pagal obj1 = new pagal();
            //obj1.main();
            department obj = new department();
            obj.diplay();
         
        }
    }
    
    //class abdullah : Program
    //{
    //    public void main()
    //    {

    //        Console.WriteLine("abdullah ");

    //    }
        

    //}
    //class pagal : abdullah
    //{
    //    public void main()
    //    {

    //        base.main();
    //        Console.WriteLine("pagal ");

    //    }





    //}

    class Employee
    {

        int empid = 1;
        string empname = "sameer";
       

        public void diplay()
        {
            Console.WriteLine("Employee id "+ empid);
            Console.WriteLine("employee name :"+empname);
        }
    }
  class department : Employee
    {
        int departid = 509;
        string departname = "salary";
       new void diplay()
            
        {
            base.diplay();         

            Console.WriteLine("department id:"+departid);
            Console.WriteLine("department name"+departname);
            base.diplay();

        }




    }
}