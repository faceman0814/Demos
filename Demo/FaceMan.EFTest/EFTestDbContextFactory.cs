using FaceMan.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace FaceMan.EFTest
{
    public class EFTestDbContextFactory : FaceManDbContextFactory<WebTestDbContext>
    {
        public override WebTestDbContext CreateDbContext(string[] args)
        {
            args = new[] { "FaceMan.WebTest" }.Concat(args).ToArray();
            return base.CreateDbContext(args);
        }
    }
}
