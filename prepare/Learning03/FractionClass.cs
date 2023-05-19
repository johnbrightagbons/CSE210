using System;

public class Fraction // A class called fraction

// Below are the class attributes 
{
    private int _top;
    private int _bottom;

    // Create a class constructor for the class Fraction
    public Fraction() // Constructor without parameter
    {
        _top = 1; // Set the intial to 1/1
        _bottom = 1;
    }

    // Create a class constructors with a parameter
    public Fraction (int number)
    {
       _top = number;
       _bottom = 1; 
    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFraction()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimal()
    {
        return (double)_top / (double)_bottom;
    }

}