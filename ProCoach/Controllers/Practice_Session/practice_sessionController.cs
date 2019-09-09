using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProCoach.Data;

namespace ProCoach.Controllers.NewFolder
{
    public class practice_sessionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public practice_sessionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: practice_session
        public async Task<IActionResult> Index()
        {
            return View(await _context.practice_session.ToListAsync());
        }

        // GET: practice_session/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var practice_session = await _context.practice_session
                .FirstOrDefaultAsync(m => m.id == id);
            if (practice_session == null)
            {
                return NotFound();
            }

            return View(practice_session);
        }

        // GET: practice_session/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: practice_session/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,team_id,coach_id,address")] practice_session practice_session)
        {
            if (ModelState.IsValid)
            {
                _context.Add(practice_session);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(practice_session);
        }

        // GET: practice_session/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var practice_session = await _context.practice_session.FindAsync(id);
            if (practice_session == null)
            {
                return NotFound();
            }
            return View(practice_session);
        }

        // POST: practice_session/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,team_id,coach_id,address")] practice_session practice_session)
        {
            if (id != practice_session.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(practice_session);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!practice_sessionExists(practice_session.id))
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
            return View(practice_session);
        }

        // GET: practice_session/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var practice_session = await _context.practice_session
                .FirstOrDefaultAsync(m => m.id == id);
            if (practice_session == null)
            {
                return NotFound();
            }

            return View(practice_session);
        }

        // POST: practice_session/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var practice_session = await _context.practice_session.FindAsync(id);
            _context.practice_session.Remove(practice_session);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool practice_sessionExists(int id)
        {
            return _context.practice_session.Any(e => e.id == id);
        }
    }
}
