class Comment
{
    public string _commenterName { get; set; }
    public string _commentText { get; set; }

    // Constructor for Comment class
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
}