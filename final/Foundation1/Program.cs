using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        List<Video> videosList = new List<Video>();

        Video video1 = new Video("How to run new Halo mission");

        Comment video1Commment1 = new Comment("This was great");

        video1.ListComment(video1Commment1);

        videosList.Add(video1);

        foreach(Video video in videosList)
        {
            video.DisplayInfo();
            
            
        }


        
    }
}