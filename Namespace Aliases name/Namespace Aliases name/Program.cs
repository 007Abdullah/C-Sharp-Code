using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using th = bob;


namespace Namespace_Aliases_name
{
    class Program
    {
        static void Main(string[] args)
        {
            th.FirstClass obj = new th.FirstClass();
            obj.main();
            second.SecondClass  obj1 = new second.SecondClass();
            obj1.main();
        }
    }
    
}
