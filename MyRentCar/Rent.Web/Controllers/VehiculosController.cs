using Microsoft.AspNetCore.Mvc;
using Rent.Web.Data.Entities;
using Rent.Web.Helpers;
using Rent.Web.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Rent.Web.Controllers
{
    public class VehiculosController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IComboHelper _comboHelper;
        private readonly IconvertHelper _convertHelper;

        public VehiculosController(DataContext context,
            IComboHelper comboHelper,
            IconvertHelper convertHelper)
        {
            _comboHelper = comboHelper;
            _convertHelper = convertHelper;
            _dataContext = context;
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
                Marca = _comboHelper.GetComboMarcaVehiculo(),
                Tipo = _comboHelper.GetComboTipoVehiculo(),
                Modelo = _comboHelper.GetComboModeloVehiculo(),
                Estatus = _comboHelper.GetComboCaracteristicaVehiculo()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CrearVehiculo(VehiculoViewModel vehiculo)
        {

            try
                {
                if(ModelState.IsValid)
                {
                    var path = string.Empty;
                    
                    if(vehiculo.ImagenFile != null)
                    {
                        var guid = Guid.NewGuid().ToString();
                        var file = $"{guid}.jpg";
                        path = Path.Combine(
                            Directory.GetCurrentDirectory(),
                            "wwwroot\\images",
                            file);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await vehiculo.ImagenFile.CopyToAsync(stream);
                        }
                        path = $"~/images/{file}";

                    }

                    var v = await _convertHelper.ToVehiculo(vehiculo,path);
                    _dataContext.Vehiculos.Add(v);
                    await _dataContext.SaveChangesAsync();
                }


            }
            catch (Exception ex)
            {

            }

            return View();
        }
    }
}