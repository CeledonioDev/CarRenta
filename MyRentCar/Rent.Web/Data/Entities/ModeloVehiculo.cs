using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Data
{
    public class ModeloVehiculo
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public Vehiculo Vehiculo { get; set; }

    }
}
