using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise3_DuplicateAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[20];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = i + 1;
            }
            
            Console.WriteLine("The Orginal Array: ");
            foreach (int n in Numbers)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine("");

            
            int[] NewNumbers = new int[Numbers.Length];

            int j = 0;

            for (int i = 0; i < NewNumbers.Length; i++)
            {
                NewNumbers[j] = Numbers[i];
                j++;
            }

            Console.WriteLine("Copy of The Orginal Array: ");
            foreach (int n in NewNumbers)
            {
                Console.Write(n + ", ");
            }
            
            Console.ReadKey();
        }
    }
}
