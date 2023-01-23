using Microsoft.AspNetCore.Mvc;

namespace SpoTalent.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
