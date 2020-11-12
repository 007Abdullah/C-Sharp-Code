using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s6
{
    static class forstat
    {
        internal static int a = 7;
        static forstat() {
            a = 9;
        
        }

     
       internal static void print() {
           Console.WriteLine(a);
           a = 8;
       }
       


    }
    class insclass
    {
        
        internal int a = 7;
        internal void print()
        {
            Console.WriteLine(a);
           a = 8;
        }
    }
}
