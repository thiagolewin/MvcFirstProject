using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tp4.Models;

namespace Tp4.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.EquiposCreados  = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaMedias= Equipos.ListaMedias;
        ViewBag.ListaPantalones= Equipos.ListaPantalones;
        ViewBag.ListaRemeras= Equipos.ListaRemeras;
        return View();
    }

    public IActionResult GuardarIndumentaria (string Equipo, int Media, int Pantalon, int Remera)
    {
        Indumentaria indu = new Indumentaria(Equipos.ListaMedias[Media],Equipos.ListaPantalones[Pantalon],Equipos.ListaRemeras[Remera]);
        Equipos.IngresarIndumentaria(Equipo,indu);  
        return RedirectToAction("Index");
    }
    public IActionResult meterImagen(string imagen) {
        
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


