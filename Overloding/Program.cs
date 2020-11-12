using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloding
{
    class Program
    {
        static void Main(string[] args)
        {

            ////sameer obj = new sameer();
            ////            Console.WriteLine(obj.addtion(45, 45 ,5));
            //Circle obj = new Circle(45,45);
            //Console.WriteLine(obj.main(4));   
            abdullah obj = new abdullah();
            obj.mian();



        }
    }
    //public class Circle {

    //    int a;
    //    int b;
    //    int sum;
    //    public Circle(int c, int d)
    //    {
    //        a = c;
    //        b = d;
    //        sum = c + d;
    //        Console.WriteLine(sum);
           
    //    }
    //   public int main(int muti)
    //    {

    //        muti = a * b;
    //        return muti;

    //    }
       
    //}

    public class sameer
    {
        public virtual void mian()
        {

            Console.WriteLine("Parent class methode");
        }
    }
   public class abdullah : sameer
    {
     public new void main()
        {

            Console.WriteLine("child class methode");
        }

    }


}
       
 
   //public class sameer
   // {
   //   public  int addtion(int valone, int valtwo)
   //     {
   //         return valone + valtwo;
   //     }
   //   public  int addtion(int valone, int valtwo,int valthree)
   //     {
   //         return valone + valtwo + valthree;
   //     }    
   // }
