using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise8_Salary_Tax_Ratio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary:");
            int salary = int.Parse(Console.ReadLine());

            int tax;
            if (salary < 500000)
            {
                tax = 0;
            }
            else if (salary < 1000000)
            {
                tax = salary * 10 / 100;
            }
            else
            {
                tax = salary * 15 / 100;
            }

            Console.WriteLine("Amount of Tax Related to Salary: {0}", tax);

            Console.ReadKey();
        }
    }
}
