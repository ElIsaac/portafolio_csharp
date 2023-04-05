using primero.Models;
namespace primero.Services
{
    public interface IRepositorioProyectos{
            List<ProyectoViewModel> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos{

        public List<ProyectoViewModel> ObtenerProyectos(){
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
    }
}