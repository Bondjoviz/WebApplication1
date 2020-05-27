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
        [HttpGet]
        public IActionResult Index()
        {
           

            return View();
            
        }
        [HttpPost]
        public IActionResult Index(string divisionId,string divisionName)
        {
            TestContext context = new TestContext();
            var division = context.Divisions
                                    .Where(d => d.DivisionId.ToString().Contains(divisionId)
                                    && d.DivisionName.Contains(divisionName))
                                    .ToList();

            return View(division);

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