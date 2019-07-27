using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConsumingProductApi.Controllers
{
    public class ProductCatalogController : Controller
    {
        public ActionResult Index()

        {
            IEnumerable<Product> Products = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44388/api/Products");
                //HTTP GET
                var responseTask = client.GetAsync("Products");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Product>>();
                    readTask.Wait();

                    Products = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    Products = Enumerable.Empty<Product>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(Products);
        }
        public ActionResult tryry()
        {
            return View();
        }
    }
}