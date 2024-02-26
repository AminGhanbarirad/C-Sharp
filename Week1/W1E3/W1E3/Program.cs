using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CountryName: {0}, Capital: {1}, Currency: {2}, CountryPhoneCode: {3}", "Netherlands", "Amsterdam", "EUR", "+31");
            Console.WriteLine("CountryName: {0}, Capital: {1}, Currency: {2}, CountryPhoneCode: {3}", "Canada", "Ottawa", "CAD", "+1");
            Console.WriteLine("CountryName: {0}, Capital: {1}, Currency: {2}, CountryPhoneCode: {3}", "United Kingdom", "London", "GBP", "+44");
            Console.WriteLine("CountryName: {0}, Capital: {1}, Currency: {2}, CountryPhoneCode: {3}", "France", "Paris", "EUR", "+33");
            Console.ReadKey();
        }
    }
}
