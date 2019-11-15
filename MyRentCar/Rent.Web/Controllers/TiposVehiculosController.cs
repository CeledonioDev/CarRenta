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
    public class TiposVehiculosController : Controller
    {
        private readonly DataContext _context;

        public TiposVehiculosController(DataContext context)
        {
            _context = context;
        }

        // GET: TiposVehiculos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposVehiculos.ToListAsync());
        }

        // GET: TiposVehiculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposVehiculos = await _context.TiposVehiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposVehiculos == null)
            {
                return NotFound();
            }

            return View(tiposVehiculos);
        }

        // GET: TiposVehiculos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposVehiculos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo")] TiposVehiculos tiposVehiculos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tiposVehiculos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tiposVehiculos);
        }

        // GET: TiposVehiculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposVehiculos = await _context.TiposVehiculos.FindAsync(id);
            if (tiposVehiculos == null)
            {
                return NotFound();
            }
            return View(tiposVehiculos);
        }

        // POST: TiposVehiculos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo")] TiposVehiculos tiposVehiculos)
        {
            if (id != tiposVehiculos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tiposVehiculos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiposVehiculosExists(tiposVehiculos.Id))
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
            return View(tiposVehiculos);
        }

        // GET: TiposVehiculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposVehiculos = await _context.TiposVehiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposVehiculos == null)
            {
                return NotFound();
            }

            return View(tiposVehiculos);
        }

        // POST: TiposVehiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tiposVehiculos = await _context.TiposVehiculos.FindAsync(id);
            _context.TiposVehiculos.Remove(tiposVehiculos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TiposVehiculosExists(int id)
        {
            return _context.TiposVehiculos.Any(e => e.Id == id);
        }
    }
}
