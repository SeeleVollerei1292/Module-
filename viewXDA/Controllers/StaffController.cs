using Microsoft.AspNetCore.Mvc;

namespace BookPitch_View.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
