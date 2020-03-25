using System;

namespace Deliverable01
{
    class Program
    {
        static string TravelSuggestion(int flightSize)
        {
            string aircraft = "home";

            if (flightSize <= 2)
            {
                aircraft = "first class flight";
            }
            else if (flightSize <= 5)
            {
                aircraft = "helicopter";
            }
            else
            {
                aircraft = "charter flight";
            }
            return aircraft;
        }

        static string Destination(string choice)
        {
            string destination = "home";
            choice = choice.ToLower();

            switch (choice)
            {
                case "musical":
                    destination = "New Orleans";
                    break;
                case "tropical":
                    destination = "a beach vacation in Mexico";
                    break;
                case "adventurous":
                    destination = "whitewater rafting in the Grand Canyon";
                    break;
            }

            return destination;
        }

        static void Main(string[] args)
        {
            string vacationType = "";
            int groupSize = 0;
            string result = "";

            Console.Write("What kind of trip would you like to go on? Musical, tropical, or adventurous? ");
            vacationType = Console.ReadLine();

            Console.Write("How many are in your group? ");
            groupSize = Int32.Parse(Console.ReadLine());
            while (groupSize < 1)
            {
                Console.Write("Please enter a group size of at least 1. ");
                groupSize = Int32.Parse(Console.ReadLine());
            }

            result = "Since you're a group of " + groupSize + " going on a " + vacationType 
                + " vacation, you should take a " + TravelSuggestion(groupSize) + " to " + Destination(vacationType) + ".";
            
            Console.WriteLine(result);
        }
    }
}
