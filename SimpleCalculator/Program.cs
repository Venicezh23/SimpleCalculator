using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my simple calculator!");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;
            double result2 = num1 - num2;

            Console.WriteLine("Sum of num1 and num2: " + result);
            Console.WriteLine("Subtration of num1 and num2: " + result2);

            Console.ReadLine();
        }
    }
}
