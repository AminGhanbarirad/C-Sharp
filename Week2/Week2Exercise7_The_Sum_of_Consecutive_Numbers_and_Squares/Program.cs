using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise7_The_Sum_of_Consecutive_Numbers_and_Squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());

            int sum = (n * (n + 1)) / 2;

            int squares = (n * (n + 1) * (2 * n + 1)) / 6;

            Console.WriteLine("Consecutive Summation 1 to {0}: {1}", n, sum);
            Console.WriteLine("Square Summation 1 to {0}: {1}", n, squares);

            Console.ReadKey();
        }
    }
}
