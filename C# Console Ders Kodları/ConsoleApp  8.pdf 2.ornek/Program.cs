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
        // initialize the elements of the array with an array initializer
        int[] array = { 32, 27, 64, 18, 95 };

        Console.WriteLine($" {"Index"} {"Value",8}");

        // output each array element's value
        for (int counter = 0; counter < array.Length; ++counter)
        {
            Console.WriteLine($"{counter,5} {array[counter],8}");
        }
        Console.ReadLine();
    }
}

