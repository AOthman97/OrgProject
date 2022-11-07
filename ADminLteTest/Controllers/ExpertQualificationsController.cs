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
    public class ExpertQualificationsController : Controller
    {
        private readonly OrgDbContext _context;

        public ExpertQualificationsController(OrgDbContext context)
        {
            _context = context;
        }

        // GET: ExpertQualifications
        public async Task<IActionResult> Index(int ExpertNo)
        {
            ViewBag.ExpertNo = ExpertNo;
            var orgDbContext = _context.ExpertQualifications.Where(e => e.ExpertNo == ExpertNo).Include(e => e.Expert).Include(e => e.Qualification);
            return View(await orgDbContext.ToListAsync());
        }

        // GET: ExpertQualifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ExpertQualifications == null)
            {
                return NotFound();
            }

            var expertQualifications = await _context.ExpertQualifications
                .Include(e => e.Expert)
                .Include(e => e.Qualification)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expertQualifications == null)
            {
                return NotFound();
            }

            return View(expertQualifications);
        }

        // GET: ExpertQualifications/Create
        public IActionResult Create(int? ExpertNo)
        {
            ViewBag.Experts = new SelectList(_context.Expert.ToList(), "Id", "FullName");
            if (ExpertNo != 0 && ExpertNo != null)
                ViewBag.Experts = new SelectList(_context.Expert.ToList(), "Id", "FullName", ExpertNo);
            ViewBag.Qualifications = new SelectList(_context.Qualifications.ToList(), "Id", "Name");
            return View();
        }

        // POST: ExpertQualifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ExpertNo,QualificationsNo,Division,Faculty,University,GraduationDate")] ExpertQualifications expertQualifications)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expertQualifications);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { ExpertNo = expertQualifications.ExpertNo });
            }
            return View(expertQualifications);
        }

        // GET: ExpertQualifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ExpertQualifications == null)
            {
                return NotFound();
            }

            var expertQualifications = await _context.ExpertQualifications.FindAsync(id);
            if (expertQualifications == null)
            {
                return NotFound();
            }
            ViewBag.Experts = new SelectList(_context.Expert.ToList(), "Id", "FullName");
            ViewBag.Qualifications = new SelectList(_context.Qualifications.ToList(), "Id", "Name");
            return View(expertQualifications);
        }

        // POST: ExpertQualifications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ExpertNo,QualificationsNo,Division,Faculty,University,GraduationDate")] ExpertQualifications expertQualifications)
        {
            if (id != expertQualifications.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expertQualifications);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpertQualificationsExists(expertQualifications.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { ExpertNo = expertQualifications.ExpertNo });
            }
            ViewData["ExpertNo"] = new SelectList(_context.Expert, "Id", "Id", expertQualifications.ExpertNo);
            ViewData["QualificationsNo"] = new SelectList(_context.Qualifications, "Id", "Id", expertQualifications.QualificationsNo);
            return View(expertQualifications);
        }

        // GET: ExpertQualifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ExpertQualifications == null)
            {
                return NotFound();
            }

            var expertQualifications = await _context.ExpertQualifications
                .Include(e => e.Expert)
                .Include(e => e.Qualification)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expertQualifications == null)
            {
                return NotFound();
            }

            return View(expertQualifications);
        }

        // POST: ExpertQualifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ExpertQualifications == null)
            {
                return Problem("Entity set 'OrgDbContext.ExpertQualifications'  is null.");
            }
            var expertQualifications = await _context.ExpertQualifications.FindAsync(id);
            var ExpertNo = expertQualifications.ExpertNo;
            if (expertQualifications != null)
            {
                _context.ExpertQualifications.Remove(expertQualifications);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { ExpertNo = ExpertNo });
        }

        private bool ExpertQualificationsExists(int id)
        {
          return _context.ExpertQualifications.Any(e => e.Id == id);
        }
    }
}
