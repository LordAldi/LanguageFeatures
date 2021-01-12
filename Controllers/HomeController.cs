﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;


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
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                 new Product {Name = "Kayak", Price = 275M},
                 new Product {Name = "Lifejacket", Price = 48.95M},
                 new Product {Name = "Soccer ball", Price = 19.50M},
                 new Product {Name = "Corner flag", Price = 34.95M}
             };
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
        }
    }
}
