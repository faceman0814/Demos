using FaceMan.EntityFrameworkCore;
using FaceMan.EntityFrameworkCore.Extensions;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FaceMan.EFTest.Extensions
{
    public static class DbExtensions
    {
        /// <summary>
        /// 注册数据库服务
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterDatabase(this IServiceCollection services)
        {
            var configurer = new FaceManDbContextConfigurer<WebTestDbContext>();
            //注册数据库
            configurer.UsingDatabaseServices(services);
            //检查数据库
            var isDatabaseExists = configurer.PerformDatabaseCheck(services.BuildServiceProvider());
            //如果数据库存在，则执行种子数据
            if (isDatabaseExists)
            {
                configurer.SeedData();
            }
        }
    }
}
