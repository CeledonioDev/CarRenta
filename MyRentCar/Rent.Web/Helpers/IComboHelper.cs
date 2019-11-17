using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent.Web.Helpers
{
    public interface IComboHelper
    {
        IEnumerable<SelectListItem> GetComboModeloVehiculo();

        IEnumerable<SelectListItem> GetComboTipoVehiculo();
    }
}
