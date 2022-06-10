using _8DSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SetCauseSourceController : Controller
    {
        private readonly CoreContext _context;

        public SetCauseSourceController(CoreContext context)
        {
            _context = context;
        }
        // GET: SetCauseSourceController
        public async Task<IActionResult> Index()
        {
            return View(await _context.RefCauseSource.ToListAsync());
        }


      
        // GET: SetCauseSourceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SetPcaStatusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Active")] RefCauseSource refCauseSource)
        {
            var refData = await _context.RefCauseSource.OrderByDescending(o => o.Id).FirstOrDefaultAsync();
            refCauseSource.Id = refData.Id + 1;
            if (ModelState.IsValid)
            {
                _context.Add(refCauseSource);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(refCauseSource);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refCause = await _context.RefCauseSource.FindAsync(id);
            if (refCause == null)
            {
                return NotFound();
            }
            return View(refCause);
        }

        // POST: SetPcaStatusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Active")] RefCauseSource refCauseSource)
        {
            if (id != refCauseSource.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refCauseSource);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(refCauseSource);
        }


    }
}
