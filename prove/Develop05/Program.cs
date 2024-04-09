using System;
class Program
{
    static void Main(string[] args)
    {
        string menuSelected = "";
        GoalsTracker goals = new GoalsTracker();
        while (menuSelected != "6")
        {

            int points = goals.GetAccumulatedPoints();
            Console.WriteLine("Eternal Quest Program");
            if (points > 0)
            {
                Console.WriteLine($"You have {points} points.\n");
            }
            Console.WriteLine("1 Create Goal");
            Console.WriteLine("2 List Goals");
            Console.WriteLine("3 Save Goals");
            Console.WriteLine("4 Load Goals");
            Console.WriteLine("5 Record Achievement");
            Console.WriteLine("6 Quit");
            Console.Write("Select an option 1-5 or 6 to quit:\n");
            menuSelected = Console.ReadLine();
            switch (menuSelected)
            {
                case "1":
                    Console.WriteLine("1 Simple Goal");
                    Console.WriteLine("2 Eternal Goal");
                    Console.WriteLine("3 Checklist Goal");
                    Console.Write("Select an option 1-3");
                    string goalType = Console.ReadLine();
                    switch (goalType)
                    {
                        case "1":
                            SimpleGoal newSimpleGoal = new SimpleGoal();
                            newSimpleGoal.CreateChildGoal();
                            goals.addGoal(newSimpleGoal);
                            break;
                        case "2":
                            EternalGoal newEternalGoal = new EternalGoal();
                            newEternalGoal.CreateChildGoal();
                            goals.addGoal(newEternalGoal);
                            break;
                        case "3":
                            ChecklistGoal newChecklistGoal = new ChecklistGoal();
                            newChecklistGoal.CreateChildGoal();
                            goals.addGoal(newChecklistGoal);
                            break;
                        default:
                            Console.WriteLine("Not recognized, please try again.\n");
                            break;
                    }
                    break;
                case "2":
                    goals.ListGoals();
                    break;
                case "3":
                    goals.SaveGoals();
                    break;
                case "4":
                    goals.LoadGoals();
                    break;
                case "5":
                    goals.RecordEventInTracker();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not recognized, please try again.\n");
                    break;
            }
        }
    }
}