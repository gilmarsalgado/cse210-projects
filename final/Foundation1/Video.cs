using System;
using System.Dynamic;

public class Video{
    public string _title;
    public string _author;
    public int _length; // seconds
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }
    // count Comments

    public void AddCommentToList(Comment comment){
        _comments.Add(comment);
    }
    
    public void DisplayTheVideoAndComments(){
        Console.WriteLine($"{_title} by {_author} ({_length} seconds)");
        Console.WriteLine($"Comments ({_comments.Count})");
        for (int i = 0; i<_comments.Count(); i++){
            _comments[i].DisplayComments();
        }
        Console.WriteLine("");
    }

    public double CountNumberComments(List<Comment> comment){
        return comment.Count();
    }

}