using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FireFlyFireworks.Data;
using FireFlyFireworks.Models;

namespace FireFlyFireworks.Views
{
    public class ChemsController : Controller
    {
        private readonly FireFlyFireworksContext _context;

        public ChemsController(FireFlyFireworksContext context)
        {
            _context = context;
        }

        // GET: Chems
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chem.ToListAsync());
        }

        // GET: Chems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chem = await _context.Chem
                .FirstOrDefaultAsync(m => m.ChemID == id);
            if (chem == null)
            {
                return NotFound();
            }

            return View(chem);
        }

        // GET: Chems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChemID,ChemComp,ChemAbbrev,ColorID,WarehouseLocationID")] Chem chem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chem);
        }

        // GET: Chems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chem = await _context.Chem.FindAsync(id);
            if (chem == null)
            {
                return NotFound();
            }
            return View(chem);
        }

        // POST: Chems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChemID,ChemComp,ChemAbbrev,ColorID,WarehouseLocationID")] Chem chem)
        {
            if (id != chem.ChemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChemExists(chem.ChemID))
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
            return View(chem);
        }

        // GET: Chems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chem = await _context.Chem
                .FirstOrDefaultAsync(m => m.ChemID == id);
            if (chem == null)
            {
                return NotFound();
            }

            return View(chem);
        }

        // POST: Chems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chem = await _context.Chem.FindAsync(id);
            _context.Chem.Remove(chem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChemExists(int id)
        {
            return _context.Chem.Any(e => e.ChemID == id);
        }
    }
}
