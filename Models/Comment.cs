using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string CommentText { get; set; } = string.Empty;

        public DateTime Created_At { get; set; } = DateTime.Now;

        // Foreign key to BlogPost
        [ForeignKey("BlogPost")]
        public int PostId { get; set; }
        public BlogPost BlogPost { get; set; }

        // Foreign key to User (comment author)
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
