using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, Ch;
            string Continue;
            do {
                Console.WriteLine("Enter Two Integers");
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                Console.Write("Enter your choice(1 for Add, 2 for Sub, 3 for Mul , 4 for Div , 5 for Mod):");
                Ch=int.Parse(Console.ReadLine());
                switch(Ch)
                {
                    case 1:
                        Console.WriteLine("Sum is {0}",A+B);
                        break;
                    case 2:
                        Console.WriteLine("Difference is {0}",A - B);
                        break;
                    case 3:
                        Console.WriteLine("Product is {0}",A * B);
                        break;
                    case 4:
                        Console.WriteLine("Ratio is {0}", A / B);
                        break;
                    case 5:
                        Console.WriteLine("Modulus is {0}",A % B);
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.Write("Do you want to continue? (Y/N):");
                Continue=Console.ReadLine();
            } while(Continue!="N"&&Continue!="n");


        }
    }
    }

