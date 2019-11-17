using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rent.Web.Data.Entities;

namespace Rent.Web.Helpers
{
    public class ComboHelper : IComboHelper
    {
        private readonly DataContext _dataContext;

        public ComboHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboModeloVehiculo()
        {
            var list = _dataContext.ModeloVehiculos.Select(m => new SelectListItem
            {
                Text = m.Marca,
                Value = $"{m.Id}"
            }).OrderBy(m=> m.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Ningún Modelo...]",
                Value= "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboTipoVehiculo()
        {
            var list = _dataContext.TiposVehiculos.Select(t => new SelectListItem
            {
                Text = t.Tipo,
                Value = $"{t.Id}"
            }).OrderBy(m => m.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Ningún Tipo...]",
                Value = "0"
            });
            return list; 
        }
    }
}
