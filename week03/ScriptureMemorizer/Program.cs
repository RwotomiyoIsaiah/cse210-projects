using System;
class Program
{
    static void Main(string[] args)
    {
        // Creativity: The program hides three words at a time and
        // only selects words that have not already been hidden.
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths hhh";

        Scripture scripture = new Scripture(reference, text);
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            if (scripture.IsCompletelyHidden())
            {
                break;//final end state
            }
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;//quit
            }
            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}