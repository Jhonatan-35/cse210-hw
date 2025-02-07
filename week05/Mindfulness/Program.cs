using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine(" Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Choose an activity:");

            choice = Convert.ToInt32(Console.ReadLine());
            Activity activity = null;
             

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectingActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (activity != null)
            {
                activity.StartActivity();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 4);
    }
}