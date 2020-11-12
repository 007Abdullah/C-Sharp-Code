using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s6
{
    class Program
    {
        static void Main(string[] args)
        {
            //insclass ic = new insclass();
            //forstat.print();
            //ic.print();
            //Console.WriteLine(forstat.a);
            Beta b = new Beta();

            b.show2();
            //Alpha a = new Alpha();
            //a.show2();
            
        }
    }
    //public class Alpha
    //{
    //    public Alpha() { Console.WriteLine("class of alpha"); }
    //    //public void show1() { Console.WriteLine(" Show1 Class of Alpha"); }

    //    //internal  void show2() { Console.WriteLine("Show2 Class of Alpha"); }
    //}
    //public class Beta : Alpha
    //{
    //    public Beta() { { Console.WriteLine("class of beta"); } }
    //    internal new void show2()
    //    {
    //        Console.WriteLine("Show2 Class of Beta");

    //        base.show2();
    //    }
    //    protected override void show2()
    //    {
    //        Console.WriteLine("Class of Beta");
    //    }
    //    public void showall()
    //    {

    //        show2();
    //    }

    //}


}