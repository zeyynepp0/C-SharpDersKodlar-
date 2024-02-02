using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class InitArray
{
    static void Main()
    {
        const int ArrayLength = 5;
        int[] array = new int[ArrayLength];

        // calculate value for each array element
        for (int counter = 0; counter < array.Length; ++counter)
        {
            array[counter] = 2 + 2 * counter;
        }

        Console.WriteLine($" {"Index"} {"Value",8}");

        // output each array element's value
        for (int counter = 0; counter < array.Length; ++counter)
        {
            Console.WriteLine($"{counter,5} {array[counter],8}");
        }
        Console.ReadLine();
    }
}
