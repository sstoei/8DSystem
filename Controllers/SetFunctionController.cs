using _8DSystem.Models;
using _8DSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Controllers
{
   [Authorize(Roles = "Admin")]
    public class SetFunctionController : Controller
    {
        private readonly CoreContext _context;

        public SetFunctionController(CoreContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.RefFunction.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Active")] RefFunction refFunction)
        {
            var refData = await _context.RefFunction.OrderByDescending(o => o.Id).FirstOrDefaultAsync();
            refFunction.Id = refData.Id+1;
            if (ModelState.IsValid)
            {
                _context.Add(refFunction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(refFunction);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refCause = await _context.RefFunction.FindAsync(id);
            if (refCause == null)
            {
                return NotFound();
            }
            return View(refCause);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Active")] RefFunction refFunction)
        {
            if (id != refFunction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refFunction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(refFunction);
        }

    }
}
