using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametiz_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            sameer obj = new sameer();
          string c =   obj.disply("Shazaib","razzaq");
          Console.WriteLine(c);
        }
    }
   public class sameer
    {
      public string a = "sameer";
      public string b = "Abdullah";


       public string disply(string a , string b)
       {
           this.a = a;
           this.b = b;
           return ""+a+b.ToString();

        
       
       }
       
       
    
    
    
    
    }
}
