using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversidadMVC.Data;

namespace UniversidadMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly UniversidadDbContext _context;
        private UserManager<Usuario> _userManager;  

        public LoginController(UniversidadDbContext context, UserManager<Usuario> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registro(string nommbre, string apellido, string username)
        {
            Usuario usuario = new Usuario();
            usuario.UserName = username;
           _userManager.CreateAsync(usuario);
           

            return View();
        }


    }
}
