using Microsoft.AspNetCore.Mvc;

namespace SpoTalent.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
