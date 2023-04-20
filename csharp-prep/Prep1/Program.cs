using System;

class Program
{
    static void Main(string[] args)
    {
        // A prompt to ask a user for last name //
        Console.Write ("What is your first name? ");
        string FirstName = Console.ReadLine();


        // A prompt to ask user for first name //
        Console.Write ("What is your last name? ");
        string LastName = Console.ReadLine();

        // Print the user name 
        Console.WriteLine ($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}