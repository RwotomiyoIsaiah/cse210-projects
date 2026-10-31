using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response=Console.ReadLine();
        int grade=int.Parse(response);
        string letter;
        if(grade>=90)
        {
            letter="A";   
        }else if (grade>=80)
        {
            letter="B";
        }else if (grade>=70)
        {
            letter="C";   
        }else if (grade>=60)
        {
            letter="D";
        }else
        {
            letter="F";    
        }
        Console.WriteLine($"Your letter grade is: {letter}");
        if (grade>=70)
        {
            Console.WriteLine("Congratulations, you passed this course");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass this course");
        }
    }
}