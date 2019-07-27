using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ConsumAPiProduct.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace ConsumAPiProduct.Controllers
{
    public class ProductController : Controller
    {
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment _env;
        private readonly Uri _APIUrL;

        public ProductController(IFileProvider fileprovider, IHostingEnvironment env)
        {
            fileProvider = fileprovider;
            _env = env;
            _APIUrL = new Uri("https://localhost:44388/api/Products");

        }

        // GET: Product
        #region List Products
        public ActionResult Index()

        {
            IEnumerable<ProductModel> Products = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = _APIUrL;
                //HTTP GET
                var responseTask = client.GetAsync("Products");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ProductModel>>();
                    readTask.Wait();

                    Products = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    Products = Enumerable.Empty<ProductModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(Products);
        }
        #endregion

        #region Create 
        public ActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CreateProduct(ProductModel productobj, IFormFile Photo)
        {
            if (ModelState.IsValid)
            {
                productobj.LastUpdated = DateTime.Now;
                if (Photo != null || Photo.Length != 0)
                {
                    // Create a File Info 
                    FileInfo fi = new FileInfo(Photo.FileName);

                    // This code creates a unique file name to prevent duplications 
                    // stored at the file location
                    var newFilename = String.Format("{0:d}",
                                      (DateTime.Now.Ticks / 10) % 100000000) + "_" + fi.Extension;
                    var webPath = _env.WebRootPath;
                    //var path = Path.Combine("", webPath+ newFilename);
                    var path = Path.Combine("", webPath + @"\user-images\" + newFilename);

                    // This stream the physical file to the allocate wwwroot/ImageFiles folder
                    // IMPORTANT: The pathToSave variable will be save on the column in the database
                    var pathToSave = @"/user-images/" + newFilename;
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await Photo.CopyToAsync(stream);
                    }
                    productobj.Photo = pathToSave;

                }
                try
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = _APIUrL;

                        //HTTP POST
                        var postTask = client.PostAsJsonAsync<ProductModel>("/api/products", productobj);
                        postTask.Wait();

                        var result = postTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }

            }
            else
                ModelState.AddModelError(string.Empty, "You Must Fill All fields.");

            return View();
        }
        #endregion

        #region Edit
        public ActionResult EditProduct(int Id)
        {
            ProductModel Products = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44388/api/ProductsGetProduct?id=" + Id);
                //HTTP GET
                var responseTask = client.GetAsync("Products");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ProductModel>>();
                    readTask.Wait();

                    Products = readTask.Result.Where(a => a.ProductId == Id).FirstOrDefault();
                }
                else //web api sent error response 
                {
                    //log response status here..

                    Products = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(Products);
        }
        [HttpPost]
        public async Task<ActionResult> EditProduct(ProductModel productobj, IFormFile Photo)
        {
            if (ModelState.IsValid)
            {
                productobj.LastUpdated = DateTime.Now;
                if (Photo != null && Photo.Length != 0)
                {
                    // Create a File Info 
                    FileInfo fi = new FileInfo(Photo.FileName);

                    // This code creates a unique file name to prevent duplications 
                    // stored at the file location
                    var newFilename = String.Format("{0:d}",
                                      (DateTime.Now.Ticks / 10) % 100000000) + "_" + fi.Extension;
                    var webPath = _env.WebRootPath;
                    //var path = Path.Combine("", webPath+ newFilename);
                    var path = Path.Combine("", webPath + @"\user-images\" + newFilename);

                    // This stream the physical file to the allocate wwwroot/ImageFiles folder
                    // IMPORTANT: The pathToSave variable will be save on the column in the database
                    var pathToSave = @"/user-images/" + newFilename;
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await Photo.CopyToAsync(stream);
                    }
                    productobj.Photo = pathToSave;
                }
                using (var client = new HttpClient())
                {

                    client.BaseAddress = _APIUrL;

                    //HTTP POST
                    var postTask = client.PutAsJsonAsync<ProductModel>("/api/products", productobj);
                    postTask.Wait();

                    var result = postTask.Result;


                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }

            else
                ModelState.AddModelError(string.Empty, " You must fill All fields.");

            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        public async Task<ActionResult> DeleteProduct(int Id)
        {
            if (Id > 0)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = _APIUrL;

                    //HTTP DELETE
                    try
                    {
                        var deleteTask = await client.DeleteAsync("/api/products/" + Id);
                        if (deleteTask.IsSuccessStatusCode)
                        {

                            return RedirectToAction("Index");
                        }
                    }

                    catch (TaskCanceledException ex)
                    {

                    }

                }
            }


            return RedirectToAction("Index");

        }
        #endregion

        #region View

        public ActionResult ViewProduct(int Id)
        {
            ProductModel Products = null;
            if (Id > 0)
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:44388/api/ProductsGetProduct?id=" + Id);
                        //HTTP GET
                        var responseTask = client.GetAsync("Products");
                        responseTask.Wait();

                        var result = responseTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            var readTask = result.Content.ReadAsAsync<IList<ProductModel>>();
                            readTask.Wait();

                            Products = readTask.Result.Where(a => a.ProductId == Id).FirstOrDefault();
                        }
                        else //web api sent error response 
                        {
                            //log response status here..

                            Products = null;

                            ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            if (TempData["ProductId"] != null)
            {
                TempData["ProductId"] = null;
                return View("EditProduct", Products);

            }
            return View(Products);
        }
        #endregion
    }
}