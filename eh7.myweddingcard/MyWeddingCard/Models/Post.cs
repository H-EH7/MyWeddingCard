namespace MyWeddingCard.Models
{
    public class Post
    {
        public int? Id { get; set; }
        public string? Writer { get; set; }
        public string? Content { get; set; }
        public DateTime? CreatedDate { get; set; }

        public Post(string Writer, string Content)
        {
            CreatedDate = DateTime.Now;
        }
    }
}
