using System;
using System.Linq;

class Employee
{
    public string FirstName { get; }
    public string LastName { get; }
    private decimal monthlySalary;

    public decimal MonthlySalary
    {
        get
        {
            return monthlySalary;
        }
        set
        {
            if (value >= 0M)
            {
                monthlySalary = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Monthly salary must be nonnegative");
            }
        }
    }

    public Employee(string firstName, string lastName, decimal monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;
        MonthlySalary = monthlySalary; // Kullanıcıdan değer almak için MonthlySalary'yi set edebilirsiniz.
    }

    // Override the ToString method to provide a string representation of the object
    public override string ToString()
    {
        return $"{FirstName,-10} {LastName,-10} {MonthlySalary:C}";
    }
}

class LinqWithArrayOfObjects
{
    static void Main()
    {
        // Initialize an array of employees
        var employees = new[]
        {
            new Employee("James", "Red", 5000M),
            new Employee("Jason", "Green", 7600M),
            new Employee("Matthew", "Indigo", 3587.5M),
            new Employee("Lüke", "Indigo", 4700.77M),
            new Employee("Jason", "Brown", 6200M),
            new Employee("John", "Doe", 3200M)
        };

        Console.WriteLine("Initial array:");
        foreach (var element in employees)
        {
            Console.WriteLine(element);
        }

        // Select employees with salary between 4000 and 6000
        var between4K6K = employees.Where(e => e.MonthlySalary >= 4000M && e.MonthlySalary < 6000M);

        Console.WriteLine($"\nEmployees earning in the range {4000:C} - {6000:C} per month:");
        foreach (var element in between4K6K)
        {
            Console.WriteLine(element);
        }

        // Order the employees by last name, then first name
        var nameSorted = employees.OrderBy(e => e.LastName).ThenBy(e => e.FirstName);

        Console.WriteLine("Employee names when sorted by last name, then first name:");
        if (nameSorted.Any())
        {
            Console.WriteLine(nameSorted.First());
        }
        else
        {
            Console.WriteLine("Not found");
        }

        // Use LINQ to select employee last names, then use Distinct to select unique last names
        var lastNames = employees.Select(e => e.LastName);

        Console.Write("Employee last names: ");
        foreach (var element in lastNames.Distinct())
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        // Use LINQ to select first and last names
        var names = employees.Select(e => new { e.FirstName, e.LastName });

        Console.WriteLine("Employee full names:");
        foreach (var element in names)
        {
            Console.WriteLine($"{element.FirstName} {element.LastName}");
        }
        Console.ReadLine();
    }
}
