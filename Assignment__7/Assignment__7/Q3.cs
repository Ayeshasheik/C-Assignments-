using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__7
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Employee pu = new Employee();
            pu.MarketingExec();
            pu.Manager();
            Console.WriteLine("Is Geeks1 class is serializable or not?:" +
                      typeof(Employee).IsSerializable);
            Console.ReadLine();
        }
        [Serializable]
        public class Employee
        {
            public void MarketingExec()
            {
                Customer CustomerDetail = new Customer();
                Console.Write("Please Enter Customer Id:");
                CustomerDetail.Id = int.Parse(Console.ReadLine());

                Console.Write("Please Enter Customer Name:");
                CustomerDetail.Name = Console.ReadLine();

                Console.Write("Please Enter Customer Address:");
                CustomerDetail.Address = Console.ReadLine();

                string[] lines = { CustomerDetail.Id.ToString(), CustomerDetail.Name, CustomerDetail.Address };
                string filepath = @"C:\Ayesha\Training\Assignment__7\Assignment__7\Q3_MarketingExecutive.txt";
                File.WriteAllLinesAsync(filepath, lines);
            }
            public void Manager()
            {
                Customer CustomerDetail = new Customer();
                Console.Write("Please Enter Manager Id:");
                CustomerDetail.Id = int.Parse(Console.ReadLine());

                Console.Write("Please Enter Manager Name:");
                CustomerDetail.Name = Console.ReadLine();

                Console.Write("Please Enter Manager Address:");
                CustomerDetail.Address = Console.ReadLine();

                string[] lines = { CustomerDetail.Id.ToString(), CustomerDetail.Name, CustomerDetail.Address };
                string filepath = @"C:\Ayesha\Training\Assignment__7\Assignment__7\Q3_Manager.txt";
                File.WriteAllLinesAsync(filepath, lines);

            }
        }
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }


    }
}
