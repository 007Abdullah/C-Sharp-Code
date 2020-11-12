using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cating_boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            //float a = 45.1f;
            //int b = (int) a;
            //Console.WriteLine(b);

            //Console.WriteLine(c);
            //float ko stering ma kar rqaha han

            //float stnum = 45.00000f;
            //string a = stnum.ToString();
            //Console.WriteLine(a);
            int radius = 10;
            double area;
            area = 3.412 * radius * radius;
            object boxed = radius;
            Console.WriteLine(boxed);
        }
    }
}
