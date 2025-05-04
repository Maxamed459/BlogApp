using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public DateTime Created_At { get; set; } = DateTime.Now;
        public DateTime Updated_At { get; set; } = DateTime.Now;

        // Foreign key to User (Author)
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Users Author { get; set; }


        // A blog post can have many comments
        public ICollection<Comment> Comments { get; set; }

    }
}
