﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheEverythingStore.Models;

namespace TheEverythingStore.Controllers
{
    public class HomeController : Controller
    {
        // connect to db
        private DbModel db = new DbModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Products()
        {
            /* old untyped ViewBag Code
            var products = new List<string>();

            // create mock products
            for (int i = 1; i <= 10; i++)
            {
                products.Add("Product " + i.ToString());
            }

            // pass mock products to the view for display
            ViewBag.Products = products; */

            //var products = new List<Product>();

            //for (int i = 1; i <= 10; i++)
            //{
            //    Product product = new Product();
            //    product.Name = "Product " + i.ToString();
            //    products.Add(product);
            //}

            // use the Product model to retrieve the entire product list from sql server
            var products = db.Products.ToList();

            // load the view and pass the product list to it
            return View(products);
        }

        public ActionResult ViewProduct(string ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View();
        }
    }
}