using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int num = -1;
        int sum = 0;
        float avNum = 0;
        
        List<int> listNum = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        while(num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());

            if (num !=0)
            {
            listNum.Add(num);
            }
        }
        // The sum
        sum = listNum.Sum();
        Console.WriteLine($"The sum is {sum}");

        // The average
        avNum = sum / listNum.Count();
        Console.WriteLine($"The average is {avNum}");

        //The maximum
        int max = listNum.Max();
        Console.WriteLine($"The maximum is {max}");

        // The min 
        // I can't get it to display the minimum positive number
        int min = listNum[0];
        foreach (int minNum in listNum)
        {
            if (minNum > 0 && minNum < min)
            {
               min = minNum;
            }
        }
        Console.WriteLine($"the minimum is {min}");

    }
}