using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise2_DeleteExistedNumberFromArray
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
            foreach (int n in Numbers)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine("");
            
            Console.WriteLine("Enter the number you want to reject from 1 to 20:");
            int rejectedNum = int.Parse(Console.ReadLine());
            
            if (rejectedNum < 0 || rejectedNum > 20)
            {
                Console.WriteLine("The rejected number must be between 1 and 20!");
            }
            else
            {
                int[] NewNumbers = new int[Numbers.Length - 1];

                int j = 0;

                for (int i = 0; i <= NewNumbers.Length; i++)
                {
                    if (Numbers[i] != rejectedNum)
                        {
                            NewNumbers[j++] = Numbers[i];
                        }
                }
            
                Console.WriteLine("New Array: ");
                foreach (int n in NewNumbers)
                {
                    Console.Write(n + ", ");
                }
            }
            Console.ReadKey();
        }
    }
}
