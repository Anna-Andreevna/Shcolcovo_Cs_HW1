using System;
using static System.Console;

namespace Easy_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("I'll solve you quadratic equation of the form a*x^2 + b*x + c = 0");
            WriteLine("Enter the coefficients:");
            Write("a = ");
            string str = ReadLine();
            if (float.TryParse(str, out float a) == false)
            {
                WriteLine("It's not a number");
                Environment.Exit(0);
            }
            Write("b = ");
            str = ReadLine();
            if (float.TryParse(str, out float b) == false)
            {
                WriteLine("It's not a number");
                Environment.Exit(0);
            }
            Write("c = ");
            str = ReadLine();
            if (float.TryParse(str, out float c) == false)
            {
                WriteLine("It's not a number");
                Environment.Exit(0);
            }
            if (a == 0)
            {
                WriteLine("It's not a quadratic equation, but linear");
                if (b == 0)
                    WriteLine("There is no solution");
                else
                    WriteLine($"Solution is {- c / b}");
            }
            else
            {
                double D = b * b - 4 * a * c;
                if (D < 0)
                    WriteLine("There is no solution");
                else if (D == 0)
                    WriteLine($"Solution is {-b / 2 / a}");
                else
                    WriteLine($"Solutions are {(-b - Math.Sqrt(D)) / 2 / a} and {(-b + Math.Sqrt(D)) / 2 / a}");
            }
        }
    }
}
