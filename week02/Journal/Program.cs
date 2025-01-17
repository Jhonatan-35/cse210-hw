using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        //Welcome banner
        Console.WriteLine("Welcome to Journal Program!");

        Console.Write("Please select one of the following choices ");
        while (true) {
            Console.WriteLine(":");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            //Requests user selection for action to take
            Console.Write("What would like to do ? ");
            string choice = Console.ReadLine();

            //Calls class methods per user selection
            switch (choice) {
                //Adds new entry
                case "1":
                journal.AddEntry();
                break;

                //Displays added entries
                case "2":
                journal.DisplayEntries();
                break;

                //Loads entries from a file
                case "3":
                journal.LoadFromFile();
                break;

                //Saves entries to a file
                case "4":
                journal.SaveToFile();
                break;

                //Exits program
                case "5":
                Console.WriteLine("Goodbye!");
                return;

                //Handles invalid input
                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5.");
                break;
            }
        }
    }
}