using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers;

public class AuthController : Controller
{
    public AuthController()
    {
        
    }

    [HttpGet("register")]
    public IActionResult Register()
    {
        return View();
    }
    
    [HttpGet("login")]
    public IActionResult Login()
    {
        return View();
    }
}