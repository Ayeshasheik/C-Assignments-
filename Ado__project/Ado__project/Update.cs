using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado__project
{
    internal class Update
    {
        /// <summary>
        /// Author: Ayesha Siddiqa Sheik
        /// Class Name: Reterive.cs
        /// Created On : 8th Nov, 2022
        /// Description : In Main Method written lines of code to connect to DataBase and Update the Particular Data
        ///  which was entered by the user in the console 
        /// </summary>
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            //Connection String to connect the Database
            string connectionString = @"Data Source=ayeshaVM;Initial Catalog=Siddiqa;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //Console to Read the Employee Details are store in the Variables
            Console.WriteLine("Please Enter Employee Id Which You Want To Update : ");
            int EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter Updated Employee First Name  ");
            string EmpFName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Updated Employee Last Name  ");
            string EmpLname = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Updated Employee Salary : ");
            int EmpSalary = Convert.ToInt32(Console.ReadLine());

            //Update Query to Update the Above Entered Details in Employee Table for the Particular Record
            string updatequery = "update Employee set EmployeeFirstName ='" + EmpFName + "', EmployeelastName= '" + EmpLname + "',Employeesalary='" + EmpSalary + "' where EmpID= " + EmpId + "";
            SqlCommand updatecommand = new SqlCommand(updatequery, sqlConnection);
            updatecommand.ExecuteNonQuery();

            Console.WriteLine("\nData Updated");
            Console.ReadLine();
            sqlConnection.Close();
            /*
            * Here We are using ADO .NET concepts to achieve the user inputs to store in DB Table
            * In this Program We have connected to DB using Connection String 
            * Taken then inputs from user with console application
            * Stroed the inputs in Variables 
            * Passed the vairabled into Update Query and 
            * Updated the Data into the Table
            */
        }
    }
}
