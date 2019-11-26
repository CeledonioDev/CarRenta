using Rent.Web.Data;
using Rent.Web.Data.Entities;
using Rent.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Helpers
{
    public class ConvertHelper : IconvertHelper
    {
        private readonly DataContext _dataContext;

        public ConvertHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Vehiculo> ToVehiculo(VehiculoViewModel model, string path)
        {
            return new Vehiculo
            {
                ModeloVehiculos = await _dataContext.ModeloVehiculos.FindAsync(model.ModeloId),
                TiposVehiculos = await _dataContext.TiposVehiculos.FindAsync(model.TipoVehiculoId),
                MarcaVehiculos  = await _dataContext.MarcaVehiculos.FindAsync(model.MarcaId),
                //VehiculoCaracteristicas =
                VehiculoCaracteristicas = await _dataContext.VehiculoCaracteristicas.FindAsync(model.EstatusId),
                NombreVehiculo = model.NombreVehiculo,
                Color = model.Color,
                Kilometraje = model.Kilometraje,
                NoPlaca = model.NoPlaca,
                No_Chasis = model.No_Chasis,
                Anio_Vehiculo = model.Anio_Vehiculo,
                ImagenUrl =path,
                Precio = model.Precio
               
            };

        }
    }
}
