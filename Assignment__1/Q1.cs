using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Q1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Select the Digit for Calculations......");

            Console.WriteLine("Please press 1 for Addition");
            Console.WriteLine("Please Press 2 for Subtraction");
            Console.WriteLine("Please press 3 for Multiplication");
            Console.WriteLine("Plese press 4 for Division");

            int action = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Digit 1");
            int Digit1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Digit 2");
            int Digit2 = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    int sum = Digit1 + Digit2;
                    Console.WriteLine("The Added Value is {0}", sum);
                    break;
                case 2:
                    int difference = Digit1 - Digit2;
                    Console.WriteLine("The Subtracted value is {0}", difference);
                    break;

                case 3:
                    int multiplication = Digit1 * Digit2;
                    Console.WriteLine("The Multiplied value is {0}", multiplication);
                    break;

                case 4:
                    if (Digit2 != 0)
                    {
                        int division = Digit1 / Digit2;
                        Console.WriteLine("The Divided value is {0}", division);
                    }
                    if (Digit2 == 0)
                    {
                        Console.WriteLine("Digit 2 Should be Greater than 0");

                    }
                    break;


                default:
                    Console.WriteLine("Wrong Selection, Please try Again!!!!!");
                    break;
            }
        }
    }
}
