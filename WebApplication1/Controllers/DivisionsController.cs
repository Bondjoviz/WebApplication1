using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DivisionsController : Controller
    {
        
        public IActionResult Index()
        {
            TestContext context = new TestContext();
            var divisions = context.Divisions.ToList();
            

            return Json(divisions);
            
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Divisions divisions)
        {
            TestContext context = new TestContext();
            context.Divisions.Add(divisions);
            context.SaveChanges();

            return Json(divisions);
        }
    }
}