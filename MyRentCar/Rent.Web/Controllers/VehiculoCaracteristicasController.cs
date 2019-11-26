using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rent.Web.Data.Entities;

namespace Rent.Web.Controllers
{
    public class VehiculoCaracteristicasController : Controller
    {
        private readonly DataContext _context;

        public VehiculoCaracteristicasController(DataContext context)
        {
            _context = context;
        }

        // GET: VehiculoCaracteristicas
        public async Task<IActionResult> Index()
        {
            return View(await _context.VehiculoCaracteristicas.ToListAsync());
        }

        // GET: VehiculoCaracteristicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculoCaracteristica = await _context.VehiculoCaracteristicas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehiculoCaracteristica == null)
            {
                return NotFound();
            }

            return View(vehiculoCaracteristica);
        }

        // GET: VehiculoCaracteristicas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehiculoCaracteristicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Estatus")] VehiculoCaracteristica vehiculoCaracteristica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehiculoCaracteristica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculoCaracteristica);
        }

        // GET: VehiculoCaracteristicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculoCaracteristica = await _context.VehiculoCaracteristicas.FindAsync(id);
            if (vehiculoCaracteristica == null)
            {
                return NotFound();
            }
            return View(vehiculoCaracteristica);
        }

        // POST: VehiculoCaracteristicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Estatus")] VehiculoCaracteristica vehiculoCaracteristica)
        {
            if (id != vehiculoCaracteristica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehiculoCaracteristica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehiculoCaracteristicaExists(vehiculoCaracteristica.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculoCaracteristica);
        }

        // GET: VehiculoCaracteristicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculoCaracteristica = await _context.VehiculoCaracteristicas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehiculoCaracteristica == null)
            {
                return NotFound();
            }

            return View(vehiculoCaracteristica);
        }

        // POST: VehiculoCaracteristicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehiculoCaracteristica = await _context.VehiculoCaracteristicas.FindAsync(id);
            _context.VehiculoCaracteristicas.Remove(vehiculoCaracteristica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehiculoCaracteristicaExists(int id)
        {
            return _context.VehiculoCaracteristicas.Any(e => e.Id == id);
        }
    }
}
