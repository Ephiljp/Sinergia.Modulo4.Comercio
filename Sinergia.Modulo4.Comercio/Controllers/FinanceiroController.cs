using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sinergia.Modulo4.Comercio.Controllers
{
    public class FinanceiroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContasAPagar()
        {
            return View("index");
        }

        public IActionResult ContasAReceber()
        {
            return View("index");
        }
    }
}