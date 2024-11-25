using FaceMan.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace FaceMan.EFTest
{
    public class WebTestDbContext : FaceManDbContext
    {
        public WebTestDbContext(DbContextOptions<WebTestDbContext> options) : base(options)
        {
        }


        public DbSet<User> User { get; set; }
    }
}
