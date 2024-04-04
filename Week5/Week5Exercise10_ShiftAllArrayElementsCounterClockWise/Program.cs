using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise10_ShiftAllArrayElementsCounterClockWise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int res = search(array, 5);
            Console.WriteLine(res);

            Console.ReadKey();
        }
        static int search(int[] array, int num)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                    return i;
            }
            return -1;
        }
    }
}