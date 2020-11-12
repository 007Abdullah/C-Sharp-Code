using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cash_withdwra
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 25000;
            Console.WriteLine("Enter a Pin :");
            int pin;
            pin = Convert.ToInt32(Console.ReadLine());
            if (pin == 57269)
            {
                
                Console.WriteLine(" ****************1 Cash WIthdraw***********************************");
                Console.WriteLine(" ****************2 Balanaces Check*********************************");
                Console.WriteLine(" ****************3 Loans*******************************************");
                Console.WriteLine(" ****************4 Fund Transfer **********************************");
                Console.WriteLine("Select any one option :");
                int input;
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            if (amount < 250000)
                            {
                                Console.WriteLine("Enter a Amount  Withdraw:");
                                int a1;
                                a1 = Convert.ToInt32(Console.ReadLine());
                                int a2 = a1 - amount;
                                Console.WriteLine("Your Remaining  amount :" + a2);
                                
                            }
                            else
                            {
                                Console.WriteLine("BAlance HAs been 0 :");
                            }
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("Two Ak Mint :");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("");

                            break;
                        }
                    case 4:
                        {
                            break;
                        }


                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Pin");
            }
        }
    }
}
