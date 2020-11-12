using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //forthis ft = new forthis();
            fc f = new fc();
        }
    }
    public class fc{
        
    public fc(){
        Console.WriteLine("Constructor invokes here...");
    }
    ~fc()
    {
        Console.WriteLine("Destructor for this class");
    }
    
    }











    public class forthis {
        int a;


        //private forthis() { }
       // public forthis() { }
        internal forthis() { }


        void print(int a) {
            this.a = a;
        
        }
       
    
    
    }
}
