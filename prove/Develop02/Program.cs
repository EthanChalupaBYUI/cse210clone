using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        Console.WriteLine("Options:\n 1. Create Entry\n 2. Delete Entry\n 3. Edit Entry\n 4. Display Entry ");
        String userInput = Console.ReadLine();
        try
        {
            int userChoice = int.Parse(userInput);

            if (userChoice == 1)
            {
                journal.createEntry();
            }
            else if (userChoice == 2)
            {

            }
            else if (userChoice == 3)
            {

            }
            else if (userChoice == 4)
            {

            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
        catch
        {
            Console.WriteLine("Invalid Input");
        }
        Console.WriteLine("would you like to continue?:y/n");
        string userContinue = Console.ReadLine();
        if (userContinue == "y")
        {
            Main();
        }
    }
}