using System;
using System.Runtime.InteropServices;



class Program
{
    static void Main(string[] args)
    {
        int ans = 0;

        Console.WriteLine("Please select from the following:");
        Console.WriteLine("1) Write"); 
        Console.WriteLine("2) Display");
        Console.WriteLine("3) Load");
        Console.WriteLine("4) Save");
        Console.WriteLine("5) Quit");
        Console.Write("What would you like to do?");
        ans = int.Parse(Console.ReadLine());

        if (ans == 1)
        {

        }

        else if( ans == 2)
        {

        }

        else if (ans == 3)
        {

        }
        else if (ans == 4)
        {
            string fileName = Console.ReadLine();
            
        }
        else if(ans == 5)
        {

        }
        else 
        {
            Console.WriteLine("Enter Valid number please.");

        }

    }
}