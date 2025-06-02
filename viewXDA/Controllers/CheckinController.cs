using Microsoft.AspNetCore.Mvc;

namespace BookPitch_View.Controllers
{
    public class CheckinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
