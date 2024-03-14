using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Extra2_FibonacciNumberSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the N number:");
            int n = int.Parse(Console.ReadLine());

            double prev1 = 1;
            double prev2 = 1;
            Console.Write("{0}, {1}, ", prev1, prev2);

            double next = 0;

            for (int i = 3; i <= n; i++)
            {
                next = (prev1 + prev2);
                Console.Write("{0} ,", next);
                prev1 = prev2;
                prev2 = next;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("The #{0} term of the Fibonacci number series is: {1}", n, next);
            Console.ReadKey();
        }
    }
}