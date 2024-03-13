using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise11_SumofDigitsofaNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int x = int.Parse(Console.ReadLine());

            int l = CountTheNumberOfDigits(x);
            Console.WriteLine("Length of Number is: {0}", l);

            int temp = x;
            int s = 0;
            for (int i = 0; i <= 9; i++)
            {
                int count = 0;
                while (temp != 0)
                {
                    int t = temp % 10;
                    if (i == t)
                    {
                        count++;
                    }
                    temp /= 10;
                }
                if (count != 0)
                {
                    Console.WriteLine("Digit {0}, repeated {1} times in {2}", i, count, x);
                    s += i * count;
                }
                temp = x;
            }
            Console.WriteLine("The sum of the digits of {0} is: {1}", x, s);
            Console.ReadKey();
        }

        static int CountTheNumberOfDigits(int x)
        {
            int j = 0;

            for (int i = 1; x / i != 0; i *= 10)
            {
                j++;
            }
            return j;
        }
    }
}
