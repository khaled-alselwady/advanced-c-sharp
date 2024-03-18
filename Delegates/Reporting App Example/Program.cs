using System;

namespace Reporting_App_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            var emps = new clsEmployee[]
            {
                new clsEmployee {ID = 1, Name = "Issam A", Gender = "M", TotalSales = 65000M},
                new clsEmployee {ID = 2, Name = "Reem S", Gender = "F", TotalSales = 50000M},
                new clsEmployee {ID = 3, Name = "Suzan B", Gender = "F", TotalSales = 6500M},
                new clsEmployee {ID = 4, Name = "Sara A", Gender = "F", TotalSales = 40000M},
                null,
                new clsEmployee {ID = 6, Name = "Rateb A", Gender = "M", TotalSales = 30000M},
                new clsEmployee {ID = 7, Name = "Abeer C", Gender = "F", TotalSales = 16000M},
                new clsEmployee {ID = 8, Name = "Marwan M", Gender = "M", TotalSales = 15000M}
            };

            var report = new clsReport();

            report.ProcessEmployees(emps, "Employees With $60,000 Plus Sales", employee => employee?.TotalSales > 60000M);
            report.ProcessEmployees(emps, "Employees Between $30,000 And $59,999", employee => employee?.TotalSales >= 30000M && employee?.TotalSales < 60000M);
            report.ProcessEmployees(emps, "Employees Less Than $30,000", employee => employee?.TotalSales < 30000M);

            Console.ReadKey();
        }
    }
}
