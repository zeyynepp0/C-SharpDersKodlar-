using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // Initialize an integer array
        var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4 };

        // Display original values
        Console.Write("Original array: ");
        foreach (var element in values)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();

        // Query to obtain values greater than 4 from the array
        var filtered = from value in values
                       where value > 4
                       select value;

        // Display filtered results
        Console.Write("Values greater than 4: ");
        foreach (var element in filtered)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();

        // Use orderby clause to sort original values in ascending order
        var sorted = from value in values
                     orderby value
                     select value;

        // Display sorted results
        Console.Write("Sorted array: ");
        foreach (var element in sorted)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();

        // Sort the filtered results in descending order
        var sortFilteredResults = from value in filtered
                                  orderby value descending
                                  select value;

        // Display the sorted results in descending order
        Console.Write("Values greater than 4, descending order (two queries): ");
        foreach (var element in sortFilteredResults)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();

        // Filter original array and sort results in descending order in one query
        var sortAndFilter = from value in values
                            where value > 4
                            orderby value descending
                            select value;

        // Display the filtered and sorted results in descending order
        Console.Write("Values greater than 4, descending order (one query): ");
        foreach (var element in sortAndFilter)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
        Console.ReadLine();
    }
}
