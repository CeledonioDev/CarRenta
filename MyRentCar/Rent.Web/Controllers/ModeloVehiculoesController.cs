using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rent.Web.Data;
using Rent.Web.Data.Entities;

namespace Rent.Web.Controllers
{
    public class ModeloVehiculoesController : Controller
    {
        private readonly DataContext _context;

        public ModeloVehiculoesController(DataContext context)
        {
            _context = context;
        }

        // GET: ModeloVehiculoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ModeloVehiculos.ToListAsync());
        }

        // GET: ModeloVehiculoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modeloVehiculo = await _context.ModeloVehiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modeloVehiculo == null)
            {
                return NotFound();
            }

            return View(modeloVehiculo);
        }

        // GET: ModeloVehiculoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ModeloVehiculoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca")] ModeloVehiculo modeloVehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modeloVehiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modeloVehiculo);
        }

        // GET: ModeloVehiculoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modeloVehiculo = await _context.ModeloVehiculos.FindAsync(id);
            if (modeloVehiculo == null)
            {
                return NotFound();
            }
            return View(modeloVehiculo);
        }

        // POST: ModeloVehiculoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca")] ModeloVehiculo modeloVehiculo)
        {
            if (id != modeloVehiculo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modeloVehiculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModeloVehiculoExists(modeloVehiculo.Id))
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
            return View(modeloVehiculo);
        }

        // GET: ModeloVehiculoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modeloVehiculo = await _context.ModeloVehiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modeloVehiculo == null)
            {
                return NotFound();
            }

            return View(modeloVehiculo);
        }

        // POST: ModeloVehiculoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modeloVehiculo = await _context.ModeloVehiculos.FindAsync(id);
            _context.ModeloVehiculos.Remove(modeloVehiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModeloVehiculoExists(int id)
        {
            return _context.ModeloVehiculos.Any(e => e.Id == id);
        }
    }
}
