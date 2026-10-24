using System;

namespace SortCities
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[10];

            Console.WriteLine("=== City Name Sorter ===");
            Console.WriteLine("Enter names of 10 cities:");
            Console.WriteLine(new string('-', 30));

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"City {i + 1}: ");
                cities[i] = Console.ReadLine();
            }

            // Sort array using Array.Sort()
            Array.Sort(cities, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("\n--- Cities in Sorted Order ---");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cities[i]}");

}

            Console.WriteLine(new string('-', 30));
            Console.ReadKey();
        }
    }
}
