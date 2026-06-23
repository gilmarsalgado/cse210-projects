using System;

class Program
{
    static void Main(string[] args)
    {
        // Constructor with 0 arguments
        Fraction fraction1 = new Fraction();
        int top = fraction1.GetTop();
        int bottom = fraction1.GetBottom();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.DecimalValue());
        
        // Constructor with 1 arguments
        Fraction fraction2 = new Fraction(5);
        int top2 = fraction2.GetTop();
        int bottom2 = fraction2.GetBottom();
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.DecimalValue());

        // Constructor with 2 arguments
        Fraction fraction3 = new Fraction(3,4);
        int top3 = fraction3.GetTop();
        int bottom3 = fraction3.GetBottom();
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.DecimalValue());

        Fraction fraction4 = new Fraction(1,3);
        int top4 = fraction3.GetTop();
        int bottom4 = fraction4.GetBottom();
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.DecimalValue());

    }
}