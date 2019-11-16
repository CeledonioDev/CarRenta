using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rent.Web.Controllers
{
    public class VehiculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearVehiculo()
        {
            return View();
        }
    }
}