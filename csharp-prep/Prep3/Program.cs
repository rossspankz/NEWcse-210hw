using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic Number?");
        int magicNumber = int.Parse(Console.ReadLine());

        int gue = 0;

       while(magicNumber != gue)
        {
            Console.Write("What is your guess?");
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
            }
        }
    }
}