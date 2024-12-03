using ECommerceDataModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ProductService_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("GetProductList")]
        [HttpGet]
        public async Task<List<ProductModel>> GetProductList()
        {
            //List<ProductModel> ProductList=new List<ProductModel>();
            //var url = "http://localhost:5270/api/Product/GetProductList";
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress= new Uri(url);
            //    HttpResponseMessage response = await client.GetAsync(url);
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var strResult=response.Content.ReadAsStringAsync().Result;
            //        ProductList=JsonConvert.DeserializeObject<List<ProductModel>>(strResult);
            //        return ProductList;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}

            List<ProductModel> ProductList = new List<ProductModel>
            {
                new ProductModel{Id=1,Category="Programming Book",Name="C#",Price=3500},

                new ProductModel{Id=1,Category="AutoBiography",Name="Unfinished",Price=350},


                new ProductModel{Id=1,Category="Programming Book",Name="C++",Price=300},


                new ProductModel{Id=1,Category="SelfHelp",Name="The Magic of thinking big",Price=3500},


                new ProductModel{Id=1,Category="Programming Book",Name="C#",Price=3500}
            };
            return ProductList;
        }


        
    }
}
