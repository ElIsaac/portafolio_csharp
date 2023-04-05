using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using primero.Models;

namespace primero.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var persona = new Persona(){
            Nombre = "Isaac Ramirez"
        };
        var proyectos=ObtenerProyectos().Take(3).ToList();
        var model= new HomeIndexViewModel(){
            Proyectos=proyectos
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        
        return View();
    }
    private List<ProyectoViewModel> ObtenerProyectos(){
        return new List<ProyectoViewModel>()
        { 
            new ProyectoViewModel
            {
                Titulo="Registradora BACK",
                Descripcion="caja registradora hecha en Node.js con express y coneccion a mongodb, con autenticacion de usuarios",
                Link="https://www.github.com",
                ImagenURL="/images/steam.png"
            },
            new ProyectoViewModel
            {
                Titulo="Registradora FRONT",
                Descripcion="caja registradora hecha en react con proteccion de rutas usando JSONweb Tokens",
                Link="https://www.github.com",
                ImagenURL="/images/nyt.png"
            },
            new ProyectoViewModel
            {
                Titulo="amazon",
                Descripcion="amazon",
                Link="https://www.amazon.com",
                ImagenURL="/images/amazon.png"
            },
            new ProyectoViewModel
            {
                Titulo="reddit",
                Descripcion="reddit ",
                Link="https://www.facebook.com",
                ImagenURL="/images/reddit.png"
            },
        };
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
