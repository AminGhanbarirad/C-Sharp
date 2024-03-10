using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise5_Some_Function_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            double x = double.Parse(Console.ReadLine());

            double result;
            if (x < 0)
            {
                result = x + 1;
            }
            else if (1 <= x)
            {
                result = 1 / x;
            }
            else
            {
                result = -Math.Pow(x, 2);
            }

            Console.WriteLine("Result: {0}", result);
            Console.ReadKey();
        }
    }
}
