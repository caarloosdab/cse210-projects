class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _lengthInSeconds { get; set; }
    private List<Comment> comments; // List to store comments for the video

    // Constructor for Video class
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>(); // Initialize the list of comments
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Method to get the list of comments
    public List<Comment> GetComments()
    {
        return comments;
    }
}
