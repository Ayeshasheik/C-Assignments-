// C# program to display the details of those
// employees whose name starts with character "D"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{

    // Declare 4 variables - id, name,
    // department, and salary
    int id;
    int salary;
    string name;
    string department;

    // Get the to string method that returns
    // id, name, department, and salary
    public override string ToString()
    {
        return id + " " + name + " " +
        salary + " " + department;
    }

    // Driver code
    static void Main(string[] args)
    {

        // Declare a list variable
        List<Employee> emp = new List<Employee>()
    {
		
		// Create 5 Employee details
		new Employee{ id = 201, name = "Druva",
                    salary = 12000, department = "HR" },
        new Employee{ id = 202, name = "Deepu",
                    salary = 15000, department = "Development" },
        new Employee{ id = 203, name = "Manoja",
                    salary = 13000, department = "HR" },
        new Employee{ id = 204, name = "Sathwik",
                    salary = 12000, department = "Designing" },
        new Employee{ id = 205, name = "Suraj",
                    salary = 15000, department = "Development" }
    };

        // Iterate the Employee by selecting Employee
        // name starts with D
        // Using IEnumerable interface
        IEnumerable<Employee> result = emp.Where(x => x.name[0] == 'D');

        // Display employee details
        Console.WriteLine("ID Name Salary Department");
        Console.WriteLine("++++++++++++++++++++++++++++");
        foreach (Employee e in result)
        {

            // Call the to string method
            Console.WriteLine(e.ToString());
        }
    }
}
