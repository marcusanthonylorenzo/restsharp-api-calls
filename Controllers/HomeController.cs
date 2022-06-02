using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using New_folder__5_.Models;
using MvcApiCall.Models;

namespace New_folder__5_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
            var allArticles = Article.GetArticles("kabcdudzYOvL7vzh8Lol8GUzHnM8yOGO");
            return View(allArticles);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
