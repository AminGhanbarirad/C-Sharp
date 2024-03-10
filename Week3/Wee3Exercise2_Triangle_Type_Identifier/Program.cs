using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wee3Exercise2_Triangle_Type_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Side Length:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Side Length:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Third Side Length:");
            int c = int.Parse(Console.ReadLine());

            string type;
            if (a + b < c || a + c < b || b + c < a || a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Can't make Triangle Whith These Side Length!");
                Console.ReadKey();
                return;
            }
            if (a == b && b == c)
            {
                type = "Equilateral Triangle";
            }
            else if (a == b || b == c || a == c)
            {
                type = "Isosceles Triangle";
            }
            else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                type = "Right Triangle";
            }
            else
            {
                type = "Regular Triangle";
            }

            Console.WriteLine("Triangle Type: {0}", type);
            Console.ReadKey();
        }
    }
}
