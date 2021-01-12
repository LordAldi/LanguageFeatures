using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        /*public ViewResult Index()
        {
            *//*List<string> result = new List<string>();

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

        /*ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
        Product[] productArray = {
             new Product {Name = "Kayak", Price = 275M},
             new Product {Name = "Lifejacket", Price = 48.95M},
             new Product {Name = "Soccer ball", Price = 19.50M},
             new Product {Name = "Corner flag", Price = 34.95M}
         };

        decimal priceFilterTotal = productArray
            .Filter(p => (p?.Price ?? 0) >= 20)
            .TotalPrices();
        decimal nameFilterTotal = productArray
            .Filter(p => p?.Name?[0] == 'S')
            .TotalPrices();

        return View("Index", new string[] {
             $"Price Total: {priceFilterTotal:C2}",
             $"Name Total: {nameFilterTotal:C2}" 
        });*//*

        return View(Product.GetProducts().Select(p => p?.Name));
    }*/
        /*public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));*/

        public ViewResult Index()
        {
            IProductSelection cart = new ShoppingCart (
                 new Product { Name = "Kayak", Price = 275M },
                 new Product { Name = "Lifejacket", Price = 48.95M },
                 new Product { Name = "Soccer ball", Price = 19.50M },
                 new Product { Name = "Corner flag", Price = 34.95M }
             );
            return View(cart.Names);
        }
    }
}
