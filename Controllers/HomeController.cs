using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Conceito03.Models;

namespace Conceito03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Cadastro()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Arquivo()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
