class BreathingActivity : Activity {

    int duration;
    public override void intro()
    {
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.\n");
        duration = getDuration();
        runActivity();
    }

    public override void runActivity() {
        // Setup for the activity
        float breathing_interval = 0;
        float remainder_interval = 0;

        if (duration <= 10) {
            breathing_interval = duration / 2;
        }
        else {
            breathing_interval = 5; // 5 second to breath in, and 5 seconds to breathe out
            remainder_interval = duration % breathing_interval; // remainder of the duration for the last breath in and out
        }


        Console.Clear();
        Console.WriteLine("Get ready...");
        Timer();
        Console.Clear();
        Console.WriteLine("\n");
        
        
        // Start of the activity
        
        Console.WriteLine();

        if (remainder_interval == 0) {
            for (int i = (int)Math.Floor(duration / breathing_interval)/2; i > 0; i--) {
                Console.Write("Breathe in... ");
                for (int k = (int)Math.Floor(breathing_interval); k > 0; k--) {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(Convert.ToString(k));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.Write("Breathe out... ");
                for (int k = (int)Math.Floor(breathing_interval); k > 0; k--) {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(Convert.ToString(k));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
        }
        else {
            for (int i = (int)Math.Floor(duration / breathing_interval)/2; i > 0; i--) {
                Console.Write("Breathe in... ");
                for (int k = (int)Math.Floor(breathing_interval); k > 0; k--) {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(Convert.ToString(k));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.Write("Breathe out... ");
                for (int k = (int)Math.Floor(breathing_interval); k > 0; k--) {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(Convert.ToString(k));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
            Console.Write("Breathe in... ");
            for (int k = (int)Math.Floor(remainder_interval/2); k > 0; k--) {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(Convert.ToString(k));
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.Write("Breathe out... ");
            for (int k = (int)Math.Floor(breathing_interval/2); k > 0; k--) {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(Convert.ToString(k));
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Well done!");
        Console.WriteLine("You have completed " + duration + " seconds of the Breathing Activity.");
        Timer();
    }
}