using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            BLL.Products products = new BLL.Products();

            ViewData["Message"] = "Products List";
            //ViewData["List"] = products.ToString();

            return View(products.GetProducts());
        }
    }
}
