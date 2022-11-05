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
    public class OrgnaizationsApplicationsController : Controller
    {
        private readonly OrgDbContext _context;

        public OrgnaizationsApplicationsController(OrgDbContext context)
        {
            _context = context;
        }

        // GET: OrgnaizationsApplications
        public async Task<IActionResult> Index()
        {
              return View(await _context.OrgnaizationsApplications.ToListAsync());
        }

        // GET: OrgnaizationsApplications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OrgnaizationsApplications == null)
            {
                return NotFound();
            }

            var orgnaizationsApplication = await _context.OrgnaizationsApplications
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orgnaizationsApplication == null)
            {
                return NotFound();
            }

            return View(orgnaizationsApplication);
        }

        // GET: OrgnaizationsApplications/Create
        public IActionResult Create()
        {
            ViewBag.CommunicationTypes = new SelectList(_context.CommunicationType.ToList() , "Id", "Name");
            ViewBag.OrgDetails = new SelectList(_context.OrgDetails.ToList() , "Id", "Name");
            ViewBag.WorkNatures = new SelectList(_context.WorkNatures.ToList() , "Id", "Name");
            ViewBag.Staffs = new SelectList(_context.Staffs.ToList() , "Id", "Name");
            ViewBag.ProgressTypes = new SelectList(_context.ProgressTypes.ToList() , "Id", "Name");
            return View();
        }

        // POST: OrgnaizationsApplications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ApplicantName,ApplicationDate,OrgDetailsNo,WorkNutureNo,StaffNo,IsApproched,ApprochNature,ResourcesRoom,QualificationPeriod,IsProgreessed,ProgressTypeNo,Comment,CommunicationTypeNo,IdeasAndRecommondaions")] OrgnaizationsApplication orgnaizationsApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orgnaizationsApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orgnaizationsApplication);
        }

        // GET: OrgnaizationsApplications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OrgnaizationsApplications == null)
            {
                return NotFound();
            }

            var orgnaizationsApplication = await _context.OrgnaizationsApplications.FindAsync(id);
            if (orgnaizationsApplication == null)
            {
                return NotFound();
            }
            return View(orgnaizationsApplication);
        }

        // POST: OrgnaizationsApplications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ApplicantName,ApplicationDate,OrgDetailsNo,WorkNutureNo,StaffNo,IsApproched,ApprochNature,ResourcesRoom,QualificationPeriod,IsProgreessed,ProgressTypeNo,Comment,CommunicationTypeNo,IdeasAndRecommondaions")] OrgnaizationsApplication orgnaizationsApplication)
        {
            if (id != orgnaizationsApplication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orgnaizationsApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrgnaizationsApplicationExists(orgnaizationsApplication.Id))
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
            return View(orgnaizationsApplication);
        }

        // GET: OrgnaizationsApplications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OrgnaizationsApplications == null)
            {
                return NotFound();
            }

            var orgnaizationsApplication = await _context.OrgnaizationsApplications
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orgnaizationsApplication == null)
            {
                return NotFound();
            }

            return View(orgnaizationsApplication);
        }

        // POST: OrgnaizationsApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrgnaizationsApplications == null)
            {
                return Problem("Entity set 'OrgDbContext.OrgnaizationsApplications'  is null.");
            }
            var orgnaizationsApplication = await _context.OrgnaizationsApplications.FindAsync(id);
            if (orgnaizationsApplication != null)
            {
                _context.OrgnaizationsApplications.Remove(orgnaizationsApplication);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrgnaizationsApplicationExists(int id)
        {
          return _context.OrgnaizationsApplications.Any(e => e.Id == id);
        }
    }
}
