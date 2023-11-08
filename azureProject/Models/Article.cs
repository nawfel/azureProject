namespace azureProject.Models
{
    public class Article
    {
        public Article()
        {
            
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Comment Comment { get; set; }
        public int CommentId { get; set; }

        public string ImageUrl { get; set; }


    }
}
