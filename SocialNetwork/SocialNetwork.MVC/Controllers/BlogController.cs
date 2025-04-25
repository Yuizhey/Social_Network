using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers;

public class BlogController : Controller
{
    public BlogController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}