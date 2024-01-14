using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letterg = "";

        if (percent >= 90)
        {
            letterg = "A";
        }
        else if (percent >= 80)
        {
            letterg = "B";
        }
        else if (percent >= 70)
        {
            letterg = "C";
        }
        else if (percent >= 60)
        {
            letterg = "D";
        }
        else
        {
            letterg = "F";
        }

        Console.WriteLine($"Your grade is: {letterg}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("You will have to re-take");
        }
    }
}