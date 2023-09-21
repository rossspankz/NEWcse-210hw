using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        string ans = "y";
        while (ans == "y")
        {
            
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 1000);

            Console.WriteLine("Welcome to number guesser!");
            Console.WriteLine("Guess the number between 1-1000 to win!");
            int gue = 0;
            int numGuess = 0;

            while(magicNumber != gue)
            {
                Console.Write("What is your guess?");
                numGuess += 1;
                gue = int.Parse(Console.ReadLine());

                if ( magicNumber > gue)
                {
                    Console.WriteLine("Higher");
                }
                
                else if (magicNumber < gue)
                {
                    Console.WriteLine("Lower");
                }
            
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {numGuess} tries.");
                    
                }
            }
            Console.Write("Do you want to play again y/n? ");
            ans = Console.ReadLine();
        } 
        Console.WriteLine("Thanks for Playing! Play again soon!");
        
    }
}