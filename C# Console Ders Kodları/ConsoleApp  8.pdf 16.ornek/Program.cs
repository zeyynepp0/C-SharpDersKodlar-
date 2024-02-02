using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class TestArray
{
    static void Main(string[] args)
    {
        // Check if the correct number of command-line arguments is provided
        if (args.Length != 3)
        {
            Console.WriteLine("Error: Please re-enter the entire command, including array size, initial value, and increment.");
        }
        else
        {
            // Parse command-line arguments
            var arrayLength = int.Parse(args[0]);
            var array = new int[arrayLength];
            var initialValue = int.Parse(args[1]);
            var increment = int.Parse(args[2]);

            // Calculate value for each array element
            for (var counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = initialValue + increment * counter;
            }

            Console.WriteLine($"{"Index",-5}{"Value",8}");

            // Display array index and values
            for (var counter = 0; counter < array.Length; ++counter)
            {
                Console.WriteLine($"({counter,-5}{array[counter],8})");
            }
        }
        Console.ReadLine();
    }
}

