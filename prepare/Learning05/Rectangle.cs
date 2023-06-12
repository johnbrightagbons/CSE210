public class Rectangle : Shape
{   
    // define two private variables _length and _width to store the dimensions of the rectangle
    private double _length;
    private double _width;
    
    // The constructor takes the color, length, and width as parameters 
    // initializes the base class using base(colour)
    public Rectangle(string colour, double length, double width) : base (colour)
    {
        _length = length;
        _width = width;   
    }

    // override the GetArea() method to calculate and return the area of the rectangle.
    public override double GetArea()
    {
        return _length * _width;
    }
}