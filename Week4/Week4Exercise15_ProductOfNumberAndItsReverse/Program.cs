using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise15_ProductOfNumberAndItsReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int x = int.Parse(Console.ReadLine());

            int l = CountTheNumberOfDigits(x);
            Console.WriteLine("Length of number: {0}", l);

            double product = 0;
            int temp = x;

            for (int i = 1; i <= l; i++)
            {
                product += x * (temp % 10) * Math.Pow(10, (l - i));
                temp /= 10;
            }
            Console.WriteLine("Product of number and its reverse is: {0}", product);
            Console.ReadKey();
        }

        static int CountTheNumberOfDigits(int x)
        {
            int l = 0;

            for (int i = 1; x / i != 0; i *= 10)
            {
                l++;
            }
            return l;
        }
    }
}
