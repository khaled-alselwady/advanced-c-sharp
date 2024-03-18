using System;

namespace Reporting_App_Example
{
    public class clsReport
    {
        //public delegate bool Filter(clsEmployee employee);

        public void ProcessEmployees(clsEmployee[] employees, string title, Predicate<clsEmployee> filter)
        {
            if (employees == null || filter == null)
                return;

            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var employee in employees)
            {
                if (filter(employee))
                    Console.WriteLine($"{employee?.ID} | {employee?.Name} | {employee?.Gender} | {employee?.TotalSales}");
            }
            Console.WriteLine("\n\n");
        }
    }
}
