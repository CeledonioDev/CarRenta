using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Data
{
    public class Vehiculo
    {
        public int Id { get; set; }

        public string NombreVehiculo { get; set; }

        public string Anio_Vehiculo { get; set; }

        public string Color { get; set; }

        public string No_Chasis { get; set; }

        public string Kilometraje { get; set; }

        public string NoPlaca { get; set; }

        public ICollection<TiposVehiculos> TiposVehiculos { get; set; }

        public ICollection<ModeloVehiculo> ModeloVehiculos { get; set; }
        
    }
}
