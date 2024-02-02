using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BarChart
{
    static void Main()
    {
        int[] array = { 0,0,0,0,0,0,1,2,4,2,1};

        Console.Write("Grade Distribution: ");

        // distribution
        for (var counter = 0; counter < array.Length; ++counter)
        {
            // output bar labels ("00-09: ", "10-19: ", ..., "90-99: ")
            if (counter == 10)
            {
                Console.Write("100:      ");
            }
            else 
            { 
                Console.Write($"{counter * 10:D2}-{counter * 10 + 9:D2}: ");
            }
            // display bar of asterisks
            for (var stars = 0; stars < array[counter]; ++stars)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // new line after each bar
            Console.ReadLine();
        }
    }
}
