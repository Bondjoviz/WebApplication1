using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public string  Index(int id = 0)
        {
            return "Hello World." + id ;
        }

        public string Hello(string name ="")
        {
            return "Hello "+name;
        }
        public IActionResult Person()
        {
            return View();
        }
        public IActionResult Page1()
        {
            return View();
        }
    }

}