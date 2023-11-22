using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments1 = new List<Comment>();
        List<Comment> comments2 = new List<Comment>();
        List<Comment> comments3 = new List<Comment>();

        // create 3 videos, values, and associated comments
        Comment comment1 = new Comment("@undecidedUnderground", " They're not just nice, high-revving engines, they're also reliable. My F20C1 has ~180k miles on it. ");
        Comment comment2 = new Comment("@adam-nv9zo1", " I always love the Honda teardowns, but the F20c1 was a real treat. What an amazing piece of engineering. Thank you for the great video.  ");
        Comment comment3 = new Comment("@benmorse", " I felt the presence and tears of angels while you were tearing down this gift from the engine gods. There is an S2000 in my family so I've experienced what a sweet engine the F20 is. It's amazing. Really a shame that this happened. The oil rings all looked like they were done. The engine probably ran low on oil and the rod bearings bore the brunt. Very sad. I need a drink. ");

        comments1.Add(comment1);
        comments1.Add(comment2);
        comments1.Add(comment3);

        Video video1 = new Video("6.4L Hemi Engine Teardown", "Michael Carmichael", 14.12, comments2);

        Comment comment4 = new Comment("@paul06090", " The original f20c had a factory redline of 9k rpm but in the AP2 generation was a stroked version, the f22c and it had a lower rpm in favor of some extra bottom end power. I would say that engine was 100% money shifted going from 2nd to 3rd. Its super easy to do plus the only way to rev the engine high enough to grenade a rod journal. ");
        Comment comment5 = new Comment("@endangeredmarmot", " This engine is a beauty of engineering - so well designed and built. It must have seen some serious abuse to grenade like that ");
        Comment comment6 = new Comment("@michaelgaskins9573", " I would love to see a teardown of a volvo t5, t6, or xc90 v8 motor, especially a s60r motor. Love your videos. Keep up the great work! ");

        comments2.Add(comment4);
        comments2.Add(comment5);
        comments2.Add(comment6);

        Video video2 = new Video("Honda K Series Engine Teardown", "Willy McKeel", 48.90, comments3);

        Comment comment7 = new Comment("@surftech12", " As an old gear head who has never torn down a modern engine, I find your tear downs relaxing and very interesting.  I've now watched quite a few, and was wondering what would be considered a serviceable/reusable part, like aluminum bolts from a merc bi-turbo, cam gears, exotic chains, etc.  Thanks for doing a great channel!!!");
        Comment comment8 = new Comment("@srarahRulez", " first thing I noticed is that they have the wrong oil filter on it. There've been some reports that aftermarket oil filters can cause issues on this engine due to the OEM ones having been designed for a very high flow rate that the aftermarket ones might not be able to keep up with ");
        Comment comment9 = new Comment("@dylanmcarter", " Eric, with the S2000 engine it was all about NOT exceeding the piston speed, you really didn't want this baby to rev any higher than it was designed too. Things start to go badly if the rev limiter doesn't do it's job correctly. Thanks for showing us this beautiful engine in detail, and thanks for another nice video! ");

        comments3.Add(comment7);
        comments3.Add(comment8);
        comments3.Add(comment9);

        Video video3 = new Video("Honda S2000 Catastrophic Engine Teardown", "I Do Cars", 33.75, comments1);

        // add them to the lists
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // iterate through the list of videos for each one
        // displayig the title, author, length, and number of comments for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.CommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                comment.DisplayComment();
            }

            Console.WriteLine();
        }
    }
}