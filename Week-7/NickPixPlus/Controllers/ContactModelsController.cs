using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NickPixPlus.Data;
using NickPixPlus.Models;

namespace NickPixPlus.Controllers
{
    public class ContactModelsController : Controller
    {
        private readonly NickPixPlusContext _context;

        public ContactModelsController(NickPixPlusContext context)
        {
            _context = context;
        }

        // GET: ContactModels
        public async Task<IActionResult> Index()
        {
              return _context.ContactModel != null ? 
                          View(await _context.ContactModel.ToListAsync()) :
                          Problem("Entity set 'NickPixPlusContext.ContactModel'  is null.");
        }

        // GET: ContactModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ContactModel == null)
            {
                return NotFound();
            }

            var contactModel = await _context.ContactModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactModel == null)
            {
                return NotFound();
            }

            return View(contactModel);
        }

        // GET: ContactModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Address,Phone,Email,Message")] ContactModel contactModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactModel);
        }

        // GET: ContactModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ContactModel == null)
            {
                return NotFound();
            }

            var contactModel = await _context.ContactModel.FindAsync(id);
            if (contactModel == null)
            {
                return NotFound();
            }
            return View(contactModel);
        }

        // POST: ContactModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Address,Phone,Email,Message")] ContactModel contactModel)
        {
            if (id != contactModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactModelExists(contactModel.Id))
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
            return View(contactModel);
        }

        // GET: ContactModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ContactModel == null)
            {
                return NotFound();
            }

            var contactModel = await _context.ContactModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactModel == null)
            {
                return NotFound();
            }

            return View(contactModel);
        }

        // POST: ContactModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ContactModel == null)
            {
                return Problem("Entity set 'NickPixPlusContext.ContactModel'  is null.");
            }
            var contactModel = await _context.ContactModel.FindAsync(id);
            if (contactModel != null)
            {
                _context.ContactModel.Remove(contactModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactModelExists(int id)
        {
          return (_context.ContactModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
