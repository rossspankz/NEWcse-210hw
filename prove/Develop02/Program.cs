using System;
using System.Runtime.InteropServices;

public class Program
{
    static void Main(string[] args)
    {
        int ans = 0;
        while (ans != 5)
        {
            Console.WriteLine("Please select from the following:");
            Console.WriteLine("1) Write"); 
            Console.WriteLine("2) Display");
            Console.WriteLine("3) Load");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Quit");
            Console.Write("What would you like to do?");
            ans = int.Parse(Console.ReadLine());

            //Gives prompt to user
            if (ans == 1)
            {
                Prompt myPrompt = new Prompt();
                myPrompt.main();
                Console.ReadLine();

            }

            //Displays to user what time, what they answered and how they answered
            else if(ans == 2)
            {
                Display myDisplay = new Display();
            }

            //Loads a .txt file that the user previously saved
            else if (ans == 3)
            {

            }
            //Saves the given reposnses in a .txt file with user given name
            else if (ans == 4)
            {
                string fileName = Console.ReadLine();
            }
        }
        
        //End of the program
        Console.WriteLine("Come back tomrrow!");

    }
}
