using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for the magic number
       // Console.Write("What is the magic number? ");
        //string magic = Console.ReadLine();
        //int MagicNumber = int.Parse(magic);

        // A function random numbers
        Random randomGenerator = new Random();

        // Generate random numbers between 1 and 101
        int MagicNumber = randomGenerator.Next(1, 101);

        
        int GuessNumber = 1;

        // Do a loop
       while (GuessNumber != MagicNumber)
        {
        // Ask the user for the guess number
            Console.Write("What is your guess? ");
            int guessNumber = int.Parse(( Console.ReadLine()));

        // Condition to guess the number
            if (MagicNumber > guessNumber)
            {
                Console.WriteLine("Guess Higher ");
            }

            else if (MagicNumber < guessNumber)
            {
                Console.WriteLine ("Guess Lower ");
            }
            else
            {
                Console.WriteLine ("You guessed it");
            }
        }
        
    }
}