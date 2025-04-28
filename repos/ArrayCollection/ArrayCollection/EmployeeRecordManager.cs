using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    internal class EmployeeRecordManager
    {
        private static void Main(string[] args)
        {
            Dictionary<string, string> employeeRecords = new Dictionary<string, string>();

            Console.WriteLine("Enter employee records. Enter 'exit' to stop.");
            while (true)
            {
                Console.Write("Enter employee ID: ");
                string employeeID = Console.ReadLine();

                if (employeeID.ToLower() == "exit")
                {
                    break;
                }

                Console.Write("Enter employee name: ");
                string employeeName = Console.ReadLine();

                employeeRecords[employeeID] = employeeName;
            }

            Console.WriteLine("Enter an employee name to check in the records: ");
            string employeeNameToCheck = Console.ReadLine();

            bool employeeExists = false;
            foreach (var record in employeeRecords)
            {
                if (record.Value == employeeNameToCheck)
                {
                    employeeExists = true;
                    break;
                }
            }

            if (employeeExists)
            {
                Console.WriteLine($"The employee '{employeeNameToCheck}' exists in the records.");
            }
            else
            {
                Console.WriteLine($"The employee '{employeeNameToCheck}' does not exist in the records.");
            }
        }
    }
}