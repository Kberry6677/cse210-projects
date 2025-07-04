using System;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();
        List<int> posNumbers = new List<int>();
        List<int> sortedNumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        int sumNumbers = numbers.Sum();
        Console.WriteLine($"The sum is: {sumNumbers}");
        double avgNumbers = numbers.Average();
        Console.WriteLine($"The average is: {avgNumbers}");
        int maxNumbers = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumbers}");
        foreach (int entry in numbers)
        {
            if (entry > 0)
            {
                posNumbers.Add(entry);
            }
        }
        int minPositive = posNumbers.Min();
        Console.WriteLine($"The smallest positive number is: {minPositive}");
        sortedNumbers = numbers;
        sortedNumbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int entry in sortedNumbers)
        {
            Console.WriteLine(entry);
        }
    }
}