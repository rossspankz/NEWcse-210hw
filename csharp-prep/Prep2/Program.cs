using System;

class Program
{
    static void Main(string[] args)
    {
        string num = "0";
        string sym = "";

        Console.Write("What is your grade? ");
        num = Console.ReadLine();
        int x = int.Parse(num);

        


        if (x >= 90)
        {
            Console.WriteLine($"You got an A{sym}!");
        }
        else if (x >= 80 && x < 90)
        {

            if (x >= 87 && x < 90)
            {
                sym = "+";
            }
            else if(x <= 83 && x > 80)
            {
                sym = "-";
            }

            Console.WriteLine($"You got an B{sym} :(");
        }
        else if (x >= 70 && x < 80)
        {
            if ( x >= 77 && x < 80 )
            {
                sym = "+";
            }
            else if( x <= 73 && x > 70)
            {
                sym = "-";
            }

            Console.WriteLine($"You got an C{sym} :(");
        }
        else if (x >= 60 && x < 70)
        {
            Console.WriteLine($"You got an D :(");
        }
        else if (x < 60)
        {
            Console.WriteLine("You got an F :(");
        }

        

        if ( x >= 77 && x < 80 )
        {
            sym = "+";
        }
        else if( x <= 73 && x > 70)
        {
            sym = "-";
        }
    }
}