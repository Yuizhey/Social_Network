using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers;

public class VideosController : Controller
{
    public VideosController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}