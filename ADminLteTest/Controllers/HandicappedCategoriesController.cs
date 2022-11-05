using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ADminLteTest.Entites;
using ADminLteTest.Infra;

namespace ADminLteTest.Controllers
{
    public class HandicappedCategoriesController : Controller
    {
        private readonly OrgDbContext _context;

        public HandicappedCategoriesController(OrgDbContext context)
        {
            _context = context;
        }

        // GET: HandicappedCategories, Get all organizations that have data in the HandicappedCategory
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = (from b in _context.OrgDetails
                                        join c in _context.HandicappedCategory
                                        on b.Id equals c.OrgDetailsNo
                                        select new OrgDetails()
                                        {
                                            Id = b.Id,
                                            Name = b.Name
                                        }).Distinct().AsNoTracking();
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> NewIndex(int OrgDetailsId)
        {
            ViewBag.OrgDetailsId = OrgDetailsId;
            var applicationDbContext = _context.HandicappedCategory.Where(h => h.OrgDetailsNo == OrgDetailsId)
                .Include(h => h.Categories)
                .Include(h => h.Ages)
                .Include(h => h.Genders)
                .ToListAsync();
            return View(await applicationDbContext);
        }

        // GET: HandicappedCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HandicappedCategory == null)
            {
                return NotFound();
            }

            var handicappedCategory = await _context.HandicappedCategory
                .Include(h => h.OrgDetails)
                .Include(h => h.Categories)
                .Include(h => h.Ages)
                .Include(h => h.Genders)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (handicappedCategory == null)
            {
                return NotFound();
            }
            return View(handicappedCategory);
        }

        // GET: HandicappedCategories/Create
        public IActionResult Create(int? OrgDetailsNo)
        {
            ViewBag.OrgDetails = new SelectList(_context.OrgDetails.ToList(), "Id", "Name");
            if(OrgDetailsNo != 0 && OrgDetailsNo != null)
                ViewBag.OrgDetails = new SelectList(_context.OrgDetails.ToList(), "Id", "Name", OrgDetailsNo);
            ViewBag.Category = new SelectList(_context.Category.ToList(), "Id", "Name");
            ViewBag.Ages = new SelectList(_context.Ages.ToList(), "Id", "AgeAvarege");
            ViewBag.Genders = new SelectList(_context.Genders.ToList(), "Id", "GenderType");
            return View();
        }

        // POST: HandicappedCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrgDetailsNo,CategoryNo,AgeNo,GenderNo,Quantity")] HandicappedCategory handicappedCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(handicappedCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(handicappedCategory);
        }

        // GET: HandicappedCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HandicappedCategory == null)
            {
                return NotFound();
            }

            var handicappedCategory = await _context.HandicappedCategory.FindAsync(id);
            if (handicappedCategory == null)
            {
                return NotFound();
            }
            ViewBag.OrgDetails = new SelectList(_context.OrgDetails.ToList(), "Id", "Name");
            ViewBag.Category = new SelectList(_context.Category.ToList(), "Id", "Name");
            ViewBag.Ages = new SelectList(_context.Ages.ToList(), "Id", "AgeAvarege");
            ViewBag.Genders = new SelectList(_context.Genders.ToList(), "Id", "GenderType");
            return View(handicappedCategory);
        }

        // POST: HandicappedCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrgDetailsNo,CategoryNo,AgeNo,GenderNo,Quantity")] HandicappedCategory handicappedCategory)
        {
            if (id != handicappedCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(handicappedCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HandicappedCategoryExists(handicappedCategory.Id))
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
            return View(handicappedCategory);
        }

        // GET: HandicappedCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HandicappedCategory == null)
            {
                return NotFound();
            }

            var handicappedCategory = await _context.HandicappedCategory
                .Include(h => h.OrgDetails)
                .Include(h => h.Categories)
                .Include(h => h.Ages)
                .Include(h => h.Genders)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (handicappedCategory == null)
            {
                return NotFound();
            }

            return View(handicappedCategory);
        }

        // POST: HandicappedCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HandicappedCategory == null)
            {
                return Problem("Entity set 'OrgDbContext.HandicappedCategory'  is null.");
            }
            var handicappedCategory = await _context.HandicappedCategory.FindAsync(id);
            if (handicappedCategory != null)
            {
                _context.HandicappedCategory.Remove(handicappedCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HandicappedCategoryExists(int id)
        {
          return _context.HandicappedCategory.Any(e => e.Id == id);
        }
    }
}