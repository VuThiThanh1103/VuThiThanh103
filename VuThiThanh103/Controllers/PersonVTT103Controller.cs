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
    public class PersonVTT103Controller : Controller
    {
        private readonly VuThiThanh103Context _context;

        public PersonVTT103Controller(VuThiThanh103Context context)
        {
            _context = context;
        }

        // GET: PersonVTT103
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonVTT103.ToListAsync());
        }

        // GET: PersonVTT103/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personVTT103 = await _context.PersonVTT103
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personVTT103 == null)
            {
                return NotFound();
            }

            return View(personVTT103);
        }

        // GET: PersonVTT103/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonVTT103/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonVTT103 personVTT103)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personVTT103);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personVTT103);
        }

        // GET: PersonVTT103/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personVTT103 = await _context.PersonVTT103.FindAsync(id);
            if (personVTT103 == null)
            {
                return NotFound();
            }
            return View(personVTT103);
        }

        // POST: PersonVTT103/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonVTT103 personVTT103)
        {
            if (id != personVTT103.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personVTT103);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonVTT103Exists(personVTT103.PersonId))
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
            return View(personVTT103);
        }

        // GET: PersonVTT103/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personVTT103 = await _context.PersonVTT103
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personVTT103 == null)
            {
                return NotFound();
            }

            return View(personVTT103);
        }

        // POST: PersonVTT103/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personVTT103 = await _context.PersonVTT103.FindAsync(id);
            _context.PersonVTT103.Remove(personVTT103);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonVTT103Exists(string id)
        {
            return _context.PersonVTT103.Any(e => e.PersonId == id);
        }
    }
}
