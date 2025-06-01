using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using viewXDA.Models;

namespace viewXDA.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Field()
    {
        var fields = new List<FieldModel>();

        for (int i = 0; i < 27; i++)
        {
            fields.Add(new FieldModel
            {
                Name = "Sân bóng đá " + (i + 1),
                District = "Quận Thanh Xuân",
                ImageUrl = "https://i.pinimg.com/736x/ae/7b/37/ae7b37b408808e168453326463783aa8.jpg" 
            });
        }

        return View(fields);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
