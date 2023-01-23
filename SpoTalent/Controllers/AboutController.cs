using Microsoft.AspNetCore.Mvc;

namespace SpoTalent.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
