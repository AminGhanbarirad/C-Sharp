using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise5_fourDigitsDividableOn7Not3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i < 10000; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
