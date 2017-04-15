using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sinergia.Modulo4.Comercio.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VendasTotais()
        {
            return View("index");
        }

        public IActionResult VendasPorCliente()
        {
            return View("index");
        }

        public IActionResult VendasPorVendedor()
        {
            return View("index");
        }

        public IActionResult ItensMaisVendidos()
        {
            return View("index");
        }

    }
}