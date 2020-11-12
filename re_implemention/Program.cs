using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace re_implemention
{
    class Program
    {
        static void Main(string[] args)
        {


            Rectangular obj1 = new Rectangular(10.2f,20.3f);
            if (obj1 is ICalculate) 
            { 
                Console.WriteLine("Area of rectangle: {0:F2}" , obj1.Area());
            } 
            else { 
                Console.WriteLine("Interface method not implemented"); 
            }


            //Sphere obj = new Sphere();
            //obj.Radius = 7;
            //obj.Area();
            //Console.WriteLine("Area OF Circle: {0:F2} " +obj.areaOfSphere);

        }
    }
    interface ICalculate
    {
        double Area();
    }
    class Rectangular : ICalculate
    {
        float lenght;
        float breath;

        public Rectangular(float valone,float valtwo)
        {
            lenght = valone;
            breath= valtwo;
        }
        public double Area()
        {
            return lenght * breath; 
        }
    }
    
    




















//    interface Imath
//    {

//        void Area();
//    }
//  public  class Circle : Imath
//    {
//        public const float PI = 3.14F;
//        public float Radius;
//        protected double AreaOfCircle;
//        public virtual void Area()
//        {
//            AreaOfCircle = (PI * Radius * Radius);
//        }
//    }
//public class Sphere:Circle
//    {
//      public  double areaOfSphere;
//        public override void Area()
//        {
//            base.Area();
//            areaOfSphere = (AreaOfCircle * 4);
            
//        }
//    }
}
