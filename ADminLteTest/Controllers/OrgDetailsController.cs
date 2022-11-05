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
    public class OrgDetailsController : Controller
    {
        private readonly OrgDbContext _context;

        public OrgDetailsController(OrgDbContext context)
        {
            _context = context;
        }

        // GET: OrgDetails
        public async Task<IActionResult> Index()
        {
              return View(await _context.OrgDetails.ToListAsync());
        }

        // GET: OrgDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OrgDetails == null)
            {
                return NotFound();
            }

            var orgDetails = await _context.OrgDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orgDetails == null)
            {
                return NotFound();
            }

            return View(orgDetails);
        }

        // GET: OrgDetails/Create
        public IActionResult Create()
        {
            ViewBag.Cities = new SelectList(_context.Cities.ToList(), "Id", "Name");
            ViewBag.Districts = new SelectList(_context.Districts.ToList(), "Id", "Name");
            ViewBag.OrgTypes = new SelectList(_context.OrgTypes.ToList(), "Id", "Name");
            return View();
        }

        // POST: OrgDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,NameAr,DirectorName,Phone,Email,FaoundationDate,CityNo,DistrictNo,OrgTypeNo")] OrgDetails orgDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orgDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orgDetails);
        }

        // GET: OrgDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OrgDetails == null)
            {
                return NotFound();
            }

            var orgDetails = await _context.OrgDetails.FindAsync(id);
            if (orgDetails == null)
            {
                return NotFound();
            }
            return View(orgDetails);
        }

        // POST: OrgDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,NameAr,DirectorName,Phone,Email,FaoundationDate,CityNo,DistrictNo,OrgTypeNo")] OrgDetails orgDetails)
        {
            if (id != orgDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orgDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrgDetailsExists(orgDetails.Id))
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
            return View(orgDetails);
        }

        // GET: OrgDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OrgDetails == null)
            {
                return NotFound();
            }

            var orgDetails = await _context.OrgDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orgDetails == null)
            {
                return NotFound();
            }

            return View(orgDetails);
        }

        // POST: OrgDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrgDetails == null)
            {
                return Problem("Entity set 'OrgDbContext.OrgDetails'  is null.");
            }
            var orgDetails = await _context.OrgDetails.FindAsync(id);
            if (orgDetails != null)
            {
                _context.OrgDetails.Remove(orgDetails);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrgDetailsExists(int id)
        {
          return _context.OrgDetails.Any(e => e.Id == id);
        }
    }
}
