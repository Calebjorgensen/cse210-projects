using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();


        // This is the list to get my videos up.
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Creed3","By Caleb",5.4);   //this pulls from video class

        //Line above is video one, and 3 lines below are the comments from the code.

        Comment video1Comment1 = new Comment("Caleb","This video is great");
        Comment video1Comment2 = new Comment("Elle","this is great");
        Comment video1Comment3 = new Comment("Paul","Why is this in error");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videoList.Add(video1);




        Video video2 = new Video("How to run halo mission","By Elle",6.4);  //this pulls from video class

        //Line above is video one, and 3 lines below are the comments from the code.

        Comment video2Comment1 = new Comment("elle","this is great");
        Comment video2Comment2 = new Comment("Paul","This was horrible it didn't help out with this mission at all.");
        Comment video2Comment3 = new Comment("Greg","Thanks for creating this video it helps so much.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videoList.Add(video2);

        foreach(Video video in videoList)
        {
            video.DisplayInfo();
        
        }

        
    }
}