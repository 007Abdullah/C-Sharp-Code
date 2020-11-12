using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Habitat();
            obj.baba();
        }
    }
    interface IAnimal
    {
        void Habitat();
    }
    interface Pagal
    {
        void baba();

    }
    class Dog : IAnimal,Pagal
    {
        public void Habitat()
        {
            Console.WriteLine("Can be housed with human beings");
        }

       public void baba()
        {
            Console.WriteLine("babaq ka method");
        
        }
    }
}