using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise9_Switch_Case_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Operator Sign:");
            string Operator = Console.ReadLine();
            
            Console.WriteLine("Enter the Second Number:");
            int num2 = int.Parse(Console.ReadLine());

            double result;

            switch (Operator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by Zero!");
                        Console.ReadKey();
                        return;
                    }
                    result = (double)num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    return;
            }
            Console.WriteLine("Result: {0}", result);
            Console.ReadKey();
        }
    }
}
