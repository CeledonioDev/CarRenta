using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rent.Web.Data.Entities
{
    public class VehiculoPublicacion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este Campo {0} es obligatorio.")]
        public string Imagen { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }


    }
}
