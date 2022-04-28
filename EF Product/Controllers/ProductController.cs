using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewEF.Models;

namespace NewEF.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Product/prod")]
        public IActionResult prod(Product pd)
        {
            if (ModelState.IsValid)
            {
                ProductDBContext pdb = new ProductDBContext();
                pdb.Add(pd);
                pdb.SaveChanges();
                return Content("Product Saved");
            }
            return View("Index");
        }
    }
}
