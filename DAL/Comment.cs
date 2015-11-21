namespace DAL
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public string CommentEmail { get; set; }
        public Mark Mark { get; set; }
        public string CommentDescription { get; set; }
    }
}