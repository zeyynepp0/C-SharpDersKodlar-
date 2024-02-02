using System;

class Program
{
    static void Main()
    {
        int[] gradesArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

        // Create GradeBook object
        GradeBook myGradeBook = new GradeBook("CS101 Introduction to C# Programming", gradesArray);

        // Display welcome message
        myGradeBook.DisplayMessage();

        // Process grades
        myGradeBook.ProcessGrades();

        
        Console.ReadLine();
    }
}

class GradeBook
{
    private int[] grades;

    // Getter-only auto-implemented property CourseName
    public string CourseName { get; }

    // Two-parameter constructor
    public GradeBook(string name, int[] gradesArray)
    {
        CourseName = name;
        grades = gradesArray;
    }

    // Display a welcome message
    public void DisplayMessage()
    {
        Console.WriteLine($"Welcome to the grade book for {CourseName}!");
    }

    // Perform various operations on the data
    public void ProcessGrades()
    {
        // Output grades array
        OutputGrades();

        // Call method GetAverage to calculate the average grade
        Console.WriteLine($"Class average is: {GetAverage():F}");

        // Call methods GetMinimum and GetMaximum
        Console.WriteLine($"Lowest grade is: {GetMinimum()}");
        Console.WriteLine($"Highest grade is: {GetMaximum()}");

        // Call method OutputBarChart to display grade distribution chart
        OutputBarChart();
    }

    // Find minimum grade
    public int GetMinimum()
    {
        var lowGrade = grades[0];

        foreach (var grade in grades)
        {
            if (grade < lowGrade)
            {
                lowGrade = grade;
            }
        }

        return lowGrade;
    }

    // Find maximum grade
    public int GetMaximum()
    {
        var highGrade = grades[0];

        foreach (var grade in grades)
        {
            if (grade > highGrade)
            {
                highGrade = grade;
            }
        }

        return highGrade;
    }

    // Determine average grade for test
    public double GetAverage()
    {
        var total = 0.0; // Initialize total as a double

        // Sum students' grades
        foreach (var grade in grades)
        {
            total += grade;
        }

        // Return average of grades
        return total / grades.Length;
    }

    // Output bar chart displaying grade distribution
    public void OutputBarChart()
    {
        Console.WriteLine("Grade distribution:");

        // Stores frequency of grades in each range of 10 grades
        var frequency = new int[11];

        // For each grade, increment the appropriate frequency
        foreach (var grade in grades)
 
    {
        ++frequency[grade / 10];
    }


        // For each grade frequency, display bar in chart
        for (var count = 0; count < frequency.Length; ++count)
        {
            if (count == 10)
            {
                Console.Write("  100: ");
            }
            else
            {
                Console.Write($"{count * 10:D2}-{count * 10 + 9:D2}: ");
            }

            // Display bar of asterisks
            for (var stars = 0; stars < frequency[count]; ++stars)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    // Output the contents of the grades array
    public void OutputGrades()
    {
        Console.WriteLine("The grades are:");

        // Output each student's grade
        for (var student = 0; student < grades.Length; ++student)
        {
            Console.WriteLine($"Student {student + 1,2}: {grades[student],3}");
        }
    }
}
