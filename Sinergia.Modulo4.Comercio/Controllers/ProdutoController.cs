using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sinergia.Modulo4.Comercio.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Estoque()
        {
            return View();
        }

        public IActionResult Detalhes()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
    }
}