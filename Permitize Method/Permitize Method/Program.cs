using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permitize_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            sameer obj = new sameer();
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            string c = obj.main("PAGAL","MARI JAAN");
            Console.WriteLine("this is method "+c);
        }
    }
    public class sameer
    {
        public string a = "Razzaaq";
        public string b = "Abdullah";

        public string main(string a, string b)
        { 
            this.a = a;
            this.b = b;
            return a +""+ b.ToString();
        }
    
    
    
    }
}
