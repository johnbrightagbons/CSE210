using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square ("Purple", 10);
        String squareColour = square.GetColour();
        double squareArea = square.GetArea();
        Console.WriteLine("The area of the square is " + squareArea);
        Console.WriteLine ("The colour of the square is " + squareColour);

        Rectangle rectangle = new Rectangle("Yellow", 2, 4);
        string rectangleColor = rectangle.GetColour();
        double rectangleArea = rectangle.GetArea();
        Console.WriteLine("The colour of the Rectangle is " + rectangleColor);  
        Console.WriteLine("The area of the Rectangle is " + rectangleArea);   

        Circle circle = new Circle("Red", 5);
        string circleColor = circle.GetColour();
        double circleArea = circle.GetArea();
        Console.WriteLine("The colour of the Circle is " + circleColor);  
        Console.WriteLine("The area of the Circle is " + circleArea);

        // To hold multiple shapes in a list, create a List<Shape> and 
        // add instances of different shapes to it 
        List <Shape> shapes = new List<Shape>();

        // Add a square, rectangle, and circle to this list.
        Square square1 = new Square("Purple", 10);
        shapes.Add(square1);  

        Rectangle rectangle1 = new Rectangle("Yellow", 2, 4);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Red", 5);
        shapes.Add(circle1);

        // Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
        foreach (Shape shape in shapes)
        {
            string shapeColour = shape.GetColour();
            double shapeArea = shape.GetArea();
            Console.WriteLine ("The shape colour is " + shapeColour);
            Console.WriteLine ("The shape area is " + shapeArea);
            Console.WriteLine();

        }
    }
}