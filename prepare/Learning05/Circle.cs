public class Circle : Shape
{
    // create private variable _radius to store the radius of the circle.
    private double _radius;

    // The constructor takes the color and radius as parameters and initializes the base class using base(colour)
    public Circle (string colour, double radius) : base(colour)

    {
        _radius = radius;
    }

    // The GetArea() method is overridden to calculate and return the area of the circle using the formula Math.PI * radius^2
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}