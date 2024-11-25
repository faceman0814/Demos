using FaceMan.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace FaceMan.EFTest
{
    public class EFTestDbContextFactory : FaceManDbContextFactory<WebTestDbContext>
    {
        public override WebTestDbContext CreateDbContext(string[] args)
        {
            args= args.Concat(new[] { "FaceMan.WebTest" }).ToArray();
            return base.CreateDbContext(args);
        }
    }
}
