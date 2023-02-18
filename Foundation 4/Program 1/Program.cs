/*
Scenario
You have been hired by a company that does product awareness monitoring by tracking the placement of their products in 
YouTube videos. They want you to write a program that can help them work with the tens of thousands of videos they have 
identified as well as the comments on them.
Program Specification
Write a program to keep track of YouTube videos and comments left on them. As mentioned this could be part of a larger 
project to analyze them, but for this assignment, you will only need to worry about storing the information about a 
video and the comments.
Your program should have a class for a Video that has the responsibility to track the title, author, and length (in seconds) 
of the video. Each video also has responsibility to store a list of comments, and should have a method to return the number 
of comments. A comment should be defined by the Comment class which has the responsibility for tracking both the name of the 
person who made the comment and the text of the comment.
Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one 
add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.
Then, have your program iterate through the list of videos and for each one, display the title, author, length, number 
of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video 
in the list.
*/

// Main class
class Program1
{
    // Main function for running the program
    static void Main(string[] args)
    {
        // Creating the first video
        string video1_title = "My House Tour";
        string video1_author = "John Doe";
        int video1_duration = 567;
        Comment[] video1_comments =
        {
            new Comment("John Doe", "Thanks for watching!"),
            new Comment("James", "I really enjoyed the video!"),
            new Comment("Bob", "This video was cool."),
            new Comment("Sue", "Should have been a longer video!")
        };
        Video video1 = new Video(video1_title, video1_author, video1_duration, video1_comments);

        // Creating the second video
        string video2_title = "Testing";
        string video2_author = "Administrator";
        int video2_duration = 123;
        Comment[] video2_comments =
        {
            new Comment("John", "What is this video?"),
            new Comment("Admin", "Testing completed."),
            new Comment("Billy", "Interesting video.")
        };
        Video video2 = new Video(video2_title, video2_author, video2_duration, video2_comments);

        // Creating the third video
        string video3_title = "Watching Pigs Fly";
        string video3_author = "FunnyGuy15";
        int video3_duration = 47;
        Comment[] video3_comments =
        {
            new Comment("Joe Buck", "This is too funny!"),
            new Comment("RandomUser", "Hahahaha xD"),
            new Comment("Frank", "Thank you so much for this!"),
            new Comment("Ezra", "This is unreal!!!")
        };
        Video video3 = new Video(video3_title, video3_author, video3_duration, video3_comments);

        // Putting each video in a list, and iterating through them to print the details
        Video[] videos = { video1, video2, video3 };
        foreach (Video vid in videos)
        {
            vid.printVideoDetails();
            Console.WriteLine();
        }
    }
}