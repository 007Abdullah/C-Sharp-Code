using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_mehtod
{
    class Program
    {
        static void Main(string[] args)
        {
            sameer obj = new sameer();
            Console.WriteLine(obj.GetType().Name);
            obj.Habitat();
            obj.drink();
            obj.eat();
            Console.ReadLine();
        }
    }
    interface IAnimal 
    {
        void drink();

    }
    interface ICarnivorous 
    {

        void eat();


    }
    interface  IReptile : IAnimal,ICarnivorous
    {
        void Habitat();

    }
    class sameer : IReptile
    {
        public void drink()
        {

            Console.WriteLine("drink fresh water ");
        }
        public void eat()
        {

            Console.WriteLine("Eats fresh");
        }
        public void Habitat()
        {
            Console.WriteLine("Can stay in water land");
        }

    }

}
