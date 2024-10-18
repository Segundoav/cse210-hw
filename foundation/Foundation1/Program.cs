using System;
using System.Collections.Generic;

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }

}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }
    private List<Comment> comments = new List<Comment>();


    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
    }
    
    public void AddComment(Comment comment)

    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()

    {
        return comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create videos

        Video video1 = new Video("Visual Studio Code", "Carlos Alvarez", 600);
        Video video2 = new Video("Learn Python", "Dina Boluarte", 800);
        Video video3 = new Video("JavaScript", "Francisco Tudela", 500);

        // Add comments
        video1.AddComment(new Comment("Jorge", "Very interesting tutorial"));
        video1.AddComment(new Comment("Martin", "Nice video"));
        video1.AddComment(new Comment("Maria", "Great tutorial"));

        // Add comments
        video2.AddComment(new Comment("Agustin", "Good explanation"));
        video2.AddComment(new Comment("Mario", "Good"));
        video2.AddComment(new Comment("Julio", "Very clear"));

        // Add comments
        video3.AddComment(new Comment("Luis", "Very helpful"));
        video3.AddComment(new Comment("Daniel", "Excelent explanation"));
        video3.AddComment(new Comment("Pedro", "Very good"));


        List<Video> videos = new List<Video> { video1, video2, video3 };


        foreach (var video in videos)
        {
            Console.WriteLine($"\"Title:\" {video.Title}, \"Author:\" {video.Author}, \"Duration:\" {video.Duration} seconds");
            Console.WriteLine($"\"Comments:\" ({video.GetCommentCount()})");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}