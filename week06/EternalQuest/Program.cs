// Added a Player Leveling System based on total accumulated score (calculated dynamically as: Level = (_score / 1000) + 1)
// this is calculated alongside their total score at the top of the main menu.

using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}