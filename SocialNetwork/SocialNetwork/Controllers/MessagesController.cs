using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers;

public class MessagesController : Controller
{
    public MessagesController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}