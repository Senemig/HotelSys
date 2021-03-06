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
    public class SistemaController : Controller
    {
        public IActionResult Historico()
        {
            if(HttpContext.Session.GetInt32("idUsuario") != null)
            {
                HistoricoRepo hr = new HistoricoRepo();
                List<Historico> lista = hr.Listar();

                return View(lista);
            }
            else
                return RedirectToAction("Login", "Home");
            
        }

        public IActionResult Quartos()
        {
            if (HttpContext.Session.GetInt32("idUsuario") != null)
            {
                QuartoRepo qr = new QuartoRepo();
                List<Quarto> lista = new List<Quarto>();
                lista = qr.Listar();

                return View(lista);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        public IActionResult VerQuarto(int id)
        {
            if (HttpContext.Session.GetInt32("idUsuario") != null)
            {
                QuartoRepo qr = new QuartoRepo();
                Quarto quarto = qr.BuscarPorId(id);
                return View(quarto);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult CheckIn(int id)
        {
            if (HttpContext.Session.GetInt32("idUsuario") != null)
            {
                QuartoRepo qr = new QuartoRepo();
                Quarto quarto = qr.BuscarPorId(id);

                return View(quarto);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        [HttpPost]
        public IActionResult CheckIn(Quarto quarto)
        {
            if (HttpContext.Session.GetInt32("idUsuario") != null)
            {
                QuartoRepo qr = new QuartoRepo();
                HistoricoRepo hr = new HistoricoRepo();

                quarto.CheckIn = DateTime.Today;

                qr.Editar(quarto);

                Historico historico = new Historico();
                historico.Quarto = quarto.Numero;
                historico.idCliente = quarto.cliente.idCliente;
                historico.Tipo = "CHECKIN";
                historico.Registro = DateTime.Now;
                hr.Insert(historico);

                return RedirectToAction("Quartos");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult CheckOut(int id)
        {
            if (HttpContext.Session.GetInt32("idUsuario") != null)
            {
                QuartoRepo qr = new QuartoRepo();
                HistoricoRepo hr = new HistoricoRepo();

                Quarto quarto = qr.BuscarPorId(id);

                Historico historico = new Historico();
                historico.Quarto = quarto.Numero;
                historico.idCliente = quarto.cliente.idCliente;
                historico.Tipo = "CHECKOUT";
                historico.Registro = DateTime.Now;
                hr.Insert(historico);

                quarto.CheckIn = null;
                quarto.CheckOut = null;
                quarto.cliente = new Cliente();
                quarto.cliente.idCliente = 0;
                quarto.Status = "VAZIO";

                qr.Editar(quarto);

                return RedirectToAction("Quartos");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }
    }
}