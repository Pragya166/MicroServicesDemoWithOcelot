using ECommerceDataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace UserServices_App.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("GetUserDetails")]
        [HttpGet]
        public async Task<UserModel> GetUserDetails() 
        {
            //UserModel UserObj = new UserModel();
            //var url = "http://localhost:5272/api/User/GetUserDetails";
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri(url);
            //    HttpResponseMessage response = await client.GetAsync(url);
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var strResult = response.Content.ReadAsStringAsync().Result;
            //        UserObj = JsonConvert.DeserializeObject<UserModel>(strResult);
            //        return UserObj;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}
            UserModel obj = new UserModel();
            obj.Email = "john@gmail.com";
            obj.Name = "John";
            obj.UserId = 1001;

            return obj;
        }
    }
}
