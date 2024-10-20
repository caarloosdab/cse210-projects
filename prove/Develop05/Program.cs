// Exceeding requiremnt activity:
//he text during the breathing animation grows quickly at first and then 
//slows as the breath ends. This is done in the PauseWithCountdown method, where:
// Inhaling: Text grows with increasing periods (dots) on each second, simulating the air filling up.
//Exhaling: Text shrinks with decreasing periods, simulating the slower release of breath.
//BreathingActivity Class; Line 20-41


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartBreathingActivity();
                    break;
                case "2":
                    StartReflectionActivity();
                    break;
                case "3":
                    StartListingActivity();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }


             static void StartBreathingActivity()
    {
        BreathingActivity breathing = new BreathingActivity();
        breathing.RunActivity();
    }

    static void StartReflectionActivity()
    {
        ReflectionActivity reflection = new ReflectionActivity();
        reflection.RunActivity();
    }

    static void StartListingActivity()
    {
        ListingActivity listing = new ListingActivity();
        listing.RunActivity();
    }
}
        
    }
}