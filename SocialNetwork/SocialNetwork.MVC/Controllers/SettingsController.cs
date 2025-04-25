using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers;


public class SettingsController : Controller
{
    public SettingsController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}