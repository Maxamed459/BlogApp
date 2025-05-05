using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;

        public DateTime Created_At { get; set; } = DateTime.Now;
        public ICollection<BlogPost> BlogPosts { get; set; }

    }
}
