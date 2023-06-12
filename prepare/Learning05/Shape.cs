
public abstract class Shape 
{
    // Member Variable
    private string _colour;

    public Shape(string colour)
    {
        _colour = colour;
    }

    // Getter and Setter for colour
    // Constructor with Colour parameter
    public string GetColour()
    {
        return _colour;
    }

    public void SetColour (string colour)
    {
        _colour = colour;
    }


    // Virtural turn to abstract Method to get area

    public abstract double GetArea();

}