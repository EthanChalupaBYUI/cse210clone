using System;
// Just realized WriteLine can be used with text in it
class Program
{
    static void Main()
    {
        Console.Write("Menu Options \n  1.Start breathing activity \n  2.Start reflecting activity \n  3.Start listing activity\n 4.Quit \n");
        string userInput = Console.ReadLine();

        try
        {
            int userChoice = int.Parse(userInput);

            if (userChoice == 1)
            {
                Breathing breathing = new Breathing();
                breathing.spinner(3);
                breathing.main();
            }
            else if (userChoice == 2)
            {
                Reflect reflect = new Reflect();
                reflect.spinner(3);
                reflect.main();
            }
            else if (userChoice == 3)
            {
                Listening listening = new Listening();
                listening.spinner(3);
                listening.main();
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
            Main();
        }
        Main();
    }
}