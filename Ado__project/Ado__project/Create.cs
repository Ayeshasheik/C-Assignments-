using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado__project
{
    internal class Create
    {
        /// <summary>
        /// Author: Ayesha Siddiqa Sheik
        /// Class Name: Create.cs
        /// Created On : 8th Nov, 2022
        /// Description : In Main Method written lines of code to connect to DataBase and Accept the Employee Detais from console
        ///               and create the same in Given Table
        /// </summary>
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            //SQL Connection string
            string connectionString = @"Data Source=ayeshaVM;Initial Catalog=Siddiqa;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //Console to Read the Employee Details are store in the Variables
            Console.WriteLine("Please Enter Employee Id : ");
            int EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter Employee First Name : ");
            String EmpFName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Last Name  : ");
            String EmpLname = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Salary : ");
            int EmpSalary = Convert.ToInt32(Console.ReadLine());


            //Insert Query, the details which are given will be taken here and forms the insert query and inserts the data in DB
            string insertQuery = "insert into Employee(EmpID, EmployeeFirstName, EmployeelastName, Employeesalary) Values('" + EmpId + "','" + EmpFName + "','" + EmpLname + "','" + EmpSalary + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Inserted");
            sqlConnection.Close();

            /*
             * Here We are using ADO .NET concepts to achieve the user inputs to store in DB Table
             * In this Program We have connected to DB using Connection String 
             * Taken then inputs from user with console application
             * Stroed the inputs in Variables 
             * Passed the vairabled into insertquery and 
             * Inserted the Data into the Table
             */
        }
    }
}
