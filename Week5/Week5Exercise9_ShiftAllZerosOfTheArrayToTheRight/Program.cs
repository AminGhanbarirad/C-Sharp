using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise9_ShiftAllZerosOfTheArrayToTheRight
{
    class PrintArrays
    {
        private int[] _numbers;
        public PrintArrays(int[] numbers)
        {
            _numbers = numbers;
        }
        public void Print()
        {
            Console.Write("[");

            foreach (int number in _numbers)
            {
                Console.Write( number + " ");
            }

            Console.Write("]");
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static bool AreEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            
            return true;
        }
        static void Main(string[] args)
        {
            
            int[] numbers = new int[50];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 2);
            }
            
            Console.WriteLine("Orginal Array Whitout Sorting Zeros:");
            PrintArrays P1 = new PrintArrays(numbers);
            P1.Print();
            Console.WriteLine("");
            
            ShiftZerosToRight(numbers);

            Console.WriteLine("New Array Whit Shifted All Zeros To the Right:");
            PrintArrays P2 = new PrintArrays(numbers);
            P2.Print();
            Console.ReadKey();
        }

        static void ShiftZerosToRight(int[] arr)
        {
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    if (i != j)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    j++;
                }
            }

        }
    }
}
