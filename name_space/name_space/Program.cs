using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_space;
using name_space.sameer;
using name_space.sameer.abdllah;

namespace name_space
{
    class Program
    {
        static void Main(string[] args)
        {
            abdullah obj = new abdullah();
            sa obj1 = new sa();
            obj.main();
            obj1.main();
        }
    }
    namespace sameer
    {
        public class abdullah
        {

            public void main()
            {

                Console.WriteLine("sameer");

            }

        }
        namespace abdllah
        {
           public class sa
            {
               public void main() {

                    Console.WriteLine("dusra namepace");
                }
            }
        }
    }
}
