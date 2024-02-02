using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        // create the space for the array and initialize to default zeros
        int[] array = new int[5];

        Console.WriteLine($" { "Index "} { "Value" , 8}");

        // output each array element's value
        for (int counter = 0; counter < array.Length; counter++)
        {
            Console.WriteLine($"{counter,5} {array[counter],8}");
        }

        Console.ReadLine();
    }
}
