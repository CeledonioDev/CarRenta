using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Data.Entities
{
    public class VehiculoCaracteristica
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        [Display( Name = "Condición Vehículo")]
        public string Estatus { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
