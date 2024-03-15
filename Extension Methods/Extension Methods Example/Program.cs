using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine($"DateTime.Now: {date}");
            Console.WriteLine($"DateTime.Now: {date.IsWeekend()}");
            date = date.AddDays(3);
            Console.WriteLine($"DateTime.Now: {date.IsWeekDay()}");

            Console.ReadKey();
        }
    }
}
