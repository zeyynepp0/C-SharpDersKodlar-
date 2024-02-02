using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class GradeBook
{
    private int[,] grades;

    public string CourseName { get; }

    public GradeBook(string name, int[,] gradesArray)
    {
        CourseName = name;
        grades = gradesArray;
    }

    public void DisplayMessage()
    {
        Console.WriteLine($"Welcome to the grade book for {CourseName}!");
    }

    public void ProcessGrades()
    {
        OutputGrades();
        Console.WriteLine();
        Console.WriteLine($"Lowest grade in the grade book is: {GetMinimum()}");
        Console.WriteLine($"Highest grade in the grade book is: {GetMaximum()}");
        OutputBarChart();
    }

    public int GetMinimum()
    {
        var lowGrade = grades[0, 0];

        foreach (var grade in grades)
        {
            if (grade < lowGrade)
                lowGrade = grade;
        }

        return lowGrade;
    }

    public int GetMaximum()
    {
        var highGrade = grades[0, 0];

        foreach (var grade in grades)
        {
            if (grade > highGrade)
                highGrade = grade;
        }

        return highGrade;
    }

    public double GetAverage(int student)
    {
        var gradeCount = grades.GetLength(1);
        var total = 0.0;

        for (var exam = 0; exam < gradeCount; exam++)
        {
            total += grades[student, exam];
        }

        return total / gradeCount;
    }

    public void OutputBarChart()
    {
        Console.WriteLine("Grade distribution:");

        var frequency = new int[11];

        foreach (var grade in grades)
        {
            ++frequency[grade / 10];
        }

        for (var count = 0; count < frequency.Length; count++)
        {
            Console.Write($"{count * 10:D2}-{count * 10 + 9:D2}: ");

            for (var stars = 0; stars < frequency[count]; stars++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    public void OutputGrades()
    {
        Console.WriteLine("Test scores:");

        for (var test = 0; test < grades.GetLength(1); test++)
        {
            Console.Write($"Test {test + 1,2}");
        }

        Console.WriteLine();

        for (var student = 0; student < grades.GetLength(0); student++)
        {
            Console.Write($"Student {student + 1,2}");

            for (var grade = 0; grade < grades.GetLength(1); grade++)
            {
                Console.Write($" {grades[student, grade],3}");
            }

            Console.WriteLine();
        }
    }
}

class GradeBookTest
{
    static void Main()
    {
        int[,] gradesArray = {
        {96, 65, 85, 75, 83},
        {68, 94, 100, 83, 78},
        {85, 91, 76, 87, 87},
        {100, 81, 87, 94, 72},
        {93, 90, 82, 65, 100},
        {84, 82, 65, 100, 84}
        };
        // (Diğer öğrenci notları buraya eklenir)

        GradeBook myGradeBook = new GradeBook("CS101 Introduction to C# Programming", gradesArray);
        myGradeBook.DisplayMessage();
        myGradeBook.ProcessGrades();
        Console.ReadLine();
    }
}

