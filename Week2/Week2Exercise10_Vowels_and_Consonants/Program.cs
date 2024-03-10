using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise10_Vowels_and_Consonants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character:");
            char ch = Console.ReadLine()[0];

            switch (ch)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("'{0}' is Vowel", ch);
                    break;
                default:
                    Console.WriteLine("'{0}' is Consonant", ch);
                    break;
            }
            Console.ReadKey();
        }
    }
}
