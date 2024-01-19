using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new();
        while (true)
        {
            int magicNumber = rand.Next(1, 101);
            int guessCount = 0;
            while (true)
            {
                Console.Write("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                   if (guessCount == 1)
                   {
                       Console.WriteLine("You got it on the first try!");
                   }
                   else
                   {
                       Console.WriteLine($"You got it in {guessCount} tries!");
                   }
                   break;
                }
            }
            Console.Write("Do you want to play again? (yes/no) ");
            string playAgain = Console.ReadLine();
            if (playAgain.ToLower() != "yes")
            {
                break;
            }
        }
    }
}