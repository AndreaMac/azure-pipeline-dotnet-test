using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>();

        public ProductsController()
        {
            products.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
            products.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
            products.Add(new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            products.Add(new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });
        }

        //URI: /api/products
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        //URI: /api/products/id
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
