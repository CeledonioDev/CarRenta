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
    public class MarcaVehiculoesController : Controller
    {
        private readonly DataContext _context;

        public MarcaVehiculoesController(DataContext context)
        {
            _context = context;
        }

        // GET: MarcaVehiculoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MarcaVehiculos.ToListAsync());
        }

        // GET: MarcaVehiculoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcaVehiculo = await _context.MarcaVehiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marcaVehiculo == null)
            {
                return NotFound();
            }

            return View(marcaVehiculo);
        }

        // GET: MarcaVehiculoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MarcaVehiculoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] MarcaVehiculo marcaVehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marcaVehiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(marcaVehiculo);
        }

        // GET: MarcaVehiculoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcaVehiculo = await _context.MarcaVehiculos.FindAsync(id);
            if (marcaVehiculo == null)
            {
                return NotFound();
            }
            return View(marcaVehiculo);
        }

        // POST: MarcaVehiculoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] MarcaVehiculo marcaVehiculo)
        {
            if (id != marcaVehiculo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marcaVehiculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarcaVehiculoExists(marcaVehiculo.Id))
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
            return View(marcaVehiculo);
        }

        // GET: MarcaVehiculoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcaVehiculo = await _context.MarcaVehiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marcaVehiculo == null)
            {
                return NotFound();
            }

            return View(marcaVehiculo);
        }

        // POST: MarcaVehiculoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var marcaVehiculo = await _context.MarcaVehiculos.FindAsync(id);
            _context.MarcaVehiculos.Remove(marcaVehiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarcaVehiculoExists(int id)
        {
            return _context.MarcaVehiculos.Any(e => e.Id == id);
        }
    }
}
