using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ADminLteTest.Entites;
using ADminLteTest.Infra;

namespace ADminLteTest.Controllers
{
    public class ExpertTrainingsController : Controller
    {
        private readonly OrgDbContext _context;

        public ExpertTrainingsController(OrgDbContext context)
        {
            _context = context;
        }

        // GET: ExpertTrainings
        public async Task<IActionResult> Index(int ExpertNo)
        {
            ViewBag.ExpertNo = ExpertNo;
            var orgDbContext = _context.ExpertTraining.Where(e => e.ExpertNo == ExpertNo).Include(e => e.Expert);
            return View(await orgDbContext.ToListAsync());
        }

        // GET: ExpertTrainings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ExpertTraining == null)
            {
                return NotFound();
            }

            var expertTraining = await _context.ExpertTraining
                .Include(e => e.Expert)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expertTraining == null)
            {
                return NotFound();
            }

            return View(expertTraining);
        }

        // GET: ExpertTrainings/Create
        public IActionResult Create(int? ExpertNo)
        {
            ViewBag.Experts = new SelectList(_context.Expert.ToList(), "Id", "FullName");
            if (ExpertNo != 0 && ExpertNo != null)
                ViewBag.Experts = new SelectList(_context.Expert.ToList(), "Id", "FullName", ExpertNo);
            return View();
        }

        // POST: ExpertTrainings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ExpertNo,TrainingName,Address,Period,Date")] ExpertTraining expertTraining)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expertTraining);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { ExpertNo = expertTraining.ExpertNo });
            }
            ViewData["ExpertNo"] = new SelectList(_context.Expert, "Id", "Id", expertTraining.ExpertNo);
            return View(expertTraining);
        }

        // GET: ExpertTrainings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ExpertTraining == null)
            {
                return NotFound();
            }

            var expertTraining = await _context.ExpertTraining.FindAsync(id);
            if (expertTraining == null)
            {
                return NotFound();
            }
            ViewBag.Experts = new SelectList(_context.Expert.ToList(), "Id", "FullName");
            return View(expertTraining);
        }

        // POST: ExpertTrainings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ExpertNo,TrainingName,Address,Period,Date")] ExpertTraining expertTraining)
        {
            if (id != expertTraining.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expertTraining);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpertTrainingExists(expertTraining.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { ExpertNo = expertTraining.ExpertNo });
            }
            ViewData["ExpertNo"] = new SelectList(_context.Expert, "Id", "Id", expertTraining.ExpertNo);
            return View(expertTraining);
        }

        // GET: ExpertTrainings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ExpertTraining == null)
            {
                return NotFound();
            }

            var expertTraining = await _context.ExpertTraining
                .Include(e => e.Expert)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expertTraining == null)
            {
                return NotFound();
            }

            return View(expertTraining);
        }

        // POST: ExpertTrainings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ExpertTraining == null)
            {
                return Problem("Entity set 'OrgDbContext.ExpertTraining'  is null.");
            }
            var expertTraining = await _context.ExpertTraining.FindAsync(id);
            var ExpertNo = expertTraining.ExpertNo;
            if (expertTraining != null)
            {
                _context.ExpertTraining.Remove(expertTraining);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { ExpertNo = ExpertNo });
        }

        private bool ExpertTrainingExists(int id)
        {
          return _context.ExpertTraining.Any(e => e.Id == id);
        }
    }
}
