using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        String num = "0";
        


        Console.Write("What is your grade? ");
        x = Console.ReadLine();

        if (x >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (x >= 80)
        {
            Console.WriteLine("You got an B!");
        }
        else if (x >= 70)
        {
            Console.WriteLine("You got an C :(");
        }
        else if (x >= 60)
        {
            Console.WriteLine("You got an D");
        }
        else if (x < 60)
        {
            Console.WriteLine("You got an F");
        }
    }
}