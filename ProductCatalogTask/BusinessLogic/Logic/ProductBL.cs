using DataAccessLayer;
using DataAccessLayer.Repositry;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Logic
{
    public class ProductBL : Repositry<Product>
    {

        public ProductBL(ProductTask dbContext): base(dbContext)
        {

        }
        public List<Product> Search(string searchTerm)
        {
            var result = DbSet.Where(p => p.ProductId.ToString().ToLower().Contains(
                   searchTerm.ToLower()) ||
                   p.ProductName.ToLower().Contains(searchTerm.ToLower()) ||
                   p.Price.ToString().ToLower().Contains(searchTerm.ToLower()) ||
                   p.LastUpdated.ToString().ToLower().Contains(searchTerm.ToLower())
                   ).ToList();
            return result;
        }

    }
}
