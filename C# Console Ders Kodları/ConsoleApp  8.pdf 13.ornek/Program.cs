using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class InitArray
{
    // create and output rectangular and jagged arrays
    static void Main()
    {
        // Rectangular arrays
        int[,] rectangularArray = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Jagged arrays
        int[][] jaggedArray = {new int[] { 1, 2},
        new int[] { 3},
        new int[] { 4,5,6}};

        OutputArray(rectangularArray);
        Console.WriteLine();

        OutputArray(jaggedArray);
        Console.ReadLine();
        Console.WriteLine();
    }

    // Display array values by row and column
    static void OutputArray(int[,] array)
    {
        Console.WriteLine("Values in the rectangular array by row are:");

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.Write($"[{array[row, column]}] ");
            }
            Console.WriteLine();
        }
    }

    // Display array values by row (jagged array)
    static void OutputArray(int[][] array)
    {
        Console.WriteLine("Values in the jagged array by row are:");

        foreach (var row in array)
        {
            foreach (var element in row)
            {
                Console.Write($"[{element}] ");
            }
            Console.WriteLine();
        }
    }
}
