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
    public class SetPcaStatusController : Controller
    {
        private readonly CoreContext _context;

        public SetPcaStatusController(CoreContext context)
        {
            _context = context;
        }
        // GET: SetPcaStatusController
        public async Task<IActionResult> Index()
        {
            return View(await _context.RefPCAStatus.ToListAsync());
        }

       

        // GET: SetPcaStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SetPcaStatusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Active")] RefPCAStatus refPcaStatus)
        {
            var refData = await _context.RefPCAStatus.OrderByDescending(o => o.Id).FirstOrDefaultAsync();
            refPcaStatus.Id = refData.Id + 1;
            if (ModelState.IsValid)
            {
                _context.Add(refPcaStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(refPcaStatus);
        }

        // GET: SetPcaStatusController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refCause = await _context.RefPCAStatus.FindAsync(id);
            if (refCause == null)
            {
                return NotFound();
            }
            return View(refCause);
        }

        // POST: SetPcaStatusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Active")] RefPCAStatus refPcaStatus)
        {
            if (id != refPcaStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refPcaStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(refPcaStatus);
        }


    }
}
