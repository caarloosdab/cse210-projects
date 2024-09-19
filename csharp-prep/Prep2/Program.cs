using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        
        char secondNumber = percentage[1];
        int secondDigit = int.Parse(secondNumber.ToString());
        

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";   
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed");
        }
        else if (grade < 70)
        {
            Console.WriteLine("Sorry, you failed");
        }

        string sign = "";

        if (secondDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (secondDigit < 3 && letter != "F")
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");
    }
}