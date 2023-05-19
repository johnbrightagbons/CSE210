using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction Decimal = new Fraction ();
        Console.WriteLine(Decimal.GetFraction());
        Console.WriteLine(Decimal.GetDecimal());

        Fraction Decimal1 = new Fraction (5);
        Console.WriteLine(Decimal1.GetFraction());
        Console.WriteLine(Decimal1.GetDecimal());

        Fraction Decimal2 = new Fraction (3, 4);
        Console.WriteLine(Decimal2.GetFraction());
        Console.WriteLine(Decimal2.GetDecimal());

        Fraction Decimal3 = new Fraction (1, 3);
        Console.WriteLine(Decimal3.GetFraction());
        Console.WriteLine(Decimal3.GetDecimal());
    }
}