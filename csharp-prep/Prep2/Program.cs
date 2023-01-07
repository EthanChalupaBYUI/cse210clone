using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?:");
        string userInput = Console.ReadLine();
        try
        {
            int grade = int.Parse(userInput);

            if (grade >= 90)
            {
                Console.WriteLine("You got an A.");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("You got an B.");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("You got an C.");
            }
            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("You got an D.");
            }
            else if (grade < 60)
            {
                Console.WriteLine("You got an F, you suck.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        catch{
            Console.WriteLine("Nice, you failed to put in a valid grade");
        }
    }
}