using System;
using System.Collections.Generic;

public class Prompt
{
    public void main()
    {
        string prom = random();
        Display(prom);

    }
    public string random()
    {
        //list with the prompts
        List<string> _prompt = new List<string>();
        
        Display string1 = new Display();
        string1._prompt = "What was your routine today?";
        Display string2 = new Display();
        string2._prompt = "What is one thing you did to prepare for tomorrow?";
        Display string3 = new Display();
        string3._prompt = "What is something that you did today that you could've done better?";
        Display string4 = new Display();
        string4._prompt ="What was did you do today to help someone else?";
        Display string5 = new Display();
        string5._prompt = "What was the best part of today?";

        //Random Number generator 
        //Grabs random prompt from list
        Random randomNum = new Random();
        int randoNum = randomNum.Next(1, _prompt.Count);
        string randomPrompt = _prompt[randoNum];
        return randomPrompt;
    }

    public void Display(string prom)
    {
        Console.WriteLine($"{prom}");
    }

    



}

