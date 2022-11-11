using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.ComponentModel.Design.Serialization;

namespace Ado__project
{
    public class Reterive
    {
        public static void Main()
        {
            /// <summary>
            /// Author: Ayesha Siddiqa Sheik
            /// Class Name: Reterive.cs
            /// Created On : 8th Nov, 2022
            /// Description : In Main Method written lines of code to connect to DataBase and fetch the required data from Databse
            /// and show the same to user in console application 
            /// </summary>


            SqlConnection sqlConnection;
            //SQL connection String
            string connectionString = @"Data Source=ayeshaVM;Initial Catalog=Siddiqa;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            //Query to Select all the Data from the Employee Table
            string selectQuery = "select * from  Employee";
            SqlCommand insertCommand = new SqlCommand(selectQuery, sqlConnection);
            SqlDataReader reader = insertCommand.ExecuteReader();
            //While iteration used to display the all the rows from the Table on Console
            while (reader.Read())
            {
                Console.WriteLine("Emp Id : "+reader.GetValue(0).ToString() +" \n Employee First Name : "+ reader.GetValue(1).ToString()
                    + " \n Employee Last Name : " + reader.GetValue(2).ToString() + " \n Employee Salary : " + reader.GetValue(3).ToString());
                Console.WriteLine("\n");
            }
            Console.ReadLine();
            sqlConnection.Close();

            /*
            * Here We are using ADO .NET concepts to achieve the user inputs to store in DB Table
            * In this Program We have connected to DB using Connection String 
            * Taken then inputs from user with console application
            * Stroed the inputs in Variables 
            * Passed the vairabled into Select Query and 
            * Reterived the data and displaying to user in console application
            */
        }
    }
}


