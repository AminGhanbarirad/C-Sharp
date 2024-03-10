using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise2_Displaced_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            double num2 = double.Parse(Console.ReadLine());

            double temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("The First Number After Reorder: " + num1);
            Console.WriteLine("The Second Number After Reorder: " + num2);

            Console.ReadKey();
        }
    }
}
