using Rent.Web.Data;
using Rent.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Helpers
{
   public  interface IconvertHelper
    {
        Task<Vehiculo> ToVehiculo(VehiculoViewModel model, string path);
    }
}
