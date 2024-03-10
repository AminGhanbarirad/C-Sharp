using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise1_Some_Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
        double E1 = -1 + 4 * 6;
        Console.WriteLine("-1 + 4 * 6 = " + E1);

        double E2 = (35 + 5) % 7;
        Console.WriteLine("(35 + 5) % 7 = " + E2);

        double E3 = 14 + -4 * 6 / 11;//نتونستم نتیجه رو به صورت اعشاری نمایش بدم
        Console.WriteLine("14 + (-4 * 6) / 11 = " + E3);

        double E4 = 2 + 15 / 6 * 1 - 7 % 2;
        Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + E4);

        Console.ReadKey();
        }
    }
}