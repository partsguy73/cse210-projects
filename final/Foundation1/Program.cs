using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");

        // Creating the videos and comments
        List <Video> videos = new List<Video>();

        Video video1 = new Video("Wand Movements 101", "Hermoine Granger", 900);
        Comment comment1 = new Comment("Rubeus Hagrid", "Well done, Hermoine!");
        Comment comment2 = new Comment("Draco Malfoy", "Nice job, but you are still a mudblood.");
        Comment comment3 = new Comment("Minerva McGonagall", "Excellent Ms. Granger. Five points for Gryffindor");

        videos.Add(video1);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Creating Your Patronus", "Harry Potter", 750);
        Comment comment4 = new Comment("Dudley Dursley", "I watched this whole video and I still can't conjure nothin'.");
        Comment comment5 = new Comment("Hugo Granger-Weasley", "Hehe, Mine is a spider uncle Harry.");
        Comment comment6 = new Comment("Victor Krum", "Maybe you and Ginny can come to Romania so you can give me a private tutorial.");

        videos.Add(video2);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("Common Magical Herbs Living In Uncommon Places", "Neville Longbottom", 1230);
        Comment comment7 = new Comment("Professor Sprout","A good crop of Mandrake is always a welcome group.");
        Comment comment8 = new Comment("Professor Slughorn", "Tentacular leaves are exceedingly rare and valuable.");
        Comment comment9 = new Comment("Harry Potter", "Don't forget about gilly weed. ");

        videos.Add(video3);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        Video video4 = new Video("Why You Should Not Follow the Spiders", "Ronald Weasley", 840);
        Comment comment10 = new Comment("Rubeus Hagrid", "Seriously misunderstood creatures, spiders.");
        Comment comment11 = new Comment("Hermoine Granger-Weasley", "Remember to swish and flick, sweatheart.");
        Comment comment12 = new Comment("George Weasley", "You're not still on about spiders are you?");

        videos.Add(video4);
        video4.AddComment(comment10);
        video4.AddComment(comment11);
        video4.AddComment(comment12);

        // Displaying videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}