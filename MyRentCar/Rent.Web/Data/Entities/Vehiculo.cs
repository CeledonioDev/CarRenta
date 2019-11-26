using Rent.Web.Data.Entities;
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

        public string ImagenUrl { get; set; }

        public double Precio { get; set; }

        public string Descripcion { get; set; }

        public TiposVehiculos TiposVehiculos { get; set; }

        public ModeloVehiculo ModeloVehiculos { get; set; }

        public VehiculoCaracteristica VehiculoCaracteristicas { get; set; }

        public VehiculoPublicacion VehiculoPublicacions { get; set; }

        public MarcaVehiculo MarcaVehiculos { get; set; }

        //public ICollection<TiposVehiculos> TiposVehiculos { get; set; }

        //public ICollection<ModeloVehiculo> ModeloVehiculos { get; set; }

        //public ICollection<VehiculoCaracteristica> vehiculoCaracteristicas { get; set; }

        //public ICollection<VehiculoPublicacion> vehiculoPublicacions { get; set; }

        //public ICollection<MarcaVehiculo> marcaVehiculos { get; set; }

    }
}
