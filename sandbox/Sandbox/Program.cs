using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to ChronoShift Prototype!");
        Console.WriteLine("Press Enter to start...");
        Console.ReadLine();

        // Initialize game variables
        int currentTimePeriod = 0;
        int numberOfTimePeriods = 3; // You can add more time periods
        bool gameOver = false;

        // Game loop
        while (!gameOver)
        {
            Console.Clear();
            Console.WriteLine($"Current Time Period: {currentTimePeriod + 1}");

            // Simulate gameplay mechanics here
            Console.WriteLine("You can manipulate time in this level.");
            Console.WriteLine("1. Rewind Time");
            Console.WriteLine("2. Fast Forward Time");
            Console.WriteLine("3. Merge Timelines");
            Console.WriteLine("4. Solve Puzzle");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Time is rewinding...");
                    Thread.Sleep(1000); // Simulate time manipulation
                    break;

                case "2":
                    Console.WriteLine("Time is fast-forwarding...");
                    Thread.Sleep(1000); // Simulate time manipulation
                    break;

                case "3":
                    Console.WriteLine("Timelines are merging...");
                    Thread.Sleep(1000); // Simulate time manipulation
                    break;

                case "4":
                    Console.WriteLine("Solving a puzzle...");
                    Thread.Sleep(2000); // Simulate puzzle-solving
                    Console.WriteLine("Puzzle solved!");
                    if (currentTimePeriod < numberOfTimePeriods - 1)
                    {
                        currentTimePeriod++;
                        Console.WriteLine("You move to the next time period.");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("You've completed all time periods. Game Over!");
                        gameOver = true;
                    }
                    break;

                case "5":
                    Console.WriteLine("Exiting the game...");
                    gameOver = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Thank you for playing ChronoShift Prototype!");
    }
}
