using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise13_NumberofGPABetween10and15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students: ");
            int x = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < x; i++)
            {
                Console.Write("Enter the student number{0} GPA: ", i + 1);
                int y = int.Parse(Console.ReadLine());
                Console.Write("");
                
                if (y >= 10 && y < 15)
                {
                    count++;
                }
            }
            Console.WriteLine("There is/are {0} student/s whit GPA between 10 and 15.", count);
            Console.ReadKey();
        }
    }
}
