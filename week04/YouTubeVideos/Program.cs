using System;
using System.Collections.Generic;

namespace YouTubeSimulation
{
    // Video class
    class Video
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public int Duration { get; set; } // in seconds
        private int views = 0;
        private List<Comment> comments = new List<Comment>();

        public void Play()
        {
            views++;
            Console.WriteLine($"Playing video: {Title} ({Duration} seconds). Views: {views}");
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
            Console.WriteLine($"Comment added by {comment.Author}: {comment.Text}");
        }

        public void ShowComments()
        {
            Console.WriteLine($"Comments for {Title}:");
            foreach (var comment in comments)
            {
                Console.WriteLine($"{comment.Author}: {comment.Text}");
            }
        }
    }

    // Comment class
    class Comment
    {
        public string Author { get; set; }
        public string Text { get; set; }

        public Comment(string author, string text)
        {
            Author = author;
            Text = text;
        }
    }

    // Playlist class
    class Playlist
    {
        public string Name { get; set; }
        private List<Video> videos = new List<Video>();

        public void AddVideo(Video video)
        {
            videos.Add(video);
            Console.WriteLine($"Added video '{video.Title}' to playlist '{Name}'.");
        }

        public void ShowVideos()
        {
            Console.WriteLine($"Playlist '{Name}' contains:");
            foreach (var video in videos)
            {
                Console.WriteLine(video.Title);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Sample 
            Video video1 = new Video { Title = "C# Basics", URL = "https://youtube.com/1", Duration = 300 };
            Video video2 = new Video { Title = "OOP Concepts", URL = "https://youtube.com/2", Duration = 400 };

            Playlist playlist = new Playlist { Name = "Learning C#" };
            playlist.AddVideo(video1);
            playlist.AddVideo(video2);
            playlist.ShowVideos();

            video1.Play();
            video1.AddComment(new Comment("Alice", "Great video!"));
            video1.ShowComments();
        }
    }
}
