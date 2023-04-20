using System;

class Program
{
    static void Main(string[] args)
    {
    // Write a program that determines the letter grade for a course according to the following scale:
    // A >= 90 B >= 80 C >= 70 D >= 60 F < 60

        Console.Write ("Kindly enter your score: "); // Prompt the user to enter a score
        string UserScore = Console.ReadLine(); // Collect the score entered in form of string
        int number = int.Parse(UserScore); // Convert the string to number
        
        // Create a boolean variable called letters to hold the grades
        bool letters = (number >=90) || (number >=80) || (number >=70) || (number >=60) || (number < 59); 
        string letter = letters.ToString(); // Convert the letters to string and stores it in a variable, letter
        

        // The conditions to determine the grades
        if (number >= 90)
        {
            letter = ("A");
        }
        
        else if (number >= 80)
        {
            letter = ("B");
        }

        else if (number >= 70)
        {
            letter = ("C");
        }

        else if (number >= 60)
        {
            letter = ("D");
        }

        else
        {
            letter = ("F");
        }
        Console.WriteLine ($"Your final grade is: {letter}");

    // Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. 
    // Add a separate if statement to determine if the user passed the course, 
    // and if so display a message to congratulate them. 
    // If not, display a different message to encourage them for next time.

    int PassMark = number; 
    if (PassMark >= 70)
    {
        Console.WriteLine("Congratulation, you passed.");
    }
    
    else
    {
        Console.WriteLine("You did not pass, try harder next time.");
    }

    }
}