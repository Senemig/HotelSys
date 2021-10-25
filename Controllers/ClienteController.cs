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
    public class ClienteController : Controller
    {
        public IActionResult ListarClientes()
        {
            ClienteRepo cr = new ClienteRepo();
            List<Cliente> lista = cr.Listar();

            return View(lista);
        }

        public IActionResult Cadastrar()
        {
            if(HttpContext.Session.GetInt32("idUsuario") != null)
                return View();
            else
                return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            ClienteRepo cr = new ClienteRepo();
            cr.Insert(cliente);

            return RedirectToAction("ListarClientes");
        }
    }
}