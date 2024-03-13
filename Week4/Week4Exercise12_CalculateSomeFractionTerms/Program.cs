using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise12_CalculateSomeFractionTerms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double product = 1;
            double sumofproduct = 0;
            for (int i = 1; i <= 500; i++)
            {
                sum += ((1 / (2 * i - 1)) - (1 / (2 * i)));
                Console.Write("+ 1/{0} ", 2 * i - 1);
                Console.Write("- 1/{0} ", 2 * i);
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the first mathematical term: {0}", sum);
            Console.WriteLine();
            for (double j = 1; j <= 50; j++)
            {
                product *= ((2 * j) - 1) / (2 * j);
                Console.Write("{0}/{1} * ", 2 * j-1, 2 * j);
            }
            Console.WriteLine();
            Console.WriteLine("The product of the second mathematical term: {0}", product);
            Console.WriteLine();
            for (double i = 1; i <= 50; i++)
            {
                sumofproduct += ((2 * i - 1) * (2 * i) / (4 * i - 1));
                Console.Write("({0}*{1})/({0}+{1}) + ", 2 * i - 1, 2 * i);
            }
            Console.WriteLine();
            Console.WriteLine("The sum of products in the third mathematical term: {0}", sumofproduct);
            Console.ReadKey();
        }
    }
}
