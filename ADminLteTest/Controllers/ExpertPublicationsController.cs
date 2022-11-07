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
    public class ExpertPublicationsController : Controller
    {
        private readonly OrgDbContext _context;

        public ExpertPublicationsController(OrgDbContext context)
        {
            _context = context;
        }

        // GET: ExpertPublications
        public async Task<IActionResult> Index(int ExpertNo)
        {
            ViewBag.ExpertNo = ExpertNo;
            var orgDbContext = _context.ExpertPublications.Where(e => e.ExpertNo == ExpertNo).Include(e => e.Expert);
            return View(await orgDbContext.ToListAsync());
        }

        // GET: ExpertPublications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ExpertPublications == null)
            {
                return NotFound();
            }

            var expertPublications = await _context.ExpertPublications
                .Include(e => e.Expert)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expertPublications == null)
            {
                return NotFound();
            }

            return View(expertPublications);
        }

        // GET: ExpertPublications/Create
        public IActionResult Create(int? ExpertNo)
        {
            ViewBag.Experts = new SelectList(_context.Expert.ToList(), "Id", "FullName");
            if (ExpertNo != 0 && ExpertNo != null)
                ViewBag.Experts = new SelectList(_context.Expert.ToList(), "Id", "FullName", ExpertNo);
            return View();
        }

        // POST: ExpertPublications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ExpertNo,Title,Publisher,PublishYear")] ExpertPublications expertPublications)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expertPublications);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { ExpertNo = expertPublications.ExpertNo });
            }
            ViewData["ExpertNo"] = new SelectList(_context.Expert, "Id", "Id", expertPublications.ExpertNo);
            return View(expertPublications);
        }

        // GET: ExpertPublications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ExpertPublications == null)
            {
                return NotFound();
            }

            var expertPublications = await _context.ExpertPublications.FindAsync(id);
            if (expertPublications == null)
            {
                return NotFound();
            }
            ViewBag.Experts = new SelectList(_context.Expert.ToList(), "Id", "FullName");
            return View(expertPublications);
        }

        // POST: ExpertPublications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ExpertNo,Title,Publisher,PublishYear")] ExpertPublications expertPublications)
        {
            if (id != expertPublications.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expertPublications);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpertPublicationsExists(expertPublications.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { ExpertNo = expertPublications.ExpertNo });
            }
            ViewData["ExpertNo"] = new SelectList(_context.Expert, "Id", "Id", expertPublications.ExpertNo);
            return View(expertPublications);
        }

        // GET: ExpertPublications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ExpertPublications == null)
            {
                return NotFound();
            }

            var expertPublications = await _context.ExpertPublications
                .Include(e => e.Expert)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expertPublications == null)
            {
                return NotFound();
            }

            return View(expertPublications);
        }

        // POST: ExpertPublications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ExpertPublications == null)
            {
                return Problem("Entity set 'OrgDbContext.ExpertPublications'  is null.");
            }
            var expertPublications = await _context.ExpertPublications.FindAsync(id);
            var ExpertNo = expertPublications.ExpertNo;
            if (expertPublications != null)
            {
                _context.ExpertPublications.Remove(expertPublications);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { ExpertNo = ExpertNo });
        }

        private bool ExpertPublicationsExists(int id)
        {
          return _context.ExpertPublications.Any(e => e.Id == id);
        }
    }
}
