using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelSys.Models;
using Microsoft.AspNetCore.Http;

namespace HotelSys.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            UsuarioRepo ur = new UsuarioRepo();
            Usuario user = ur.ValidarLogin(usuario);
            if(user != null)
            {
                HttpContext.Session.SetInt32("idUsuario", user.idUsuario);
                HttpContext.Session.SetString("nomeUsuario", user.Nome);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Mensagem = "Login ou senha incorretos!";

                return RedirectToAction("Login");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
    }
}
