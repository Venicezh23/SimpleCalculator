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

            Console.Write("Enter an operator (+ OR - OR * OR /): ");
            string op = Console.ReadLine();

            double result = calculate(num1, num2, op);
            Console.WriteLine("Result of " + num1 + " " + op + " " + num2 + " = " + result);

            Console.ReadLine();
        }

        static double calculate(double num1, double num2, string op)
        {
            if (op == "+")
            {
                return num1 + num2;
            }
            else if (op == "-")
            {
                return num1 - num2;
            }
            else if (op == "*")
            {
                return num1 * num2;
            }
            else if (op == "/")
            {
                return num1 / num2;
            }
            return 0;

        }
    }
}
