using System;
class Program
{
    static void Main(string[] args)
    {
        DisplayReference theReference = new(book:"", chap:0, vrs_n:0); 
        bool proceed = false;
        while (proceed == false)
        {
        Console.Write("Input the book, chapter, and verse number of the scripture you would like to memorize separated by commas: \n");
        string[] listRef = Console.ReadLine().Split(",");

        if (listRef.Count() == 3)
        {
            proceed = true;
            theReference = new DisplayReference(book:listRef[0], chap:int.Parse(listRef[1]), vrs_n:int.Parse(listRef[2]));
        }
        else 
        {
        Console.Write("Not recognized. Please try again to ");
        }
        }
        Console.WriteLine("Input the verse text: \n ");
        theReference.SetText();
        Scripture scripture = new(theReference);
        
        string run = "";
        while (run != "STOP")
        {
            if(scripture.IsAllBlank())
            {
                Console.Write("Good job!");
                break;
            }
            scripture.HideWord(4);
            Console.Clear();
            scripture.DisplayText();
            Console.Write("Complete the empty spaces and press enter to continue, or type STOP to end\n");
            run = Console.ReadLine().ToLower();
                if(run == "STOP")
                {
                    break;
                }            
        }
    }
}