using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise4_PerfectNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Nuumber:");
            int x = int.Parse(Console.ReadLine());

            bool perfect = false;
            
            int j = 1;
            
            for (int i = 2 ; i < x ; i++)
            {
                if ( x % i == 0)
                {
                    j += i;
                }
            }

            if ( x == j )
            {
                perfect = true;
            }
            
            if (perfect)
            {
                Console.WriteLine("Number {0} Is Perfect.", x);
            }
            else
            {
                Console.WriteLine("Number {0} Is Not Perfect.", x);
            }
            Console.ReadKey();
        }
    }
}
