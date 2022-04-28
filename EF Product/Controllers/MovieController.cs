using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewEF.Models;

namespace NewEF.Controllers
{
    public class MovieController : Controller
    {
       
        public IActionResult Indx()
        {
            return View(); 
        }
        [Route("Movies/Create")]
        public IActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieDBContext dBContext = new MovieDBContext();
                dBContext.Add(m);
                dBContext.SaveChanges();
                return Content("Saved");
            }
            return View("Index");
            
        }
    }
}
