using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1= new Video("God Has a Plan For You","The Church of Jesus Christ of Latter-day Saints",429);
        video1.AddCommentToList(new Comment("REDFAN","Nice video"));
        video1.AddCommentToList(new Comment("Abigail",":)"));
        video1.AddCommentToList(new Comment("Tim","weow"));

        Video video2= new Video("Easy Pizza Dough Recipe","Preppy Kitchen",568);
        video2.AddCommentToList(new Comment("Wayne","What if I have instant yeast"));
        video2.AddCommentToList(new Comment("Sindy","Looks great"));
        video2.AddCommentToList(new Comment("Lilian","A great recipe, thanks."));

        Video video3= new Video("A Mock Trial with Real Stakes","Suits Official",616);
        video3.AddCommentToList(new Comment("Josh","Fine, I’ll re-watch Suits again…"));
        video3.AddCommentToList(new Comment("Goom","Skinny Louis is s tier"));
        video3.AddCommentToList(new Comment("Kyle","Harvey isn’t wrong what he said"));
        
        video1.DisplayTheVideoAndComments();
        video2.DisplayTheVideoAndComments();
        video3.DisplayTheVideoAndComments();



        
    }
}