using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        // Create a list 
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int number = -1;
        while (number != 0)
        {
            Console.Write("Kindly enter a number: ");
            string reply = Console.ReadLine();
            number = int.Parse (reply);
                
            
            if (number !=0)
            {
                numbers.Add(number);
            }
        } 

        // Calculate the Sum 
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;   
        }
        Console.WriteLine ($"The sum is equal to: {sum} ");

        // To calculate the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine ($"The average of the numbers is: {average}");

        // To find the highest
        int highest = numbers[0];
        foreach (int num in numbers)
        {
            if (num > highest)
            {
                highest = num;
            }
        }
        Console.WriteLine ($"The biggest number is {highest}");
  }
}