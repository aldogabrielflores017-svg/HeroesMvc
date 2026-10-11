using Microsoft.AspNetCore.Mvc;

namespace HeroesMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
