using System;
using System.ComponentModel.Design;
class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        Console.WriteLine("Mindfulness Program\n");
        bool run = true;
        while (run)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit\n");
            int select = -1;
            while (select != 1 && select != 2 && select != 3 && select != 4)
            {
                Console.Write("Select an activity 1-3 or 4 to quit:\n");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    select = input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            switch (select)
            {   
                case 1:
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    breathingCount++;
                    break;
                case 2:
                    Console.Clear();
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.RunReflectionActivity();
                    reflectingCount++;
                    break;
                case 3:
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    listingCount++;
                    break;
                case 4:
                    run = false;

                    if (breathingCount + reflectingCount + listingCount == 0)
                    {
                        Console.WriteLine("Goodbye.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("You did the following:");
                        if (breathingCount > 0)
                        {
                            Console.WriteLine($"Breathing Activity: {breathingCount} times");
                        }
                        if (reflectingCount > 0)
                        {
                            Console.WriteLine($"Reflecting Activity: {reflectingCount} times");
                        } 
                        if (listingCount > 0)
                        {
                            Console.WriteLine($"Listing Activity: {listingCount} times\n");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Not recognized. Please try again.\n");
                    break;
            }
        }
    }
}