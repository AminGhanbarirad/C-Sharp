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
            int[] Numbers = new int[20];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = i + 1;
            }
            Console.WriteLine("The Orginal Array is:");
            foreach (int n in Numbers)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine("");


            Console.WriteLine("Enter The Desired Number You want to add: ");
            int DesiredNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Desired Number Place in Array(Valid Index 0 to 19): ");
            int DesiredNumIndex = int.Parse(Console.ReadLine());

            if (DesiredNumIndex  < 0 || DesiredNumIndex > 19) { Console.WriteLine("Enter Valid Index 0 to 19"); }

            Numbers[DesiredNumIndex] = DesiredNum;

            Console.WriteLine("The Updated Array is:");
            foreach (int n in Numbers)
            {
                Console.Write(n + ", ");
            }

            Console.ReadKey();
        }
    }
}
