using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProCoach.Data;

namespace ProCoach.Controllers.PracticeSession
{
    public class PracticeSessionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PracticeSessionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PracticeSessions
        public async Task<IActionResult> Index()
        {
            return View(await _context.PracticeSession.ToListAsync());
        }

        // GET: PracticeSessions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var practiceSession = await _context.PracticeSession
                .FirstOrDefaultAsync(m => m.Id == id);
            if (practiceSession == null)
            {
                return NotFound();
            }

            return View(practiceSession);
        }

        // GET: PracticeSessions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PracticeSessions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Team_id,Coach_id,Address")] Data.PracticeSession practiceSession)
        {
            if (ModelState.IsValid)
            {
                _context.Add(practiceSession);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(practiceSession);
        }

        // GET: PracticeSessions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var practiceSession = await _context.PracticeSession.FindAsync(id);
            if (practiceSession == null)
            {
                return NotFound();
            }
            return View(practiceSession);
        }

        // POST: PracticeSessions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Team_id,Coach_id,Address")] Data.PracticeSession practiceSession)
        {
            if (id != practiceSession.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(practiceSession);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PracticeSessionExists(practiceSession.Id))
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
            return View(practiceSession);
        }

        // GET: PracticeSessions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var practiceSession = await _context.PracticeSession
                .FirstOrDefaultAsync(m => m.Id == id);
            if (practiceSession == null)
            {
                return NotFound();
            }

            return View(practiceSession);
        }

        // POST: PracticeSessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var practiceSession = await _context.PracticeSession.FindAsync(id);
            _context.PracticeSession.Remove(practiceSession);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PracticeSessionExists(int id)
        {
            return _context.PracticeSession.Any(e => e.Id == id);
        }
    }
}
