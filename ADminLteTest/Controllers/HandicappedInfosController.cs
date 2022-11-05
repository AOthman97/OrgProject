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
    public class HandicappedInfosController : Controller
    {
        private readonly OrgDbContext _context;

        public HandicappedInfosController(OrgDbContext context)
        {
            _context = context;
        }

        // GET: HandicappedInfos
        public async Task<IActionResult> Index()
        {
            var orgDbContext = _context.HandicappedInfo.Include(h => h.AccommodationTypes).Include(h => h.Categories).Include(h => h.Cities).Include(h => h.Districts).Include(h => h.EconomicLevels).Include(h => h.PersonalEducationalStatuses).Include(h => h.Genders).Include(h => h.OrgDetails).Include(h => h.WorkNatures);
            return View(await orgDbContext.ToListAsync());
        }

        // GET: HandicappedInfos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HandicappedInfo == null)
            {
                return NotFound();
            }

            var handicappedInfo = await _context.HandicappedInfo
                .Include(h => h.AccommodationTypes)
                .Include(h => h.Categories)
                .Include(h => h.Cities)
                .Include(h => h.Districts)
                .Include(h => h.EconomicLevels)
                .Include(h => h.PersonalEducationalStatuses)
                .Include(h => h.FatherEducationalStatuses)
                .Include(h => h.MotherEducationalStatuses)
                .Include(h => h.Genders)
                .Include(h => h.OrgDetails)
                .Include(h => h.WorkNatures)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (handicappedInfo == null)
            {
                return NotFound();
            }

            return View(handicappedInfo);
        }

        // GET: HandicappedInfos/Create
        public IActionResult Create()
        {
            ViewBag.City = new SelectList(_context.Cities.ToList(), "Id", "Name");
            ViewBag.District = new SelectList(_context.Districts.ToList(), "Id", "Name");
            ViewBag.AccommodationType = new SelectList(_context.AccommodationType.ToList(), "Id", "Name");
            ViewBag.Genders = new SelectList(_context.Genders.ToList(), "Id", "GenderType");
            ViewBag.OrgDetails = new SelectList(_context.OrgDetails.ToList(), "Id", "Name");
            ViewBag.Category = new SelectList(_context.Category.ToList(), "Id", "Name");
            ViewBag.WorkNature = new SelectList(_context.WorkNatures.ToList(), "Id", "Name");
            ViewBag.EconomicLevel = new SelectList(_context.EconomicLevel.ToList(), "Id", "Name");
            ViewBag.PersonalEducationalStatus = new SelectList(_context.EducationalStatus.ToList(), "Id", "Name");
            ViewBag.FatherEducationalStatus = new SelectList(_context.EducationalStatus.ToList(), "Id", "Name");
            ViewBag.MotherEducationalStatus = new SelectList(_context.EducationalStatus.ToList(), "Id", "Name");
            return View();
        }

        // POST: HandicappedInfos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Address,Weaknesses,FatherMobile,MotherMobile,BirthDate,Age,GenderNo,OrgDetailsNo,CityNo,DistrictNo,CategoryNo,WorkNatureNo,EconomicLevelNo,AccommodationTypeNo,EducationalStatusNo,FatherEducationalStatusNo,MotherEducationalStatusNo,IsWorking,HafezCapability,SwimmingCapability,DrawAndColoringCapability,LiteratureCapability")] HandicappedInfo handicappedInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(handicappedInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccommodationTypeNo"] = new SelectList(_context.AccommodationType, "Id", "Id", handicappedInfo.AccommodationTypeNo);
            ViewData["CategoryNo"] = new SelectList(_context.Category, "Id", "Id", handicappedInfo.CategoryNo);
            ViewData["CityNo"] = new SelectList(_context.Cities, "Id", "Id", handicappedInfo.CityNo);
            ViewData["DistrictNo"] = new SelectList(_context.Districts, "Id", "Id", handicappedInfo.DistrictNo);
            ViewData["EconomicLevelNo"] = new SelectList(_context.EconomicLevel, "Id", "Id", handicappedInfo.EconomicLevelNo);
            ViewData["MotherEducationalStatusNo"] = new SelectList(_context.EducationalStatus, "Id", "Id", handicappedInfo.MotherEducationalStatusNo);
            ViewData["GenderNo"] = new SelectList(_context.Genders, "Id", "Id", handicappedInfo.GenderNo);
            ViewData["OrgDetailsNo"] = new SelectList(_context.OrgDetails, "Id", "Id", handicappedInfo.OrgDetailsNo);
            ViewData["WorkNatureNo"] = new SelectList(_context.WorkNatures, "Id", "Id", handicappedInfo.WorkNatureNo);
            return View(handicappedInfo);
        }

        // GET: HandicappedInfos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HandicappedInfo == null)
            {
                return NotFound();
            }

            var handicappedInfo = await _context.HandicappedInfo.FindAsync(id);
            if (handicappedInfo == null)
            {
                return NotFound();
            }
            ViewBag.City = new SelectList(_context.Cities.ToList(), "Id", "Name");
            ViewBag.District = new SelectList(_context.Districts.ToList(), "Id", "Name");
            ViewBag.AccommodationType = new SelectList(_context.AccommodationType.ToList(), "Id", "Name");
            ViewBag.Genders = new SelectList(_context.Genders.ToList(), "Id", "GenderType");
            ViewBag.OrgDetails = new SelectList(_context.OrgDetails.ToList(), "Id", "Name");
            ViewBag.Category = new SelectList(_context.Category.ToList(), "Id", "Name");
            ViewBag.WorkNature = new SelectList(_context.WorkNatures.ToList(), "Id", "Name");
            ViewBag.EconomicLevel = new SelectList(_context.EconomicLevel.ToList(), "Id", "Name");
            ViewBag.PersonalEducationalStatus = new SelectList(_context.EducationalStatus.ToList(), "Id", "Name");
            ViewBag.FatherEducationalStatus = new SelectList(_context.EducationalStatus.ToList(), "Id", "Name");
            ViewBag.MotherEducationalStatus = new SelectList(_context.EducationalStatus.ToList(), "Id", "Name");
            return View(handicappedInfo);
        }

        // POST: HandicappedInfos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Address,Weaknesses,FatherMobile,MotherMobile,BirthDate,Age,GenderNo,OrgDetailsNo,CityNo,DistrictNo,CategoryNo,WorkNatureNo,EconomicLevelNo,AccommodationTypeNo,EducationalStatusNo,FatherEducationalStatusNo,MotherEducationalStatusNo,IsWorking,HafezCapability,SwimmingCapability,DrawAndColoringCapability,LiteratureCapability")] HandicappedInfo handicappedInfo)
        {
            if (id != handicappedInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(handicappedInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HandicappedInfoExists(handicappedInfo.Id))
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
            ViewData["AccommodationTypeNo"] = new SelectList(_context.AccommodationType, "Id", "Id", handicappedInfo.AccommodationTypeNo);
            ViewData["CategoryNo"] = new SelectList(_context.Category, "Id", "Id", handicappedInfo.CategoryNo);
            ViewData["CityNo"] = new SelectList(_context.Cities, "Id", "Id", handicappedInfo.CityNo);
            ViewData["DistrictNo"] = new SelectList(_context.Districts, "Id", "Id", handicappedInfo.DistrictNo);
            ViewData["EconomicLevelNo"] = new SelectList(_context.EconomicLevel, "Id", "Id", handicappedInfo.EconomicLevelNo);
            ViewData["MotherEducationalStatusNo"] = new SelectList(_context.EducationalStatus, "Id", "Id", handicappedInfo.MotherEducationalStatusNo);
            ViewData["GenderNo"] = new SelectList(_context.Genders, "Id", "Id", handicappedInfo.GenderNo);
            ViewData["OrgDetailsNo"] = new SelectList(_context.OrgDetails, "Id", "Id", handicappedInfo.OrgDetailsNo);
            ViewData["WorkNatureNo"] = new SelectList(_context.WorkNatures, "Id", "Id", handicappedInfo.WorkNatureNo);
            return View(handicappedInfo);
        }

        // GET: HandicappedInfos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HandicappedInfo == null)
            {
                return NotFound();
            }

            var handicappedInfo = await _context.HandicappedInfo
                .Include(h => h.AccommodationTypes)
                .Include(h => h.Categories)
                .Include(h => h.Cities)
                .Include(h => h.Districts)
                .Include(h => h.EconomicLevels)
                .Include(h => h.PersonalEducationalStatuses)
                .Include(h => h.FatherEducationalStatuses)
                .Include(h => h.MotherEducationalStatuses)
                .Include(h => h.Genders)
                .Include(h => h.OrgDetails)
                .Include(h => h.WorkNatures)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (handicappedInfo == null)
            {
                return NotFound();
            }

            return View(handicappedInfo);
        }

        // POST: HandicappedInfos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HandicappedInfo == null)
            {
                return Problem("Entity set 'OrgDbContext.HandicappedInfo'  is null.");
            }
            var handicappedInfo = await _context.HandicappedInfo.FindAsync(id);
            if (handicappedInfo != null)
            {
                _context.HandicappedInfo.Remove(handicappedInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HandicappedInfoExists(int id)
        {
          return _context.HandicappedInfo.Any(e => e.Id == id);
        }
    }
}
