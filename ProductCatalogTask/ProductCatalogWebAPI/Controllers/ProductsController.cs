using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Logic;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace ProductCatalogWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProductBL _ProductBL { get; }
        public ProductsController(ProductBL productBL)
        {
            _ProductBL = productBL;

        }
        // GET api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ProductBL.GetAll().ToList());
        }
        // GET api/products/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_ProductBL.GetById(id));
        }
        // POST api/products
        [HttpPost]
        public IActionResult Post(Product product)
        {

            return Ok(_ProductBL.Add(product));
        }
        // PUT api/products
        [HttpPut]
        public IActionResult Put(Product product)
        {
            return Ok(_ProductBL.Update(product));
        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            Product product = null;
            if (Id>0)
            {
               product= _ProductBL.GetById(Id);
            }
            return Ok(_ProductBL.Delete(product));
        }
        [HttpGet("Search")]
        public IActionResult Search(string searchTerm)
        {

            return Ok(_ProductBL.Search(searchTerm));
        }

    }
}
