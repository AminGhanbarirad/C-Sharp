using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise5_Some_Other_Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y:");
            int y = int.Parse(Console.ReadLine());

            int summation = (x + y);

            Console.WriteLine("(x + y) * z: {0} {1}", summation, "z");
            Console.WriteLine("x * y + y * z: {0} {1} {2} {3}", summation, "+", y, "z");

            Console.ReadKey();
        }
    }
}
