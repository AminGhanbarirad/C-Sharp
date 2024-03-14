using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Extra3_ReversePrintingOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            string str = Console.ReadLine();

            string reversedStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }

            Console.WriteLine("Reverse order Of the strings: " + reversedStr);
            Console.ReadKey();
        }
    }
}
