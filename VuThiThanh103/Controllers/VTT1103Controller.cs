using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VuThiThanh103.Data;
using VuThiThanh103.Models;

namespace VuThiThanh103.Controllers
{
    public class VTT1103Controller : Controller
    {
        private readonly VuThiThanh103Context _context;

        public VTT1103Controller(VuThiThanh103Context context)
        {
            _context = context;
        }

        // GET: VTT1103
        public async Task<IActionResult> Index()
        {
            return View(await _context.VTT1103.ToListAsync());
        }

        // GET: VTT1103/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vTT1103 = await _context.VTT1103
                .FirstOrDefaultAsync(m => m.VTTId == id);
            if (vTT1103 == null)
            {
                return NotFound();
            }

            return View(vTT1103);
        }

        // GET: VTT1103/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VTT1103/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VTTId,VTTName,VTTGender")] VTT1103 vTT1103)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vTT1103);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vTT1103);
        }

        // GET: VTT1103/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vTT1103 = await _context.VTT1103.FindAsync(id);
            if (vTT1103 == null)
            {
                return NotFound();
            }
            return View(vTT1103);
        }

        // POST: VTT1103/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VTTId,VTTName,VTTGender")] VTT1103 vTT1103)
        {
            if (id != vTT1103.VTTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vTT1103);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VTT1103Exists(vTT1103.VTTId))
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
            return View(vTT1103);
        }

        // GET: VTT1103/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vTT1103 = await _context.VTT1103
                .FirstOrDefaultAsync(m => m.VTTId == id);
            if (vTT1103 == null)
            {
                return NotFound();
            }

            return View(vTT1103);
        }

        // POST: VTT1103/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vTT1103 = await _context.VTT1103.FindAsync(id);
            _context.VTT1103.Remove(vTT1103);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VTT1103Exists(string id)
        {
            return _context.VTT1103.Any(e => e.VTTId == id);
        }
    }
}
