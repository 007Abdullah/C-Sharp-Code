using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_calculater_nested_caseing
{
    public class Class1
    {

        int a;
        int b;
        int result = 0;
        public void display()
        {
            Console.WriteLine("(1) ADDITION");
            Console.WriteLine("(2) SUBTRACTION");
            Console.WriteLine("(3) MULTIPILCATION");
            Console.WriteLine("(4) DIVISION");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A FIRST NUMBER ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second  NUMBER ");
            b = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    {
                        result = a + b;
                        break;
                    }
                case 2:
                    {
                        result = a - b;
                        break;
                    }
                case 3:
                    {
                        result = a * b;
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Do you want to calculate the quotient or remainder?");
                        Console.WriteLine("(1) Quotient");
                        Console.WriteLine("(2) Remainder");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    result = a / b;
                                    break;
                                }
                            case 2:
                                {
                                    result = a % b;
                                    break;
                                }
                            default:
                                {

                                    Console.WriteLine("Incorrect Choice");
                                    break;
                                }

                                
                        }
                        break;
                        
                    }
                    
            }

        }
    }
}