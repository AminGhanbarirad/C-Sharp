using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise4_InsertANumberInTheDesiredLocationOfAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 3, 5, 7, 9 };

            Console.Write("Num: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Place: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < numbers.Length)
            {
                for (int i = numbers.Length - 1; i >= index; i--)
                {
                    numbers[i + 1] = numbers[i];
                }

                numbers[index] = num;

                Console.WriteLine("New Array:");
                foreach (int n in numbers)
                {
                    Console.Write(n + " ");
                }
            }
            else
            {
                Console.WriteLine("index is invalid!");
            }

            Console.ReadKey();
        }
    }
}
