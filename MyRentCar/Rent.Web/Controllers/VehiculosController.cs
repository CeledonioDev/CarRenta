using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rent.Web.Data.Entities;
using Rent.Web.Helpers;
using Rent.Web.Models;

namespace Rent.Web.Controllers
{
    public class VehiculosController : Controller
    {
        private readonly IComboHelper _comboHelper;


        public VehiculosController(DataContext dataVector, IComboHelper comboHelper)
        {
            _comboHelper = comboHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CrearVehiculo()
        {
            var model = new VehiculoViewModel
            {
                Marca = _comboHelper.GetComboModeloVehiculo(),
                Tipo = _comboHelper.GetComboTipoVehiculo()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CrearVehiculo(VehiculoViewModel vehiculo)
        {
            try
            {
                if (ModelState.IsValid)
                {

                }
            }
            catch(Exception ex)
            {

            }
           
            return  View();
        }
    }
}