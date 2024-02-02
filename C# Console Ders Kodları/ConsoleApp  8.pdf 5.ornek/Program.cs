using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class ForEachTest
{
    static void Main()
    {
        int[] array = { 187, 68, 94, 100, 83, 78, 85, 91, 76 };
        int total = 0;

        // add each element's value to total
        foreach (int number in array)
        {
            total += number;
        }

        Console.WriteLine($"Total of array elements: {total}");
        Console.ReadLine();
    }
}
