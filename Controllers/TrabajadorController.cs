using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTrabajadoresPrueba.Controllers
{
    public class TrabajadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
