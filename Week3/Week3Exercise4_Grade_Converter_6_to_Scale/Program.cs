using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise4_Grade_Converter_6_to_Scale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Grade Score:");
            double score = double.Parse(Console.ReadLine());

            string grade;
            if (score < 6 || score > 10)
            {
                Console.WriteLine("Invalid Score!");
                Console.ReadKey();
                return;
            }
            if (score == 10)
            {
                grade = "A";
            }
            else if (score >= 9)
            {
                grade = "B";
            }
            else if (score >= 8)
            {
                grade = "C";
            }
            else if (score >= 7)
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
