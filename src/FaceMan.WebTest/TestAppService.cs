using FaceMan.DynamicWebAPI;
using FaceMan.EFTest;

using Microsoft.AspNetCore.Mvc;

namespace FaceMan.WebTest
{
    /// <summary>
    /// 继承IApplicationService实现的动态API服务
    /// </summary>
    public class TestAppService
    : IApplicationService
    {
        private readonly DemoDbContext _webTestDbContext;
        public TestAppService(DemoDbContext webTestDbContext)
        {
            _webTestDbContext = webTestDbContext;
        }

        /// <summary>
        /// 实现GetDataAPI接口
        /// </summary>
        /// <param name="inputParam"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> GetData(InputParam inputParam)
        {
            return await Task.FromResult("Hello World!");
        }

        /// <summary>
        /// 实现CreateDataAPI接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<string> CreateData(InputParam input)
        {
            var user = new User()
            {
                Name = "TestUser"
            };
            await _webTestDbContext.AddAsync(user);
            await _webTestDbContext.SaveChangesAsync();
            return $"{user.Id},{user.Name}";
        }

        public string UPDATEData(InputParam input)
        {
            return "Data UPDATE with input: " + input.Input;
        }

        public string DeleteData(InputParam input)
        {
            return "Data Delete with input: " + input.Input;
        }
    }

    public class InputParam
    {
        public string Input { get; set; }
        public string Input1 { get; set; }

    }
}
