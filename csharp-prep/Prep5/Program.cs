using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"{name}, the square of you number is {number*number}");

    }
}