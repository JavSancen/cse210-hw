using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        string ask = "yes";

        int guessNum = -1;
        int attempts = 0;

        while (ask.ToLower() == "yes")
        {
            while (guessNum != magicNumber)
            {
                Console.Write("What is your guess? ");
                guessNum = int.Parse(Console.ReadLine());

                attempts += 1;

                if (magicNumber > guessNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guessNum)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"You tried {attempts} times");

            Console.Write("Do you want to play again? (yes/no): ");
            ask = Console.ReadLine();

            magicNumber = randomGenerator.Next(1,101);
        }
    }
}