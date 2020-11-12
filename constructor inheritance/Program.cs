using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            sameer obj = new sameer("Hina");
        }
    }
    class alpha
    {
        string metal;
        public alpha(string type)
        {
            metal = type;
            Console.WriteLine("Metal :\t\t\t" + metal);
        }     
    }
    class marine : alpha
    {
        string grade;
        public marine(string grad):base("sameer")
        {

            grade = grad;
            Console.WriteLine("grade : \t\t\t"+grade);
        }
    }
    class sameer : marine
    {

        string part;
       public sameer(string pagal):base("abdullah")
        {

            part = pagal;
            Console.WriteLine(part);

        }

    }
}
