using Microsoft.AspNetCore.Mvc;
using SpoTalent.Models;
using System.Diagnostics;

namespace SpoTalent.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}