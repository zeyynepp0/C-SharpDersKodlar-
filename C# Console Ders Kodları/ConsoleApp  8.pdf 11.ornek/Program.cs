using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Passing arrays and individual array elements to methods.
using System;

class PassArray
{
    // Main creates array and calls ModifyArray and ModifyElement
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Effects of passing reference to entire array:");
        Console.Write("Values of the original array are: ");

        // output original array elements
        foreach (var value in array)
            Console.Write($"{value} ");

        ModifyArray(array);

        Console.Write("\nValues of the modified array are: ");

        // output modified array elements
        foreach (var value in array)
            Console.Write($"{value} ");

        Console.WriteLine("\n\nEffects of passing array element value:");

        Console.WriteLine($"array[3] before ModifyElement: {array[3]}");
        ModifyElement(array[3]);
        Console.WriteLine($"array[3] after ModifyElement: {array[3]}");
        Console.ReadLine();
    }

    // multiply each element of an array by 2
    static void ModifyArray(int[] array2)
    {
        for (int counter = 0; counter < array2.Length; counter++)
            array2[counter] *= 2;
    }

    // multiply argument by 2
    static void ModifyElement(int element)
    {
        element *= 2;
        Console.WriteLine($"Value of element in ModifyElement: {element}");
    }
   
}
