using System;
using System.Runtime.CompilerServices;

class Program
{
    public static String getGradeSuffix(double grade)
    {
        if (grade < 97 && grade > 60)
        {
            if (grade % 10 >= 7)
            {
                return "+";
            }
            else if (grade % 10 <= 3)
            {
                return "-";
            }
            else
            {
                return null;
            }
        }
        else
        {
            return null;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        double grade = double.Parse(Console.ReadLine());
        if (grade <= 100)
        {
            String gradeSuffix = getGradeSuffix(grade);
            if (grade >= 90)
            {
                Console.WriteLine($"Your grade is an A{gradeSuffix}.");
            }
            else if (grade >= 80)
            {
                Console.WriteLine($"Your grade is a B{gradeSuffix}.");
            }
            else if (grade >= 70)
            {
                Console.WriteLine($"Your grade is a C{gradeSuffix}.");
            }
            else if (grade >= 60)
            {
                Console.WriteLine($"Your grade is a D{gradeSuffix}.");
            }
            else if (grade < 60)
            {
                Console.WriteLine($"Your grade is an F{gradeSuffix}.");
            }
        }
        else
        {
            Console.WriteLine("Your grade is not in the appropriate format.");
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation you passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass the course.  Better luck next time.");
        }
    }
}