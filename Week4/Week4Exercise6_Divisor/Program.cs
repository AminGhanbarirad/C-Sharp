using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise6_Divisor
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
            Console.WriteLine("\nTotal of Divisor: {0}", j);
            Console.ReadKey();
        }
    }
}
