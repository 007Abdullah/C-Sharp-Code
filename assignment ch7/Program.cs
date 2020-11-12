using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_ch7
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle objRectangle = new Rectangle(10.2F, 20.3F); 
            if (objRectangle is ICalculate) 
            { 
                Console.WriteLine("Area of rectangle: {0:F2}" , objRectangle.Area()); 
            } 
            else 
            { 
                Console.WriteLine("Interface method not implemented"); 
            }
        }
    }
    interface ICalculate
    {
        double Area();
    }
    class Rectangle : ICalculate 
    {
        float length;
        float breadth;
        public Rectangle(float valOne, float valTwo) 
        {
            length = valOne; breadth = valTwo; 
        }
        public double Area()
        {
            return length * breadth; 
        }
    }
}
