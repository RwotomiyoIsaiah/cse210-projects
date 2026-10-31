using System;
class Program
{
    static void Main(string[] args)
    {
        displayWelcome();
        string name=PromptUserName();
        int favouriteNumber= PromptUserNumber("What is your favourite number: ");
        string reply=DisplayResult(name,SquareNumber(favouriteNumber));
        Console.WriteLine(reply);
    }

    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username=Console.ReadLine();
        return username;
    }
    static int PromptUserNumber(string message)
    {
        Console.Write(message);
        string response=Console.ReadLine();
        int number=int.Parse(response);
        return number;    
    }
    static int SquareNumber(int favouriteNumber)
    {
        int squared= (favouriteNumber*favouriteNumber);
        return squared;
    }
    static string DisplayResult(string name, int squareNumber)
    {
        return ($"{name}, the square of your number is {squareNumber}");
    }

}