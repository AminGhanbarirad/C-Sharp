using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise6_Strange_Repetitive_Display_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            double number = double.Parse(Console.ReadLine());


            Console.WriteLine("{0}-{0}-{0}", number);

            //option1
            Console.WriteLine("-{0}-{0}-{0}-", number);
            
            //option2 - useless         (┬┬﹏┬┬)
            //Console.Write("-");
            //for (double i = 0; i < 4; i++)
            //{
            //    Console.Write("{0}-", number);
            //}
            //Console.WriteLine();


            Console.WriteLine("{0}{0}{0}", number);


            Console.WriteLine("{0}!-{1}&*5", number, number);


            Console.WriteLine("{0} {0} {0}", number);


            Console.ReadKey();
        }
    }
}
