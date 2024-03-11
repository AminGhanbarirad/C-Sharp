using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise3_Number_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of sentences in the series:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of x:");
            double x = double.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double term = Math.Pow(x, 2 * i - 1);

                if (i % 2 == 1)
                {
                    term = -term;
                }

                sum += term;
            }

            Console.WriteLine("Result: {0}", sum);
        Console.ReadKey();
        }
    }
}
