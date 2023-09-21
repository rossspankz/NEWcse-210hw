using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string nombre = PromptUserName();
        int numb = PromptUserNumber();
        int numbSqr = SquareNumber(numb);
        DisplayResult(nombre, numbSqr);

    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your username: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static int SquareNumber(int num)
        {
            int numSqr = num* num;
            return numSqr;
        }
        static void DisplayResult(string userName, int numSqr)
        {
            Console.WriteLine($"{userName}, the square of your number is {numSqr}");
        }
    
}