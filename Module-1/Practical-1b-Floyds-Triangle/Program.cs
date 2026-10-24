using System;

namespace FloydTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Floyd's Triangle ===");
            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());

            int number = 1;

            Console.WriteLine("\nFloyd's Triangle:");
            Console.WriteLine(new string('-', 30));

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + "\t");
                    number++;
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 30));

Console.WriteLine($"Total numbers printed: {number - 1}");
            Console.ReadKey();
        }
    }
}
