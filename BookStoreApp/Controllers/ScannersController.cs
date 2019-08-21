using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStoreApp.DAL;

namespace BookStoreApp.Controllers
{
    public class ScannersController : Controller
    {
        private readonly EfBridgeContext _context;

        public ScannersController(EfBridgeContext context)
        {
            _context = context;
        }

        // GET: Scanners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Scanners.ToListAsync());
        }

        // GET: Scanners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scanner = await _context.Scanners
                .FirstOrDefaultAsync(m => m.ID == id);
            if (scanner == null)
            {
                return NotFound();
            }

            return View(scanner);
        }

        // GET: Scanners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Scanners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Model,Brand")] Scanner scanner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scanner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scanner);
        }

        // GET: Scanners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scanner = await _context.Scanners.FindAsync(id);
            if (scanner == null)
            {
                return NotFound();
            }
            return View(scanner);
        }

        // POST: Scanners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Model,Brand")] Scanner scanner)
        {
            if (id != scanner.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scanner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScannerExists(scanner.ID))
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
            return View(scanner);
        }

        // GET: Scanners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scanner = await _context.Scanners
                .FirstOrDefaultAsync(m => m.ID == id);
            if (scanner == null)
            {
                return NotFound();
            }

            return View(scanner);
        }

        // POST: Scanners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scanner = await _context.Scanners.FindAsync(id);
            _context.Scanners.Remove(scanner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScannerExists(int id)
        {
            return _context.Scanners.Any(e => e.ID == id);
        }
    }
}
