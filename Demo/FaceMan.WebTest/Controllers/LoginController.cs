using Microsoft.AspNetCore.Mvc;

namespace FaceMan.WebTest.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class LoginController : Controller
    {
        [HttpGet]
        public void UserLogin(string username, string password)
        {
            //伪代码，模拟登录成功后生成access-token并设置到cookie中
            Response.Cookies.Append("access-token", "xxxxxxxxxx", new CookieOptions()
            {
                Expires = DateTimeOffset.Now.Add(TimeSpan.FromDays(1))
            }
            );
        }
    }
}
