using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Q3
    {
        public static void Main(string[] args)
        {
            int[] number = { 10, 20, 30, 40 };

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + number[i];
            }


            Console.WriteLine("the sum is {0}", sum);

        }
    }
}
