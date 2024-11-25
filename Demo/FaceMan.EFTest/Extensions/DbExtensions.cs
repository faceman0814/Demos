using FaceMan.EntityFrameworkCore;
using FaceMan.EntityFrameworkCore.Extensions;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FaceMan.EFTest.Extensions
{
    public static class DbExtensions
    {
        public static void UsingDatabaseServices(this IServiceCollection services)
        {
            new FaceManDbContextConfigurer<WebTestDbContext>().UsingDatabaseServices(services);
        }
    }
}
