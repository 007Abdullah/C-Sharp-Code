using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using MyNamespace;

namespace OR
{
    class Program
    {
        static void Main(string[] args)
        {
            X x = new X();
            x.Age = -5;
            Console.WriteLine(x.Age);

            Class1 cv = new Class1();

            C cc = new C();


        }
    }

    class baree {

        public int MyProperty { get; set; }
        public virtual void eat() {
            Console.WriteLine("Bara eat");
        }


    }

    class X
    {

        int age;

        public int Age
        {
            get

            {
                return age;
            }

            set
            {
                if (age > 0)
                {
                    age = value;
                }
                //else{
                //    age=0;
                //}
            }
        }


    }

class Choti : baree, ia {

        public int MyProperty { 
            private get; set;
        
        }
        
        


       
        //public new void eat() {
        //    Console.WriteLine("Chota eat");
        
        //}

        public void ikamethod()
        {
            
        }
    }


    interface ia {

         void ikamethod();
    }
}


