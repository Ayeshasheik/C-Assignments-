using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado__project
{
    internal class Delete
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Author: Ayesha Siddiqa Sheik
            /// Class Name: Reterive.cs
            /// Created On : 8th Nov, 2022
            /// Description : In Main Method written lines of code to connect to DataBase and delete the required data from Database
            /// </summary>

            SqlConnection sqlConnection;

            //Connection string to Establish the connection to the SQL DataBase
            string connectionString = @"Data Source=ayeshaVM;Initial Catalog=Siddiqa;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //As we need to delete only one Particular Data which user is going to enter
            Console.WriteLine("Please Enter Employee Id Which You Want To Delete : ");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            //Query to delete the Row in Employee Table for the Entered Employee ID particular Data Only
            string deletequery = "Delete from Employee where EmpID= " + EmpId + "";
            SqlCommand deletecommand = new SqlCommand(deletequery, sqlConnection);
            deletecommand.ExecuteNonQuery();

            Console.WriteLine("\nData Deleted");
            Console.ReadLine();
            sqlConnection.Close();

            /*
            * Here We are using ADO .NET concepts to achieve the user inputs to store in DB Table
            * In this Program We have connected to DB using Connection String 
            * Taken then inputs from user with console application
            * Stroed the inputs in Variables 
            * Passed the vairabled into Delete and 
            * Deleted the required particular Data into the Table
            */
        }

    }
}