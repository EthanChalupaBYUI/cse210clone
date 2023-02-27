using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Menu Options \n  1.Start breathing activity \n  2.Start reflecting activity \n  3.Start listing activity\n");
        string userInput = Console.ReadLine();

        try
        {
            int userChoice = int.Parse(userInput);

            if (userChoice == 1)
            {
                Activity activitytest = new Activity();
                activitytest.getDuration();
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


        Activity activity = new Activity();
        activity.spinner(5);
    }
}