using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int input = -1;

        while (input != 0 )
        {
            Console.Write("Enter a number (0 to exit): ");

            input = int.Parse(Console.ReadLine());

            if(input != 0)
            {
                numbers.Add(input);
            }
            
            
        }

        int sum = 0;
        int max = 0;
        int min = int.MaxValue;

        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }

            if (number > 0 && number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The total sum from the list is: {sum}");

        float average = ((float)sum)/numbers.Count;

        Console.WriteLine($"The average of the list is: {average}");
        Console.WriteLine($"The max number is {max}");
        Console.WriteLine($"The min number is {min}");
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        
        
    }
}