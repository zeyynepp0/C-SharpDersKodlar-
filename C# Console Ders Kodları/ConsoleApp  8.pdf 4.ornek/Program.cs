using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class SumArray
{
    static void Main()
    {
        int[] array = { 187, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
        int total = 0;

        // add each element's value to total
        for (int counter = 0; counter < array.Length; ++counter)
        {
            total += array[counter];
        }

        Console.WriteLine($"Total of array elements: {total}");
        Console.ReadLine();
    }
 
}
