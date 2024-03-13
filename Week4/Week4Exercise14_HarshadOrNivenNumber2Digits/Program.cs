using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise14_HarshadOrNivenNumber2Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            for (int i = 10; i < 100; i++)
            {
                s = (i % 10) + (i / 10);
                if (i % s == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
