using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers;

public class MarketController : Controller
{
    public MarketController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}