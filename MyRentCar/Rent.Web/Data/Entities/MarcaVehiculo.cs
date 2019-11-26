using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Data.Entities
{
    public class MarcaVehiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo {0} es obligatorio.")]
        [Display(Name = "Marca Vehiculo")]
        public string Nombre { get; set; }

        public ICollection<Vehiculo> vehiculos { get; set; }

    }
}
