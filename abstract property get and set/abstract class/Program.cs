using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public abstract class anminal
    {
        public void eat()
        {
            Console.WriteLine("Every animal eats food in order to survive");
        }
        public abstract void anminalsound();

    }
    class sameer : anminal
    {

        public override void anminalsound()
        {
            Console.WriteLine("lions ");
        }



    }
}
