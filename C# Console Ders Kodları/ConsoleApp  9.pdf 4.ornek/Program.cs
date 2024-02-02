using System;
using System.Linq;
using System.Collections.Generic;

class LINQWithListCollection
{
    static void Main()
    {
        List<string> items = new List<string>();
        items.Add("aqua");
        items.Add("Ruslow");
        items.Add("red");
        Console.WriteLine("Items contain:");
        foreach (var item in items)
        {
            Console.WriteLine($"   {item}");
        }

        Console.WriteLine(); // Output end of line

        // Convert to uppercase, select those starting with 'R', and sort
        var startsWithR = from item in items
                          let uppercaseString = item.ToUpper()
                          where uppercaseString.StartsWith("R")
                          orderby uppercaseString
                          select uppercaseString;

        // Display query results
        Console.Write("Results of query startsWithR:");
        foreach (var item in startsWithR)
        {
            Console.Write($" {item}");
        }

        Console.WriteLine(); // Output end of line
        items.Add("ruby");
        items.Add("saffron");
        Console.WriteLine("Items contain:");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }

        Console.WriteLine(); // Output end of line

        // Display results of query startsWithR after adding new items
        Console.Write("Results of query startsWithR after adding new items:");
        foreach (var item in startsWithR)
        {
            Console.Write($" {item}");
        }

        Console.WriteLine(); // Output end of line
        Console.ReadLine();
    }
}
