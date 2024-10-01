using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractiontostring());
        Console.WriteLine(f1.GetDecimalValue()); 


        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractiontostring());
        Console.WriteLine(f2.GetDecimalValue()); 

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractiontostring());
        Console.WriteLine(f3.GetDecimalValue()); 


        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractiontostring());
        Console.WriteLine(f4.GetDecimalValue()); 

    }
}