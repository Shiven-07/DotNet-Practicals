using System;

namespace MulticastDelegate
{
    delegate void PrintDelegate(string message);

    class Printer
    {
        public static void PrintUpperCase(string msg)
        {
            Console.WriteLine($"UPPER: {msg.ToUpper()}");
        }

        public static void PrintLowerCase(string msg)
        {
            Console.WriteLine($"lower: {msg.ToLower()}");
        }

        public static void PrintReverse(string msg)
        {
            char[] chars = msg.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine($"Reversed: {new string(chars)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Multicast Delegate Demo ===");

            PrintDelegate del = Printer.PrintUpperCase;

del += Printer.PrintLowerCase;
            del += Printer.PrintReverse;

            Console.WriteLine("Invoking multicast delegate:");
            del("Hello World");

            Console.WriteLine("\nRemoving PrintLowerCase:");
            del -= Printer.PrintLowerCase;
            del("Hello World");

            Console.ReadKey();
        }
    }
}
