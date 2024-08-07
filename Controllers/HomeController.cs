using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using algo.Models;

namespace algo.Controllers;


public class HomeController : Controller
{
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ListaTitulos = Elecciones.ListaTitulos;
        ViewBag.ListaFotos = Elecciones.ListaFotos;
        ViewBag.ListaBio = Elecciones.ListaBio;
        return View("Index");
    }

    public IActionResult Restaurantes()
    {
        ViewBag.ListaFotos = Elecciones.ListaFotos;
        ViewBag.ListaBio = Elecciones.ListaBio;
        return View();
    }

    public IActionResult Hoteles()
    {
        ViewBag.ListaFotos = Elecciones.ListaFotos;
        ViewBag.ListaBio = Elecciones.ListaBio;
        return View();
    }
    public IActionResult Entretenimiento()
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
