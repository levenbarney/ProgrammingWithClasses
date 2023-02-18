/*
Scenario
You have been hired by an event planning company. They help organize and market events throughout the world. 
They need you to write a program to track each of these events and produce the marketing material to distribute 
on social media. They typically handle a few main types of events:
- Lectures, which have a speaker and have a limited capacity.
- Receptions, which require people to RSVP, or register, beforehand.
- Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
They would like the ability to generate three different messages:
- Standard details - Lists the title, description, date, time, and address.
- Full details - Lists all of the above, plus type of event and information specific to that event type. 
  For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. 
  For outdoor gatherings, this includes a statement of the weather.
- Short description - Lists the type of event, title, and the date.
Program Specification
Write a program that has a base Event class along with derived classes for each type of event. These classes 
should contain the necessary data and provide methods to return strings for each of the messages the company 
desires.
Remember that any data or methods that are common among all types of events should be in the base class.
Once you have the classes in place, write a program that creates at least one event of each type and sets 
all of their values. Then for each event, call each of the methods to generate the marketing messages 
and output their results to the screen.
In addition, your program must:
- Use inheritance to avoid duplicating shared attributes and methods.
- Use an address class for the addresses.
- Follow the principles of encapsulation, making sure each member variable is private.
*/

class Program3
{
    public static void Main(string[] args)
    {
        // Lecture event
        Console.WriteLine("Event 1 - Lecture\n");
        Lecture lectureEvent = new Lecture("Lecture", "Professor Barney",
        "Lecture about programming with classes with Leven Barney in the STC in room 243!",
        "3/10/2023", "7:00 PM", new Address("210 West 4th South", "Rexburg", "ID", "United States"),
        "Leven Barney", 100);

        // Getting each description
        Console.WriteLine(lectureEvent.getShortDescription());
        Console.WriteLine(lectureEvent.getStandardDetails());
        Console.WriteLine(lectureEvent.getFullDetails());

        // Reception event
        Console.WriteLine("\nEvent 2 - Reception\n");
        Reception receptionEvent = new Reception("Reception", "Brenner and Emily's Wedding Reception",
        "Please come to Brenner and Emily's wedding reception to celebrate their marriage!", "8/25/2023",
        "3:00 PM", new Address("123 Idaho Falls Rd", "Idaho Falls", "ID", "United States"), "brenner98@gmail.com");

        // Getting each description
        Console.WriteLine(receptionEvent.getShortDescription());
        Console.WriteLine(receptionEvent.getStandardDetails());
        Console.WriteLine(receptionEvent.getFullDetails());

        // Outdoor gathering event
        Console.WriteLine("\nEvent 3 - Outdoor Gathering\n");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Outdoor Gathering", "Snowman Making",
        "Come to the BYU-I stadium field to help each other make snowmen!", "2/26/2023", "8:00 PM",
        new Address("239 S 1st W", "Rexburg", "ID", "United States"), "Snowing, 4 inches of snow expected");

        // Getting each description
        Console.WriteLine(outdoorEvent.getShortDescription());
        Console.WriteLine(outdoorEvent.getStandardDetails());
        Console.WriteLine(outdoorEvent.getFullDetails());
    }
}