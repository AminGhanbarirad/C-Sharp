using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise3_Temperature_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature in Celsius Degree:");
            double celsius = double.Parse(Console.ReadLine());

            double kelvin = celsius + 273.15;

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Kelvin: " + kelvin);
            Console.WriteLine("Fahrenheit Degree: " + fahrenheit);

            Console.ReadKey();
        }
    }
}
