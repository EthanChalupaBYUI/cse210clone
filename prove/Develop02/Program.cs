using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        userloop(journal);
    }

    static void userloop(Journal journal)
    {
        Console.WriteLine("Options:\n 1. Create Entry\n 2. Delete Entry\n 3. Save journal\n 4. Load journal \n 5. Display Entries \n 6. Exit ");
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
                journal.display();
                Console.WriteLine("Which would you like to delete?: ");
                userInput = Console.ReadLine();
                try
                {
                    int toDelete = int.Parse(userInput);
                    journal.deleteEntry(toDelete);
                }
                catch
                {
                    Console.WriteLine("invaild input");
                    userloop(journal);
                }
            }
            else if (userChoice == 3)
            {
                journal.saveData();
            }
            else if (userChoice == 4)
            {
                journal.loadData();
            }
            else if (userChoice == 5)
            {
                journal.display();
            }
            else if (userChoice == 6)
            {
                Environment.Exit(0);
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
            userloop(journal);
        }
    }


}