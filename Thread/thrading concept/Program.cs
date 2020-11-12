using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thrading_concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread obj = Thread.CurrentThread;
            obj.Name = "sameer";
            Console.WriteLine(obj.Name);
        }
    }
}
