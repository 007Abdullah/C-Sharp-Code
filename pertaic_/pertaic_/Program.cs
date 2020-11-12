using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertaic_
{
    class Program
    {
        static void Main(string[] args)
        {

            int radius = 10;
            double area;
            area = 3.142 * radius * radius;

            object boxed = area;
            Console.WriteLine(boxed);

        }
    }

}
