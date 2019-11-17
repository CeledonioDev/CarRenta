using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Models
{
    public class PublicacionViewModel
    {
        public int IdPublicacion { get; set; }

        [NotMapped]
        public List<string> Imagen { get; set; }
    }
}
