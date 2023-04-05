using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using primero.Models;
using primero.Services;

namespace primero.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepositorioProyectos repositorioProyectos;

    public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
    {
        _logger = logger;
        this.repositorioProyectos=repositorioProyectos;
    }

    public IActionResult Index()
    {
        
        var proyectos=repositorioProyectos.ObtenerProyectos().Take(3).ToList();
        var model= new HomeIndexViewModel(){
            Proyectos=proyectos
        };
        return View(model);
    }

    public IActionResult Proyectos()
    {
        
        var proyectos=repositorioProyectos.ObtenerProyectos().ToList();
        
        return View(proyectos);
    }

    public IActionResult Contact()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Contact(ContactoViewModel contactoViewModel)
    {
        return RedirectToAction("Index");
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
