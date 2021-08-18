using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk11_employeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input from the user 
            Console.WriteLine("Select type of employment: Full Time OR Casual");
            string userInput = Console.ReadLine();

            // basic employee details
            Console.Write("Enter Name: \t");
            string inputName = Console.ReadLine();
            Console.Write("Enter ID: \t");
            string inputID = Console.ReadLine();
            

            if (userInput == "Full Time")
            {
                Console.Write("Enter Annual Wage:\t$");
                string annualWage = Console.ReadLine();

                // create employee
                FTEmployee f1 = new FTEmployee(inputID, inputName, int.Parse(annualWage));

                // display results
                Console.WriteLine(f1);
                Console.WriteLine("Employee Wage: $" + f1.employeeWage());

            }
            else if (userInput == "Casual")
            {
                Console.Write("Enter Rate:\t$");
                string inputRate = Console.ReadLine();

                Console.Write("Enter Hours: \t");
                string inputHours = Console.ReadLine();

                // create employee
                CSEmployee c1 = new CSEmployee(inputID, inputName, int.Parse(inputRate), int.Parse(inputHours));

                // display results
                Console.WriteLine("\n" + c1);
                Console.WriteLine("Employee Wage: $" + c1.employeeWage());
            }
            else
            {
                // error message
                Console.WriteLine("ERROR: Invalid input.");
            }

            // hold console window
            Console.ReadLine();

        }
    }
}
