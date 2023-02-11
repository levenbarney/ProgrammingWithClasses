using System.IO;


class Program {
    
    static void Main(string[] args) {
        Console.WriteLine("Welcome to the mindfulness program!");
        bool run_program = true;

        while(run_program) {
            MainMenu();
            string choice = Console.ReadLine();
            Console.Clear();
            if(choice=="1"){
                Console.Clear();
                Activity breathing = new BreathingActivity();
                breathing.intro();
                Console.Clear();
            }
            else if(choice=="2"){
                Console.Clear();
                Activity reflecting = new ReflectingActivity();
            }
            else if(choice=="3"){
                Console.Clear();
                Activity listing = new ListingActivity();
            }
            else if(choice=="4"){
                run_program = false;
            }
            else{
                Console.WriteLine("Try Again.");
            }
        }
    }

    public static void MainMenu() {
        Console.WriteLine("Please enter the numeric option below for the activity you would like to do:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit Program");
    }

    
}