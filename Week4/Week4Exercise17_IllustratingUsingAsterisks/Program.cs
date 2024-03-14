using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise17_IllustratingUsingAsterisks
{
    internal class Program
    {
        static void Main(string[] args)
        {
//////////////////////////////////////////////////
            for ( int j = 14;  j > 0; j -= 1 )
            { 
                for (int i = 0; i < j; i++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
                for (int i = 0; i < j - 1; i++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();
            }
//////////////////////////////////////////////////
            for (int j = 14; j > 0; j -= 1)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write("  ");
                }
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int i = 0; i < j; i++)
                {
                    Console.Write("  ");
                }
                for (int i = 0; i < 6; i++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
//////////////////////////////////////////////////
            for (int j = 1; j < 14; j++)
            {
                for (int i = 0; i < 40; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < j; i++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
                for (int i = 0; i < 40; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < j; i++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //////////////////////////////////////////////////
            int k = 1;
            while (k < 16)
            {
                for (int i = 0; i < 16 - k; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < k; i++)
                {
                    Console.Write("* ");
                }
                k++;
                Console.WriteLine();
            }
//////////////////////////////////////////////////
            Console.ReadKey();
        }
    }
}
