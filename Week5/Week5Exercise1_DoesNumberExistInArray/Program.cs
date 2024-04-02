using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise1_DoesNumberExistInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] PrimeNumbers = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            
            Console.WriteLine("Enter a number from 1 to 100 to check if it is Prime or Not! :");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = false;
            
            int index = -1;

            for (int i = 0; i < PrimeNumbers.Length; i++)
            {
                if (PrimeNumbers[i] == num)
                {
                    isPrime = true;
                    index = i;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("{0} is Prime and its index is: {1}", num, index);
            }
            else
            {
                Console.WriteLine("{0} is Not Prime! ", num);
            }
            Console.ReadKey();
        }
    }
}
