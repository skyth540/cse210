using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("You have opened your journal.");

        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Select the number of what you wish to do:");
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {   
                case 1:
                    journal.Write();
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    Console.Write("What file?:");
                    string load = Console.ReadLine();
                    journal.Load(load);
                    break;
                case 4:
                    Console.Write("Name for the file:");
                    string save = Console.ReadLine();
                    journal.Save(save);
                    Console.WriteLine("Saved");
                    break;
                case 5:
                    Console.WriteLine("Goodbye");                
                    running = false;
                    break;
                default:
                    Console.WriteLine("Input not recognized");
                    break;
            }
        }
    }
}