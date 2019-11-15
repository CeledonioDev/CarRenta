using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Data
{
    public class TiposVehiculos
    {
        public int Id { get; set; }

        [Display(Name ="Tipo Vehiculo")]
        [Required(ErrorMessage ="Este campo {0} es obligatorio.")]
        public string Tipo { get; set; }

        public Vehiculo Vehiculo { get; set; }
    }
}
