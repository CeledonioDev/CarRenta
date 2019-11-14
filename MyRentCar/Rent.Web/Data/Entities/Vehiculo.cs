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

        public string Ano { get; set; }

        public string Color { get; set; }

        public string NoChasis { get; set; }

        public string Kilometraje { get; set; }

        public string NoPlaca { get; set; }
    }
}
