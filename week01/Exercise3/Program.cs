using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepPlaying;
        do
        {
            keepPlaying = false;
            Boolean correct = false;
            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            while (!correct)
            {
                Console.Write("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());
                count += 1;
                if (guess == magicNumber)
                {
                    Console.WriteLine($"You guessed it in {count} tries!");
                    correct = true;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }                
            }

            Console.WriteLine("Would you like to play again? (Y/N) ");
            char playAgain = char.Parse(Console.ReadLine());
            if (playAgain == 'Y' || playAgain == 'y')
            {
                keepPlaying = true;
            }
        } while (keepPlaying == true);
    }
}