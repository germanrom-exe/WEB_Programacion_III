using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using TPMvcMaterias.Models;
using TPMvcMaterias.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TPMvcMaterias.Login;

namespace TPMvcMaterias.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext context;

        public LoginController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("~/Views/LoginView/Index.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var usuarioDb = context.Usuarios.FirstOrDefault(u =>
                u.Correo == model.Correo &&
                u.Password == model.Password);

            if (usuarioDb != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(
                        ClaimTypes.Name,
                        usuarioDb.Nombre + " " + usuarioDb.Apellido
                    )
                };

                var identity = new ClaimsIdentity(
                    claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                );

                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction(
                    "Index",
                    "Materias"
                );
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";

            return View("~/Views/LoginView/Index.cshtml");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("~/Views/LoginView/Register.cshtml");
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/LoginView/Register.cshtml", model);
            }

            bool existeCorreo = context.Usuarios
                .Any(u => u.Correo == model.Correo);

            if (existeCorreo)
            {
                ViewBag.Error = "Ese correo ya está registrado";

                return View("~/Views/LoginView/Register.cshtml", model);
            }

            Usuario usuario = new Usuario
            {
                Nombre = model.Nombre,
                Apellido = model.Apellido,
                Correo = model.Correo,
                Legajo = model.Legajo,
                Password = model.Password
            };

            context.Usuarios.Add(usuario);

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}