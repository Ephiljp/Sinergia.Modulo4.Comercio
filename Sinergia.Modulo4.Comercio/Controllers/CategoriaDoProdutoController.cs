using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sinergia.Modulo4.Comercio.Controllers
{
    public class CategoriaDoProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}