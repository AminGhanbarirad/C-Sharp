using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise7_RemoveDuplicateValuesFromAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 21);
            }
            Console.WriteLine("Array of All Grades:");
            foreach (int grade in numbers)
            {
                Console.Write(grade + " ");
            }

            int[] uniqueNumbers = new int[numbers.Length];
            int uniqueCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                bool found = false;
                for (int j = 0; j <= uniqueCount; j++)
                {
                    if (numbers[i] == uniqueNumbers[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    uniqueNumbers[uniqueCount++] = numbers[i];
                }
            }

            Console.WriteLine("");
            Console.WriteLine("New Array of Grades, Each Gained Score Shown Only Once:");
            foreach (int n in uniqueNumbers)
            {
                if (n != 0)
                    Console.Write(n + " ");
            }
            Console.ReadKey();
        }
    }
}
