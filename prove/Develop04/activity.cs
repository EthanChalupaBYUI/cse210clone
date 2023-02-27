using System;
public class Activity
{
    public string description = "";
    public int duration;

    public Activity()
    {
    }

    public void spinner(float duration)
    {
        int spinCounter = 0;
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;

        Console.Write("Working....");
        while (currentTime.Subtract(startTime).TotalSeconds < duration)
        {
            spinCounter++;
            switch (spinCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(250);
            currentTime = DateTime.Now;
        }
    }

    public void getDuration()
    {
        Console.Write("How long would you like this activity to last?:\n");
        string userinput = Console.ReadLine();
        try
        {
            duration = int.Parse(userinput);
        }
        catch
        {
            Console.Write("Invalid input.\n");
            Thread.Sleep(500);
            getDuration();
        }
    }
}

public class Breathing : Activity
{

}

public class Reflect : Activity
{

}

public class Listening : Activity
{

}
