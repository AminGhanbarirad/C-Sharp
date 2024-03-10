using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise3_Grade_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Grade Score:");
            int score = int.Parse(Console.ReadLine());

            string grade;
            if (score < 0 || score > 100)
            {
                Console.WriteLine("Invalid Score!");
                Console.ReadKey();
                return;
            }
            if (score >= 80)
            {
                grade = "A";
            }
            else if (score >= 61)
            {
                grade = "B";
            }
            else if (score >= 41)
            {
                grade = "C";
            }
            else if (score >= 21)
            {
                grade = "D";
            }
            else
            {
                grade = "E";
            }

            Console.WriteLine("Score Conversion: {0}", grade);
            Console.ReadKey();
        }
    }
}
