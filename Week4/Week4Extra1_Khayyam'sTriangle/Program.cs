using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Extra1_Khayyam_sTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int k = 1;

            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l < 10 - i; l++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++)
                {
                    int l = length(PascalTriangle(i, j));
                    switch (l)
                    {
                        case 2:
                            Console.Write("  ");
                            break;
                        case 3:
                            Console.Write(" ");
                            break;
                        default:
                            Console.Write("   ");
                            break;
                    }
                    Console.Write(PascalTriangle(i, j) + "");
                }
                Console.WriteLine();
            }
            while (k <= 10)
            {
                for (int i = 0; i < 10 - k; i++)
                {
                    Console.Write("  ");
                }
                for (int i = 0; i < k; i++)
                {
                    Console.Write(" *  ");
                }
                k++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static int PascalTriangle(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;
            }
            else
            {
                return PascalTriangle(n - 1, k - 1) + PascalTriangle(n - 1, k);
            }
        }

        static int length(int x)
        {
            int j = 0;

            for (int i = 1; x / i != 0; i *= 10)
            {
                j++;
            }
            return j;
        }


    }
}
