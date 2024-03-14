using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise18_FourDigitPrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i < 10000; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("{0} ,", i);
                }
            }
            Console.ReadKey();
        }
    }
}
