using System.IO;

// Activity superclass.
class Activity 
{
    private int _counter;

    public virtual void intro() {
        // This will be the introduction function for each activity.
    }

    // Function for getting the duration of the activity in seconds from the user.
    public int getDuration() {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string duration = Console.ReadLine();
        int duration_int = Convert.ToInt32(duration);
        return duration_int;
    }

    public virtual void runActivity() {
        // This is the psuedofunction where the activity will take place and be overriden by each class.
    }

    // Timer function for the loading icon.
    public void Timer() 
    {
        for (var i = 0; i < 10; i++) 
        {
            Turn();
            Thread.Sleep(500);
        }
        ClearCurrentConsoleLine();
    }

    // Function for clearing the current console line.
    public static void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }

    // Function for displaying the loading icon.
    public void Turn()
    {
        _counter++;
        switch (_counter % 4)
        {
            case 0:
                Console.Write("/");
                break;
            case 1:
                Console.Write("-");
                break;
            case 2:
                Console.Write("\\");
                break;
            case 3:
                Console.Write("|");
                break;
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }
}