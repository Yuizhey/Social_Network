using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers;

public class EventsController : Controller
{
    public EventsController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}