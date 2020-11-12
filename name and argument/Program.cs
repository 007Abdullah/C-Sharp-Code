using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_and_argument
{
    class Program
    {
        static void Main(string[] args)
        {
            sameer obj = new sameer();
            obj.main(number:45,name:"sameer",fname:"younus");
            obj.main(name: "sameer",number:45, fname: "younus");
            
        }
    }
    class sameer
    {

        public void main(int number,string name , string fname)
        {
            Console.WriteLine("Enter a name  = {0} ,father  name  = {1}, number  = {2}",name,fname,number);
        }

       // string name;
       // public string retun()
       // {

       //     return name;

       // }
       //public void input(string bkname,int a,int b)
       // {

       //     bkname = name;



        }




    }

