using Microsoft.AspNetCore.Mvc.Rendering;
using Rent.Web.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Rent.Web.Helpers
{
    public class ComboHelper : IComboHelper
    {
        private readonly DataContext _dataContext;

        public ComboHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboCaracteristicaVehiculo()
        {
            var list = _dataContext.VehiculoCaracteristicas.Select(c => new SelectListItem
            {
                Text = c.Estatus,
                Value = $"{c.Id}"
            }).OrderBy(c => c.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Ninguna Estatus]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboMarcaVehiculo()
        {
            var list = _dataContext.MarcaVehiculos.Select(ma => new SelectListItem
            {
                Text = ma.Nombre,
                Value = $"{ma.Id}"
            }).OrderBy(ma => ma.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Ninguna Marca]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboModeloVehiculo()
        {
            var list = _dataContext.ModeloVehiculos.Select(m => new SelectListItem
            {
                Text = m.Marca,
                Value = $"{m.Id}"
            }).OrderBy(m => m.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Ningún Modelo...]",
                Value = "0"
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
