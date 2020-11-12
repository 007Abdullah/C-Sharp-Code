using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void SquareDel(int number);
    public delegate void sae();
    
    class Program : example
    {
        static void Main(string[] args)
        {
            example obj1 = new example();
            sae md;
            md = new sae(sa);
            md.Invoke();
            obj1.emloe();
            Func<string, string> obj = new Func<string, string>(sho);
            obj.Invoke("sa");
            //SquareDel md, mb;
            //md = new SquareDel(Square);
            //mb = new SquareDel(Cube);
            //md.Invoke(4);
            //mb.Invoke(5);
            //SquareDel obj = new SquareDel(Square);
            //obj.Invoke(5);
            //obj = Cube;
            //obj(3);
          

        }
    }

    class example
    {

        event SquareDel myevent;

        public void emloe()
        {
            Console.WriteLine("pagal han tu"+this.myevent);
        
        }
        public static void sa()
        {
            
            Console.WriteLine("baba baba han");
        }

        public static string sho(string a)
        {
            Console.WriteLine("Method Running\t" + a);
            return a;
        }
        public static void Square(int number)
        {
            Console.WriteLine(" square of {0} is {1}", number, number * number);
        }

        public static void Cube(int number)
        {
            Console.WriteLine(" Cube of {0} is {1}", number, number * number * number);
        }


    }
}