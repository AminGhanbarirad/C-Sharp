using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise8_GreatestCommonDivisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The First Number: ");
            int y = int.Parse(Console.ReadLine());

            int j = 1;

            if ( x != 0 && y != 0 )
            {
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0 && y % i == 0)
                    {
                        j = i;
                    }
                }
            Console.WriteLine("The Greatest Common Divisor of {0} and {1} is: {2}", x, y, j);
            }
            else if (x == 0 || y == 0)
            {
                Console.WriteLine("GCD On 0 Is Not Defined");
            }
            Console.ReadKey();
        }
    }
}
