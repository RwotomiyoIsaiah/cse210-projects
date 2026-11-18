public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment>_comments=new List<Comment>();
    //constructor
    public Video(string title,string author,int length)
    {
        _title=title;
        _length=length;
        _comments=new List<Comment>();
        _author=author;
     
    }
    public int GetCommentCount()
    {
        return _comments.Count();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
}