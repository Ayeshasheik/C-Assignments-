using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__5
{
    public class Q3
    {
        // Main Method
        static public void Main()
        {
            EmpDetails emp = new EmpDetails();
            LinkedList<String> my_list = new LinkedList<String>();

            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please Enter The Player  {0} ID : ",i+1);
                emp.Emp1_Id = Convert.ToInt32(Console.ReadLine());
                my_list.AddLast(emp.Emp1_Id.ToString());

                Console.WriteLine("Please Enter The Player {0} Name : ", i+1);
                emp.Emp1_Name = Console.ReadLine().ToString();
                my_list.AddLast(emp.Emp1_Name.ToString());


                Console.WriteLine("Please Enter The Player {0} Company : ", i+1);
                emp.Emp1_Company = Console.ReadLine().ToString();
                my_list.AddLast(emp.Emp1_Company.ToString());

                Console.WriteLine("------------------------------------------------------------------------------------ ");
                Console.WriteLine("------------------------------------------------------------------------------------ ");
                Console.WriteLine("------------------------------------------------------------------------------------ ");

            }

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}