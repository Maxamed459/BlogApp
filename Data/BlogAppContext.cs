using Microsoft.EntityFrameworkCore;
using BlogApp.Models;

namespace BlogApp.Data
{
    public class BlogAppContext : DbContext
    {

        public BlogAppContext(DbContextOptions<BlogAppContext> options)
            : base(options)
        {}

        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<BlogPost> BlogPosts { get; set; } = null!;

    }
}
