using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class BlogContext: DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options): base(options)
        {
            
        }

        // bununla
        public DbSet<Post> Posts => Set<Post>();
        // bunun arasında fark yok
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
