using static System.Console;

namespace Easy_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a symbol");
            char symbol = (char)Read();
            byte cod = (byte)symbol;
            char next_symb = (char)(cod + 1);
            WriteLine($"The next symbol is '{next_symb}'");
        }
    }
}
