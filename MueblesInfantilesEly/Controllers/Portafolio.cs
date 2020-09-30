using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MueblesInfantilesEly.Controllers
{
    public class Portafolio : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult Comodas_y_Mudadores()
        {
            return View();
        }
        public IActionResult Cunas_y_Camas()
        {
            return View();
        }
        public IActionResult Organizadores()
        {
            return View();
        }
        public IActionResult Roperos_Completos_y_Dos_puertas()
        {
            return View();
        }
    }
}
