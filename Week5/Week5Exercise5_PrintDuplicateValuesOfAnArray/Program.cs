using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise5_PrintDuplicateValuesOfAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[20];

            Random random = new Random();
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = random.Next(0, 21);
            }

            Console.WriteLine("The Grades of 20 Students:");
            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }            
            Console.WriteLine();

            Console.WriteLine("Duplicate Grades:");
            bool[] found = new bool[21];
            for (int i = 0; i < grades.Length; i++)
            {
                if (!found[grades[i]])
                {
                    found[grades[i]] = true;
                    int count = 1;
                    for (int j = i + 1; j < grades.Length; j++)
                    {
                        if (grades[i] == grades[j])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine("The Grade {0} is Reapeted {1} Times.", grades[i], count);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
