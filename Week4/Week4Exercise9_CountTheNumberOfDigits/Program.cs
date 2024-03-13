using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise9_CountTheNumberOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter An Integer Number: ");
            int x = int.Parse(Console.ReadLine());

            int j = 0;

            for (int i = 1; x/i != 0; i*=10)
            {
                j++;
            }
            Console.WriteLine("The Number Of Digits is: {0}", j);
            Console.ReadKey();
        }
    }
}
