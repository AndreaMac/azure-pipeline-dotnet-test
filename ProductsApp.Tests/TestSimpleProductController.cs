using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsApp.Controllers;
using ProductsApp.Models;

namespace ProductsApp.Tests
{
    [TestClass]
    public class TestSimpleProductController
    {
        [TestMethod]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductsController();

            var result = controller.GetAllProducts() as List<Product>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public void GetProduct_ShouldReturnCorrectProduct()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductsController();

            var result = controller.GetProduct(2) as OkNegotiatedContentResult<Product>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testProducts[2].Name, result.Content.Name);
        }
        
        [TestMethod]
        public void GetProduct_ShouldNotFindProduct()
        {
            var controller = new ProductsController();

            var result = controller.GetProduct(999);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        private List<Product> GetTestProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
            products.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
            products.Add(new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            products.Add(new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M});

            return products;
        }
    }
}