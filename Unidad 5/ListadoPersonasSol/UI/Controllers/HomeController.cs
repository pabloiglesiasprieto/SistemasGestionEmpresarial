using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUseCases _useCases;

    public HomeController(ILogger<HomeController> logger, IUseCases useCases)
    {
        _logger = logger;
        _useCases = useCases;
    }

    public IActionResult Index()
    {
        var personas = _useCases.GetAllPersonas();
        return View(personas);
    }


    public IActionResult Details(int id)
    {
        return View();
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
