using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemt__3
{

    interface calcempsalary
    {
        void calculateempsalary(double salary, double PF);

    }

    class SalaryDetails : calcempsalary
    {

        public void calculateempsalary(double salary, double PF)
        {

            double salaryPF = salary + PF;
            Console.WriteLine("Salary + PF = : " + salaryPF);
            Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            SalaryDetails r1 = new SalaryDetails();

            EmpEntities emp = new EmpEntities();

            Console.WriteLine("Please Enter The Employee Number : ");
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Employee Salary : ");
            emp.Salary = Convert.ToInt32(Console.ReadLine());

            emp.PF = 0.1 * emp.Salary;

            r1.calculateempsalary(emp.Salary, emp.PF);  //----need to go to method

        }
    }
}
