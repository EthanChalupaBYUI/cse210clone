using System;
public class activity
{
    public void spinner(int duration){
        int spinCounter = 0;
        int durationCounter = 0;
        Console.Write("Working....");
        while (durationCounter < duration)
        {
            spinCounter++;
            durationCounter++;
            switch (spinCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}

public class Breathing : activity
{

}

public class Reflect : activity
{
    
}

public class Listening : activity
{
    
}