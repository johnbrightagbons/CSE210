using System;

class Program
{
    static void Main(string[] args)
    {

        // Create assignment object
        Assignment assignment1 = new Assignment("Eloghosa Osagie","Addition");
        Console.WriteLine(assignment1.GetSummary());


        // Create class assignments
        MathsAssignment assignment2 = new MathsAssignment("David Lawrence", "Subtraction", "1.5", "1-3");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomework());

        WritingAssignment assignment3 = new WritingAssignment("John Bright", "Nigeria Politics", "The fall of Adesola David");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingDetails());
    }  
}