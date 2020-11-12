using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s6
{
    class Book
    {
        string bookname;
        internal void input(string value, int pages, bool b)
        {
            bookname = value;
            Console.WriteLine(bookname + " " + pages + "" + b);
        }
        //internal string print()
        //{
        //    return bookname;

        //}
        void extramain()
        {
            //bn.print();

            /*string bk = bn.print();
            Console.WriteLine(bk); */

            // Console.WriteLine(bn.print());

            Book bn = new Book();
            // bn.input("Good to gr8",220,true);
           // bn.input(true, pages: 220, value: "why?"); //find out the error in the statement
           // bn.input(220, true, value: "bnm");
            //bn.input("xyz", pages: 330);




            //bn.input(110, value: "xyz");}


        }
    }
}

