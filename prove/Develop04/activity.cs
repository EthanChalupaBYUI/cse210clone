using System;
public class Activity
{
    public string description;
    public int duration;
    protected string startMessage = "\nWelcome!\n";
    protected string endMessage = "\nGoodbye\n";

    public Activity()
    {
    }

    public void spinner(float duration)
    {
        int spinCounter = 0;
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;

        Console.Write("...");
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

    public int getDuration()
    {
        Console.Write("How long would you like this activity to last?:\n");
        string userinput = Console.ReadLine();
        try
        {
            duration = int.Parse(userinput);
            return duration;
        }
        catch
        {
            Console.Write("Invalid input.\n");
            Thread.Sleep(500);
            getDuration();
        }
        return 0;
    }
}

public class Breathing : Activity
{

    public Breathing()
    {
    }
    public void main()
    {
        duration = getDuration();
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int counter = 0;
        Console.Write(startMessage);
        Console.WriteLine();
        Console.Write(description);
        Console.WriteLine();
        Thread.Sleep(500);
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        while (currentTime.Subtract(startTime).TotalSeconds < duration)
        {
            switch (counter % 2)
            {
                case 0: Console.Write("Breathe in."); break;
                case 1: Console.Write("Breathe out."); break;
            }
            counter++;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                Console.Write(3 - i);
                Console.Write("...");
                Console.WriteLine();
                Thread.Sleep(1000);
            }
            currentTime = DateTime.Now;
        }
        Console.Write("You have completed Breathing for ");
        Console.Write(duration);
        Console.Write(" seconds");
        Console.WriteLine();
        Console.Write(endMessage);
        Thread.Sleep(2000);

    }
}

public class Reflect : Activity
{
    public Reflect()
    {

    }
    public void main()
    {
        duration = getDuration();
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
        List<string> _prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        List<string> _prompts2 = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        Console.Write(startMessage);
        Console.WriteLine();
        Console.Write(description);
        Console.WriteLine();
        Thread.Sleep(5000);
        while (currentTime.Subtract(startTime).TotalSeconds < duration)
        {
            Random rnd = new Random();
            Console.Write(_prompts[rnd.Next(0, _prompts.Count())]);
            Console.WriteLine();
            Console.Write(_prompts2[rnd.Next(0, _prompts.Count())]);
            Console.WriteLine();
            spinner(5);
            currentTime = DateTime.Now;
        }
        Console.Write("You have completed Reflect for ");
        Console.Write(duration);
        Console.Write(" seconds");
        Console.Write(endMessage);
        Thread.Sleep(2000);

    }
}

public class Listening : Activity
{
    public Listening()
    {

    }
    public void main()
    {
        duration = getDuration();
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        List<string> _prompts2 = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
        List<string> _userInput = new List<string> { };


        Console.Write(startMessage);
        Console.WriteLine();
        Console.Write(description);
        Console.WriteLine();

        Console.Write("Prepare to Write");
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            Console.Write(5 - i);
            Console.Write("...");
            Console.WriteLine();
            Thread.Sleep(500);
        }
        Console.Write("Go!");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        while (currentTime.Subtract(startTime).TotalSeconds < duration)
        {
            string userInput = Console.ReadLine();
            Console.Write("Time Left:");
            Console.Write(currentTime.Subtract(startTime).TotalSeconds - duration);
            Console.WriteLine();
            _userInput.Add(Console.ReadLine());
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        Console.Write("What you Wrote! \n");
        for (int i = 0; i < _userInput.Count(); i++)
        {
            Console.Write(_userInput[i]);
            Console.WriteLine();
            Thread.Sleep(100);
        }
        Thread.Sleep(250);
        Console.Write("You have completed Listening for ");
        Console.Write(duration);
        Console.Write(" seconds");
        Console.Write(endMessage);
        Thread.Sleep(2000);
    }
}
