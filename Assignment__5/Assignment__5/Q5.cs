using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__5
{
    internal class Q5
    {
        public class Employee
        {
            int ID;
            string Name;
            string Company;
            static void Main(string[] args)
            {
                bool isExist = false;

                List<Employee> Employees = new List<Employee>()
        {
             new Employee {Company="Capgemini", ID=101,   Name="Ayesha" },
             new Employee {Company="IGate", ID=102,   Name="Siddiqa"   },

        };


                Employee Emp1 = new Employee() { ID = 101, Name = "Ayesha", Company = "Capgemini" };

                isExist = Employees.AsEnumerable().Contains(Emp1);

                if (isExist == true)
                    Console.WriteLine("Employee exists in the Employees list");
                else
                    Console.WriteLine("Employee does not exist in the Employee's list");
                Console.ReadLine();
            }
        }
    }
}
