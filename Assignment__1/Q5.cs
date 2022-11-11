using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Q5
    {
        public static void Main(string[] args)
        {
            double r, AREA;

            const double PI = 3.14;

            Console.Write("Enter the radius of circle : ");

            r = Convert.ToDouble(Console.ReadLine());

            AREA = PI * r * r;
            double circumference = 2 * PI * r;

            Console.WriteLine("The area of circle is : {0} ", AREA);

            Console.WriteLine("The circumference of circle is : {0}", circumference);

        }

    }
}
