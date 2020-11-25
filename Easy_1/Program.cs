using System;

namespace Easy_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name, stranger?");
            string username = Console.ReadLine();
            string greeting = "Hello, " + username + ". May the Force be with you.";
            Console.WriteLine(greeting);
        }
    }
}
