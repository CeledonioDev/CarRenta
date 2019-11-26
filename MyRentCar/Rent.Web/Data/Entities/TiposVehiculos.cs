using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rent.Web.Data
{
    public class TiposVehiculos
    {
        public int Id { get; set; }

        [Display(Name = "Tipo Vehiculo")]
        [Required(ErrorMessage = "Este campo {0} es obligatorio.")]
        public string Tipo { get; set; }

        public ICollection<Vehiculo > vehiculos { get; set; }
    }
}
