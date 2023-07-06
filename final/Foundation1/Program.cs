using System;
using System.Collections.Generic;

class  Program
{
    static void Main(string[] args)
    {  
        // Create video list
        List<Video> videos = new List<Video>();

        // Create and add videos with comments to the list
        Video video1 = new Video // Add first video
        {
            Title = "Fundamental Basics Of C# Programming Language",
            Author = "John Bright Agbons",
            Length = 500,
            Comments = new List<Comment>
            {
                new Comment { commenterName = "Alexander", commentContent = "The video is very educational" },
                new Comment { commenterName = "Adrian", commentContent = "The video is simple to understand" }
            }
        };
        videos.Add(video1);

        // Create a second video
        Video video2 = new Video
        {
            Title = "Powerful Concepts on C#",
            Author = "Barry Larry",
            Length = 700,
            Comments = new List<Comment>
            {
                new Comment { commenterName = "Ruben", commentContent = "The video is highly recommended" },
                new Comment { commenterName = "Ademola", commentContent = "Nice showing of great understanding" }
            }
        };
        videos.Add(video2);

        // Create a third video
        Video video3 = new Video
        {
            Title = "Christ is the Hope for Tomorrow",
            Author = "Alma Moroni",
            Length = 900,
            Comments = new List<Comment>
            {
                new Comment { commenterName = "Harry", commentContent = "Nice video" },
                new Comment { commenterName = "John", commentContent = "Great video, has a lot to ponder on" }
            }
        };
        videos.Add(video3);

        // Show the information for the various videos and their comments
        foreach (var video in videos)
        {
            Console.WriteLine("The video title: " + video.Title);
            Console.WriteLine("The Author is: " + video.Author);
            Console.WriteLine("The duration of the video is: " + video.Length + " seconds");
            Console.WriteLine("The number of comments on the video: " + video.Comments.Count);
            Console.WriteLine();
            Console.WriteLine("Comments Made: ");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine("The name of the person that commented: " + comment.commenterName);
                Console.WriteLine("The comment made: " + comment.commentContent);
            }
            Console.WriteLine();
        }
    }
}
