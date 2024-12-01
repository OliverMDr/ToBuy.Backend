using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToBuy.Backend.Models;

namespace ToBuy.Backend.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    // Test data list for the ToBuyItems endpoint
    private List<string> _toBuyItems = new List<string>
    {
        "Milk",
        "Bread",
        "Butter",
        "Cheese",
        "Eggs"
    };
    
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route ("tobuyitems")]
    public IActionResult ToBuyItems()
    {
        _logger.LogInformation("Returning ToBuy items");
        return Ok(_toBuyItems);
    }
    
}
