// Added a Player Leveling System based on total accumulated score calculated as: Level = (_score / 1000) + 1
// this is calculated alongside their total score at the top of the main menu. also symbols have been added to the goal details to indicate if a goal is complete or not.[.],[X]

using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}