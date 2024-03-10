using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise11_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Height In Centimeter");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Weight in Kilogram");
            int weight = int.Parse(Console.ReadLine());

            double heightInM = height / 100;

            double BMI = weight / Math.Pow(heightInM, 2);

            Console.WriteLine(BMI);
            Console.ReadKey();

            if (BMI < 18.5)
            {
                Console.WriteLine("You're Underweighted");
                Console.ReadKey();
                return;
            }
            else if (18.5 <= BMI & BMI < 25)
            {
                Console.WriteLine("You're Weight is Normal");
                Console.ReadKey();
                return;
            }
            else if (25 <= BMI & BMI < 30)
            {
                Console.WriteLine("You're Overweighted");
                Console.ReadKey();
                return;
            }
            else if (BMI > 30)
            {
                Console.WriteLine("You're Obese");
                Console.ReadKey();
                return;
            }

        }
    }
}
