using Microsoft.AspNetCore.Mvc.Rendering;
using Rent.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Models
{
    public class VehiculoViewModel : Vehiculo
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Modelo Vehículo")]
        public int MarcaId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Tipo Vehículo")]
        public int TipoVehiculoId { get; set; }

        public IEnumerable<SelectListItem> Marca { get; set; }

        public IEnumerable<SelectListItem> Tipo { get; set; }
    }
}
