using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AdoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdoMVC.DAL;

namespace AdoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CustomerDAL custDAL = new CustomerDAL();
            List<Customer> CustomerList = new List<Customer>();
            CustomerList = custDAL.GetAllCustomers();
            return View(CustomerList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Customer c)
        {
            CustomerDAL cobj = new CustomerDAL();
            int result = cobj.NewCustomer(c);
            if (result == 1)
            {
                return RedirectToAction("Index");
            }
            else return RedirectToAction("Create");
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Del(Customer c)
        {
            CustomerDAL cobj = new CustomerDAL();
            int result = cobj.DelCustomer(c);
            if (result == 1)
            {
                return RedirectToAction("Index");
            }
            else return RedirectToAction("Delete");
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Upd(Customer c)
        {
            CustomerDAL cobj = new CustomerDAL();
            int result = cobj.UpdCustomer(c);
            if (result == 1)
            {
                return RedirectToAction("Index");
            }
            else return RedirectToAction("Update");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}