using Microsoft.AspNetCore.Mvc;

namespace BookPitch_View.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
