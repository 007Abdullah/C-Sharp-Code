using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace chapter_no_2
{
    class Program
    {
        static void Main(string[] args)
        {

            sameer obj = new sameer();
            obj.main(5,45);
            ///int a = 15;
            ///</summary>
            DateTime dt = DateTime.Now;
            Console.WriteLine("Sameer Khan {0:d}", dt);
            Console.WriteLine("Sameer Khan {0:D}", dt);
            Console.WriteLine("");
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;

            try
            {
                unchecked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result: " + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
    class sameer {

       public void main(int num,int sum)
        {
            Console.WriteLine("Sameer     Abdullah      Khan");
            Console.WriteLine("Sameer     Abdullah      Khan");
            Console.WriteLine("Sameer     Abdullah      Khan");
            Console.WriteLine("Sameer     Abdullah      Khan");
            Console.WriteLine("Sameer     Abdullah      Khan");
            Console.WriteLine("Sameer     Abdullah      Khan");
            Console.WriteLine("Sameer     Abdullah      Khan");
            Console.WriteLine("Sameer     Abdullah      Khan");
            Console.WriteLine("Sameer     Abdullah      Khan");
        }
    }
}