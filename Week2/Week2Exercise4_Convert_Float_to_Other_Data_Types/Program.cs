using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise4_Convert_Float_to_Other_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Decimal Number:");
            float number = float.Parse(Console.ReadLine());

            int intNumber = (int)number;

            short shortNumber = (short)number;

            byte byteNumber = (byte)number;

            bool boolNumber = number != 0;

            long longNumber = (long)number;

            char charNumber = (char)number;

            string strNumber = number.ToString();


            Console.WriteLine("int: " + intNumber);
            Console.WriteLine("short: " + shortNumber);
            Console.WriteLine("byte: " + byteNumber);
            Console.WriteLine("bool: " + boolNumber);
            Console.WriteLine("long: " + longNumber);
            Console.WriteLine("char: " + charNumber);
            Console.WriteLine("string: " + strNumber);


            Console.ReadKey();
        }
    }
}
