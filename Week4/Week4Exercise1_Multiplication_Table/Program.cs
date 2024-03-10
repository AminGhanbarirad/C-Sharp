using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise1_Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("   | ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,2} ", i);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,2} | ", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0,2} ", i * j);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
