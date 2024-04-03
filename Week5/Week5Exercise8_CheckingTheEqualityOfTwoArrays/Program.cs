using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise8_CheckingTheEqualityOfTwoArrays
{
    class PrintArray
    {
        private int[] _numbers;

        public PrintArray(int[] numbers)
        {
            _numbers = numbers;
        }

        public void Print()
        {
            Console.Write("[ ");
            foreach (int number in _numbers)
            {
                Console.Write(number + " ");
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
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };

            PrintArray P1 = new PrintArray(numbers1);
            P1.Print();

            int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };

            PrintArray P2 = new PrintArray(numbers2);
            P2.Print();

            bool areEqual1 = AreEqual(numbers1, numbers2);
            Console.WriteLine("Are these Arrays Equal? {0}", areEqual1);
            Console.WriteLine("");

            int[] numbers3 = new int[] { 1, 2, 3, 4, 5, 6};

            PrintArray P3 = new PrintArray(numbers3);
            P3.Print();

            int[] numbers4 = new int[] { 1, 2, 3, 4, 5, 7};

            PrintArray P4 = new PrintArray(numbers4);
            P4.Print();

            bool areEqual2 = AreEqual(numbers3, numbers4);
            Console.WriteLine("Are these Arrays Equal? {0}", areEqual2);
        Console.ReadKey();
        }
    }
}
