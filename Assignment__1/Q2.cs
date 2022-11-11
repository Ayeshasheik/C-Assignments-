using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Q2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the average marks of student1");
            decimal student1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the average marks of student2");
            decimal student2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the average marks of student3");
            decimal student3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the average marks of student4");
            decimal student4 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the average marks of student5");
            decimal student5 = Convert.ToDecimal(Console.ReadLine());

            if (student1 <= 0 || student2 <= 0 || student3 <= 0 || student4 <= 0 || student5 <= 0)
            {
                if (student1 > student2 && student1 > student3 && student1 > student4 && student1 > student5)
                {
                    Console.WriteLine("studnet 1 having Highest Avg Marks");
                }

                if (student2 > student1 && student2 > student3 && student2 > student4 && student2 > student5)
                {
                    Console.WriteLine("student 2 having Highest Avg Marks");
                }
                if (student3 > student1 && student3 > student2 && student3 > student4 && student3 > student5)
                {
                    Console.WriteLine("student 3 having Highest Avg Marks");
                }
                if (student4 > student1 && student4 > student2 && student4 > student3 && student4 > student5)
                {
                    Console.WriteLine("student 4 having Highest Avg Marks");

                }
                if (student5 > student1 && student5 > student2 && student5 > student3 && student5 > student4)
                {
                    Console.WriteLine("student 5 having Highest Avg Marks");
                }
            }
            Console.WriteLine("student Average Marks should be Greater than zero");
        }

    }
}
