using FaceMan.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace FaceMan.EFTest
{
    public class DemoDbContext : FaceManDbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }


        public DbSet<User> User { get; set; }
    }
}
