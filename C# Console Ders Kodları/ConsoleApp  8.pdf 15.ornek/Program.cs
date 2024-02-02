using System;

class ParamArrayTest
{
    static void Main()
    {
        double d1 = 10.0;
        double d2 = 20.0;
        double d3 = 30.0;
        double d4 = 40.0;

        Console.WriteLine($"Average of d1: {Average(d1):F}");
        Console.WriteLine($"Average of d1 and d2 is: {Average(d1, d2):F}");
        Console.WriteLine($"Average of d1, d2, and d3 is: {Average(d1, d2, d3):F}");
        Console.WriteLine($"Average of d1, d2, d3, and d4 is: {Average(d1, d2, d3, d4):F}");

        Console.ReadLine();
    }

    static double Average(params double[] numbers)
    {
        var total = 0.0;

        foreach (var d in numbers)
            total += d;

        return numbers.Length != 0 ? total / numbers.Length : 0.0;
    }
}
