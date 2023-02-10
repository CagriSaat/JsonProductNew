using Microsoft.AspNetCore.Mvc;

namespace JsonProduct.Controllers
{
    public class ProductController : Controller
    {

        [HttpGet]
        public async Task<IActionResult> GetSingleProduct()
        {
            var u = "https://dummyjson.com/products/1";
            using var client = new HttpClient();
            var res = await client.GetAsync(u);
            var content = await res.Content.ReadAsStringAsync();
            return Json(content);
        }
     public async Task< IActionResult>GetAllProducts()
        {
            var u = "https://dummyjson.com/products";
            using var client = new HttpClient();
            var res = await client.GetAsync(u);
            var content = await res.Content.ReadAsStringAsync();
            return Json(content);

        }
        public async Task<IActionResult> SearchProducts()

        {
            var u = "https://dummyjson.com/products/search?q=phone";
            using var client = new HttpClient();
            var res = await client.GetAsync(u);
            var content = await res.Content.ReadAsStringAsync();
            return Json(content);



        }

        public async Task<IActionResult> LimitAndSkipProducts ()
        {
            var u = "https://dummyjson.com/products?limit=10&skip=10&select=title,price";
            using var client = new HttpClient();
            var res = await client.GetAsync(u);
            var content = await res.Content.ReadAsStringAsync();
            return Json(content);




        }




    }
}



