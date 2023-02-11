using System.IO;

class Activity 
{
    private int _counter;

    public virtual void intro() {
        // This will be the introduction for the activity
    }

    public int getDuration() {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string duration = Console.ReadLine();
        int duration_int = Convert.ToInt32(duration);
        return duration_int;
    }

    public virtual void runActivity() {
        // This is where the activity will take place
    }

    public void Timer() 
    {
        for (var i = 0; i < 10; i++) 
        {
            Turn();
            Thread.Sleep(350);
        }
    }

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