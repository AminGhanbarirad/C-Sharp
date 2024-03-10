using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise1_Find_Largest_of_Four_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Third Number:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Fourth Number:");
            int num4 = int.Parse(Console.ReadLine());

            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            if (num4 > max)
            {
                max = num4;
            }

            Console.WriteLine("The Biggest Number: {0}", max);
            Console.ReadKey();
        }
    }
}
