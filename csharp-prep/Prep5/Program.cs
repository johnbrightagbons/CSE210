using System;

class Program
{
    static void Main(string[] args)
    {

        // Declare Variables to be used
        DisplayWelcome();
        string UserName = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = SquaredNumber(number);
        DisplayResult (name, square);
    }

        // Function that return nothing
        static void DisplayWelcome ()
    {
        Console.WriteLine ("Welcome to the program ");
    }


        // Fubctions that return values
    static string PromptUserName()
    {
        Console.Write ("Kindly enter your username: ");
        string name = Console.ReadLine();
        return name;
    }


    static int PromptUserNumber ()
    {
        Console.Write ("Kindly enter your favourite number: ");
        int favNum = int.Parse (Console.ReadLine());
        return favNum;
    }


    static int SquaredNumber (int number)
    {
        int square = number * number;
        return square;
    }


    static void DisplayResult (string name, int square)
    {
        Console.WriteLine ($"Your name is {name}, the square of your Favourite number is {square}");
    }
}