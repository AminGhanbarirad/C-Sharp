using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise6_PrintDuplicateValuesOfTwoDifferentArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] GradesA = new int[20];

            Random random1 = new Random();
            for (int i = 0; i < GradesA.Length; i++)
            {
                GradesA[i] = random1.Next(0, 21);
            }

            Console.WriteLine("The Grades of 20 Students In Class A:");
            foreach (int grade in GradesA)
            {
                Console.Write(grade + " ");
            }
            Console.WriteLine();
            
            int[] GradesB = new int[20];

            Random random2 = new Random();
            for (int i = 0; i < GradesB.Length; i++)
            {
                GradesB[i] = random2.Next(0, 21);
            }

            Console.WriteLine("The Grades of 20 Students In Class A:");
            foreach (int grade in GradesB)
            {
                Console.Write(grade + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Duplicate Grades:");
            bool[] found = new bool[21];
            for (int i = 0; i < GradesA.Length; i++)
            {
                if (!found[GradesA[i]])
                {
                    found[GradesA[i]] = true;
                    int count = 1;
                    for (int j = 0; j < GradesB.Length; j++)
                    {
                        if (GradesA[i] == GradesB[j])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine("The Grade {0} is Exists in Both Arrays.", GradesA[i]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
