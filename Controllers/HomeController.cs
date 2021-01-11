﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;


namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> result = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name;
                decimal? price = p?.Price;
                string relatedName = p?.Related?.Name;
                result.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
            } 
            return View(result);
        }
    }
}
