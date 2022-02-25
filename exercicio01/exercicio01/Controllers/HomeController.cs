using exercicio01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace exercicio01.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

    }
}