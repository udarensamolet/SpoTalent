using Microsoft.AspNetCore.Mvc;

namespace SpoTalent.Controllers
{
    public class RecruitmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
