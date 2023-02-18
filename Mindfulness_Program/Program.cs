using System.IO;

class Program {
    // Main function that runs in a loop for selecting an activity.
    static void Main(string[] args) {
        Console.WriteLine("Welcome to the mindfulness program!");
        bool run_program = true;

        while(run_program) {
            MainMenu();
            string choice = Console.ReadLine(); // Get user input.
            Console.Clear();

            if(choice=="1"){
                // Breathing activity.
                Console.Clear();
                Activity breathing = new BreathingActivity();
                breathing.intro();
                Console.Clear();
            }
            else if(choice=="2"){
                // Reflecting activity.
                Console.Clear();
                Activity reflecting = new ReflectingActivity();
                reflecting.intro();
                Console.Clear();
            }
            else if(choice=="3"){
                // Listing activity.
                Console.Clear();
                Activity listing = new ListingActivity();
                listing.intro();
                Console.Clear();
            }
            else if(choice=="4"){
                // Quit program -> end the loop.
                run_program = false;
            }
            else {
                Console.WriteLine("Try Again.");
            }
        }
    }

    // This function displays the main menu for the different available options.
    public static void MainMenu() {
        Console.WriteLine("Please enter the numeric option below for the activity you would like to do:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit Program");
        Console.Write("Enter your option: ");
    }
}