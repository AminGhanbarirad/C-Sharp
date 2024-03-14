using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise16_NthTermofNumericalSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the N number:");
            int n = int.Parse(Console.ReadLine());

            double prev1 = 1;
            double prev2 = 5;
            Console.Write("{0}, {1}, ", prev1, prev2);
            
            double avg = 0;
            
            for (int i = 3; i <= n; i++)
            {
                avg = (prev1 + prev2) / 2;
                Console.Write("{0} ,", avg);
                prev1 = prev2;
                prev2 = avg;
            }
            Console.ReadKey();
        }
    }
}
