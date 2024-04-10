using System;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Oceanview Terrace", "Seaside", "Beach City", "90210", "USA");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Underwater Exploration Symposium", "Conference about marine life and ocean conservation.", "July 15, 2023", "9:00 am - 5:00 pm", $"{lectureAddress}", "Lecture", "Dr. Neptune", 250);

        lecture.ShowShortDescription();
        Console.WriteLine();
        lecture.ShowStandardDetails();
        Console.WriteLine();
        lecture.ShowDisplayLectureFullDetails();


        Address address2 = new Address("Mountainview Avenue", "Forest Town", "Wilderness", "12345", "Canada");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Alice and Bob", "Alice and Bob's enchanted forest wedding", "December 31, 2022", "6:00 pm - 1:00 am", $"{receptionAddress}", "Reception", "alice.bob@example.com");

        reception.ShowShortDescription();
        Console.WriteLine();
        reception.ShowStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address("Skyline Drive", "Cloud City", "Skytopia", "54321", "Skyworld");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Skydiving Adventure", "Experience the thrill of skydiving with professional instructors.", "October 10, 2023", "10:00 am", $"{outdoorAddress}", "Outdoor", "Cloudy");

        outdoor.ShowShortDescription();
        Console.WriteLine();
        outdoor.ShowStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
    }
}