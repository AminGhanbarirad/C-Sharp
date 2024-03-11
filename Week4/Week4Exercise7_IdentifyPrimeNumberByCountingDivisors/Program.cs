using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise7_IdentifyPrimeNumberByCountingDivisors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int x = int.Parse(Console.ReadLine());

            int j = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.Write("| {0} |", i);
                    j++;
                }
            }
            if (x == -1 || x == 0 || x == 1)
            {
                Console.WriteLine("\nThe property of being prime is not defined for the number {0}.", x);
            }
            else if (j == 2)
            {
                Console.WriteLine("\nNumber {0} is Prime.", x);
            }
            else
            {
                Console.WriteLine("\nNumber {0} is Not Prime!", x);
            }
            Console.WriteLine("\nTotal of Divisor: {0}", j);
            Console.ReadKey();

        }
    }
}
