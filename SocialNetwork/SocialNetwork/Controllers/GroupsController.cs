using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers;

public class GroupsController : Controller
{
    public GroupsController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}