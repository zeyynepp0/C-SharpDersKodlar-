using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class StudentPoll
{
    static void Main()
    {
        // student response array (more typically, input at runtime)
        int[] responses = { 1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3, 2, 3, 3, 2,6,8}; 
        var frequency = new int[6]; // array of frequency counters

        // for each answer, select responses element and use that value
        // as frequency index to determine element to increment
        for (var answer = 0; answer < responses.Length; ++answer)
        {
            try
            {
                ++frequency[responses[answer]];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"responses[{answer}] = {responses[answer]}\n");
            }
        }

        Console.WriteLine($"{"Rating",-10}{"Frequency",10}");

        // output each array element's value
        for (var rating = 1; rating < frequency.Length; ++rating)
        {
            Console.WriteLine($"{rating,6}{frequency[rating],10}");
        }
        Console.ReadLine();
    }
}
