using ECommerceDataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserServices_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("GetUserDetails")]
        [HttpGet]
        public UserModel GetUserDetails() 
        {
            UserModel obj = new UserModel();
            obj.Email = "john@gmail.com";
            obj.Name = "John";
            obj.UserId = 1001;

            return obj;
        }
    }
}
