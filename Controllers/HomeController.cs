using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            /*List<string> result = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                result.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            } 
            return View(result);*/

            /*Dictionary<string,Product> products = new Dictionary<string, Product>
            {
                ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
                ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            };
            return View("Index", products.Keys);*/
            bool FilterByPrice(Product p)
            {
                return (p?.Price ?? 0) >= 20;
            };
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                 new Product {Name = "Kayak", Price = 275M},
                 new Product {Name = "Lifejacket", Price = 48.95M},
                 new Product {Name = "Soccer ball", Price = 19.50M},
                 new Product {Name = "Corner flag", Price = 34.95M}
             };

            Func<Product, bool> nameFilter = delegate (Product prod)
             {
                 return prod?.Name[0] == 'S';
             };

            decimal priceFilterTotal = productArray
                .Filter(FilterByPrice)
                .TotalPrices();
            decimal nameFilterTotal = productArray
                .Filter(nameFilter)
                .TotalPrices();

            return View("Index", new string[] {
                 $"Price Total: {priceFilterTotal:C2}",
                 $"Name Total: {nameFilterTotal:C2}" 
            });
        }
    }
}
