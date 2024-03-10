using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise6_Triangle_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Side Length:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Side Length:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Third Side Length:");
            double c = double.Parse(Console.ReadLine());

            bool isValid;

            if (a + b > c && a + c > b && b + c > a)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Triangle can be made with these sides.");
            }
            else
            {
                Console.WriteLine("Triangle can't be made with these sides");
            }
            Console.ReadKey();
        }
    }
}