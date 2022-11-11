using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemt__3
{
    internal class Q1
    {
        interface IPrintable
        {
            void managernetsalary();
        }
        class CalculateSalary
        {

            public void managersalary(double manager_salary)
            {
                manager_net_salary = manager_salary;
                manager_petrol_allowance = 0.08 * manager_salary;
                manager_food_allowance = 0.13 * manager_salary;
                manager_other_allowance = 0.03 * manager_salary;

            }
            public void marketexecsalary(double marketexecsalary, int Marketexec_Kms)
            {
                marketing_exec_salary = marketexecsalary;
                marketing_exec_kms_cost = Marketexec_Kms * 5;

            }
            public double manager_net_salary;
            public double manager_petrol_allowance;
            public double manager_food_allowance;
            public double manager_other_allowance;
            public double marketing_exec_salary;
            public int marketing_exec_kms_cost;
            public int marketing_Tele_allowance = 1000;

        }
        class EmpTotalSalary : CalculateSalary
        {
            public double managernetsalary()
            {
                return (manager_net_salary + manager_petrol_allowance + manager_food_allowance + manager_other_allowance);
            }

            public double marketingexecutivesalary()
            {
                return (marketing_exec_salary + marketing_exec_kms_cost + marketing_Tele_allowance);
            }
        }
        public static void Main(string[] args)
        {
            EmpTotalSalary calc = new EmpTotalSalary();

            EmpEntities emp = new EmpEntities();

            Console.WriteLine("******************************************************************");
            Console.WriteLine("###################EMPLOYEE SALARY DETAILS########################");
            Console.WriteLine("******************************************************************");

            Console.WriteLine("Please Enter The Employee Number : ");
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());
            if (emp.EmpNo <= 0)
            {
                Console.WriteLine("Employee Number Should be Greater Than 0  : ");
                Console.WriteLine("Please Enter The Employee Number : ");
                emp.EmpNo = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Please Enter The Employee Name : ");
            emp.EmpName = Console.ReadLine();
            if (emp.EmpName == "" || emp.EmpName == null)
            {
                Console.WriteLine("Employee Name Should Not be Empty: ");
                Console.WriteLine("Please Enter The Employee Name : ");
                emp.EmpName = Console.ReadLine();
            }

            Console.WriteLine("Please Enter The Employee Salary : ");
            emp.Salary = Convert.ToInt32(Console.ReadLine());

            if (emp.Salary != null)
            {
                if (emp.Salary <= 0)
                {
                    Console.WriteLine("Employee Salary Should be Greater Than 0 : ");
                    Console.WriteLine("Please Enter The Employee Salary : ");
                    emp.Salary = Convert.ToInt32(Console.ReadLine());
                }
                if (emp.Salary <= 5000)
                {
                    emp.HRA = 0.1;
                    emp.TA = 0.05;
                    emp.DA = 0.15;

                }
                if (emp.Salary > 5000 && emp.Salary <= 10000)
                {
                    emp.HRA = 0.15;
                    emp.TA = 0.1;
                    emp.DA = 0.2;

                }
                if (emp.Salary > 10000 && emp.Salary <= 15000)
                {
                    emp.HRA = 0.2;
                    emp.TA = 0.15;
                    emp.DA = 0.25;

                }
                if (emp.Salary > 15000 && emp.Salary < 20000)
                {
                    emp.HRA = 0.25;
                    emp.TA = 0.2;
                    emp.DA = 0.3;

                }
                if (emp.Salary >= 20000)
                {
                    emp.HRA = 0.3;
                    emp.TA = 0.25;
                    emp.DA = 0.35;

                }
            }

            emp.GrossSalary = emp.Salary + emp.HRA + emp.TA + emp.DA;
            Console.Write("The Gross Salary of {0}  is  {1}  ", emp.EmpName, emp.GrossSalary);

            emp.PF = 0.1 * emp.GrossSalary;
            Console.Write("\nPF Amount for {0} is {1}", emp.EmpName, emp.PF);

            emp.TDS = 0.18 * emp.GrossSalary;
            Console.Write("\nTDS Amount for {0} is {1} ", emp.EmpName, emp.TDS);

            emp.NetSalary = emp.GrossSalary - (emp.PF + emp.TDS);
            Console.Write("\nNet Salary for {0} is {1} ", emp.EmpName, emp.NetSalary);

            calc.managersalary((double)emp.Salary);//------need to go to method
            Console.WriteLine("\nThe Manager Salary  is : {0} ", calc.managernetsalary());//---------------need to go to method

            Console.WriteLine("Please Enter The Number of KMs travelled by Marketing Executive : ");
            emp.Mar_exec_Kms = Convert.ToInt32(Console.ReadLine());

            calc.marketexecsalary((double)emp.Salary, emp.Mar_exec_Kms); //need to go to method
            Console.WriteLine("\nThe Marketing Salary  is : {0} ", calc.marketingexecutivesalary()); //-----------------need to go to method
            Console.ReadLine();
        }


    }

}