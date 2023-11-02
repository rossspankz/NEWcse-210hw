using System;
public class Display
{
    
    public string _prompt;
    public string _response;
    public string _date;
    public string _thePrompt;

    //Displays the date, prompt, and the response when user hits 2
    public void dislpay()
    {
        Console.WriteLine($"Date: {_date} - {_thePrompt}");
        Console.WriteLine($"_response");
    }

}