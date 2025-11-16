using System;

public class Fraction
{
    //Private attributes (encapsulation)
    private int _top;
    private int _bottom;

    // Constructors
    // Default constructor: 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter (top)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two parameters (top, bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //  Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        // Avoid division by zero
        if (bottom == 0)
        {
            Console.WriteLine("Denominator cannot be zero. Setting to 1.");
            _bottom = 1;
        }
        else
        {
            _bottom = bottom;
        }
    }

    //  Method to return fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    //  Method to return the decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
