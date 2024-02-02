using System;

class ArrayReferenceTest
{
    static void Main(string[] args)
    {
        // create and initialize firstArray
        int[] firstArray = { 1, 2, 3 };

        // copy the reference into variable firstArrayCopy
        int[] firstArrayCopy = firstArray;

        Console.WriteLine("Contents of firstArray before calling FirstDouble:");
        DisplayArray(firstArray);

        FirstDouble(firstArray);

        Console.WriteLine("\nContents of firstArray after calling FirstDouble:");
        DisplayArray(firstArray);

        // test whether reference was changed by FirstDouble
        if (ReferenceEquals(firstArray, firstArrayCopy))
            Console.WriteLine("\nThe references refer to the same array");
        else
            Console.WriteLine("\nThe references refer to different arrays");

        // create and initialize secondArray
        int[] secondArray = { 1, 2, 3 };

        // copy the reference into variable secondArrayCopy
        int[] secondArrayCopy = secondArray;

        Console.WriteLine("\nTest passing secondArray reference by reference:");
        Console.WriteLine("Contents of secondArray before calling SecondDouble:");
        DisplayArray(secondArray);

        SecondDouble(ref secondArray);

        Console.WriteLine("\nContents of secondArray after calling SecondDouble:");
        DisplayArray(secondArray);

        // test whether reference changed by SecondDouble
        if (ReferenceEquals(secondArray, secondArrayCopy))
            Console.WriteLine("\nThe references refer to the same array");
        else
            Console.WriteLine("\nThe references refer to different arrays");
        Console.ReadLine();
    }

    static void FirstDouble(int[] array)
    {
        // double each element's value
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] *= 2;
        }

        // modify elements of array and change reference to refer to a new array
        array = new int[] { 11, 12, 13 };
    }

    static void SecondDouble(ref int[] array)
    {
        // double each element's value
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] *= 2;
        }

        // modify elements of array and change reference to refer to a new array
        array = new int[] { 11, 12, 13 };
    }

    static void DisplayArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}
