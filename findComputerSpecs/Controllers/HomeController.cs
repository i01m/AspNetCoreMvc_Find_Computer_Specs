using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace findComputerSpecs.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View();

        public IActionResult BriefSpecs() => View();

        public IActionResult DetailedSpecs() => View();

        public ViewResult MainPage() => View("Index");
               
    }
}
