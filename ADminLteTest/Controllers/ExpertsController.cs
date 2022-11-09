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
    public class ExpertsController : Controller
    {
        private readonly OrgDbContext _context;

        public ExpertsController(OrgDbContext context)
        {
            _context = context;
        }

        // GET: Experts
        public async Task<IActionResult> Index()
        {
            var orgDbContext = _context.Expert.Include(e => e.WorkNature);
            return View(await orgDbContext.ToListAsync());
        }

        // GET: Experts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Expert == null)
            {
                return NotFound();
            }

            var expert = await _context.Expert
                .Include(e => e.WorkNature)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expert == null)
            {
                return NotFound();
            }

            return View(expert);
        }

        // GET: Experts/Create
        public IActionResult Create()
        {
            ViewBag.WorkNature = new SelectList(_context.WorkNatures.ToList(), "Id", "NameAr");
            return View();
        }

        // POST: Experts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Address,PersonalMobile,WorkMobile,RegularMail,Email,WorkingFor,WorkNatureNo")] Expert expert)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expert);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["WorkNatureNo"] = new SelectList(_context.WorkNatures, "Id", "Id", expert.WorkNatureNo);
            return View(expert);
        }

        // GET: Experts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Expert == null)
            {
                return NotFound();
            }

            var expert = await _context.Expert.FindAsync(id);
            if (expert == null)
            {
                return NotFound();
            }
            ViewBag.WorkNature = new SelectList(_context.WorkNatures.ToList(), "Id", "NameAr");
            return View(expert);
        }

        // POST: Experts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Address,PersonalMobile,WorkMobile,RegularMail,Email,WorkingFor,WorkNatureNo")] Expert expert)
        {
            if (id != expert.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expert);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpertExists(expert.Id))
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
            ViewData["WorkNatureNo"] = new SelectList(_context.WorkNatures, "Id", "Id", expert.WorkNatureNo);
            return View(expert);
        }

        // GET: Experts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Expert == null)
            {
                return NotFound();
            }

            var expert = await _context.Expert
                .Include(e => e.WorkNature)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expert == null)
            {
                return NotFound();
            }

            return View(expert);
        }

        // POST: Experts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Expert == null)
            {
                return Problem("Entity set 'OrgDbContext.Expert'  is null.");
            }
            var expert = await _context.Expert.FindAsync(id);
            if (expert != null)
            {
                _context.Expert.Remove(expert);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpertExists(int id)
        {
          return _context.Expert.Any(e => e.Id == id);
        }
    }
}
