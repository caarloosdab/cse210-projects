using System;

class Program
{
    static void Main(string[] args)
    {
        
    string again = "yes";

        while (again == "yes")
        {    
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 0;
            int guesses = 0;
        
            while (guess != magicNumber)
            {

                Console.WriteLine("Guess the magic number ");
                string number = Console.ReadLine();
                guess = int.Parse(number);
                
            
                if (guess < magicNumber) 
                {
                    Console.WriteLine("Too low, guess again");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Too high, guess again");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                }
                guesses += 1;

            }
            Console.WriteLine($"You guessed the magic number in {guesses} guesses");

            Console.WriteLine("Do you wanna keep playing? ");
            again = Console.ReadLine();
        
        }
        
    }
}