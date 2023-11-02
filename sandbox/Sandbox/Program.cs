using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> stringList = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Date",
            "Fig",
            "Grapes"
        };

        // Create a Random instance
        Random random = new Random();

        // Generate a random index
        int randomIndex = random.Next(0, stringList.Count);

        // Get the random string from the list
        string randomString = stringList[randomIndex];

        // Print the random string
        Console.WriteLine("Random string: " + randomString);
    }
}