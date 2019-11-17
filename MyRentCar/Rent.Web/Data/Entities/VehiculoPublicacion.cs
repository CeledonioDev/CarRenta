using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Data.Entities
{
    public class VehiculoPublicacion
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Este Campo {0} es obligatorio.")]
        public string Imagen { get; set; }

        public Vehiculo Vehiculo { get; set; }
    }
}
