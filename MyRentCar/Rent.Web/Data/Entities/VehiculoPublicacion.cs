using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Data.Entities
{
    public class VehiculoPublicacion
    {
        public int IdPublicacion { get; set; }

        public List<string> Imagen { get; set; }

        public Vehiculo Vehiculo { get; set; }
    }
}
