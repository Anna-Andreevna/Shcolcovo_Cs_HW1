using static System.Console;
using System;

namespace Easy_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the dividend");
            string str = ReadLine();
            if (int.TryParse(str, out int dividend) == false)
            {
                WriteLine("It's not an integer");
                Environment.Exit(0);
            }
            WriteLine("Enter the divider");
            str = ReadLine();
            if (int.TryParse(str, out int divider) == false)
            {
                WriteLine("It's not an integer");
                Environment.Exit(0);
            }
            if (divider == 0)
            {
                WriteLine("You try to divide by 0");
                Environment.Exit(0);
            }
            double division = (double)dividend / divider;
            WriteLine($"{dividend} / {divider} = {division}");
        }
    }
}
