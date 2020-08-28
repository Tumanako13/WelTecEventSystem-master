using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WelTecEventSystem.Models;

namespace WelTecEventSystem.Controllers
{
    public class RegistersController : Controller
    {
        private readonly WelTecOnlineRegistrationContext _context;

        public RegistersController(WelTecOnlineRegistrationContext context)
        {
            _context = context;
        }

        // GET: Registers
        public async Task<IActionResult> Index()
        {
            var welTecOnlineRegistrationContext = _context.Register.Include(r => r.EventNameNavigation).Include(r => r.UserMainEmailNavigation);
            return View(await welTecOnlineRegistrationContext.ToListAsync());
        }

        // GET: Registers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var register = await _context.Register
                .Include(r => r.EventNameNavigation)
                .Include(r => r.UserMainEmailNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (register == null)
            {
                return NotFound();
            }

            return View(register);
        }

        // GET: Registers/Create
        public IActionResult Create()
        {
            ViewData["EventName"] = new SelectList(_context.Event, "EventName", "EventName");
            ViewData["UserMainEmail"] = new SelectList(_context.User, "UserMainEmail", "UserMainEmail");
            return View();
        }

        // POST: Registers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserMainEmail,EventName")] Register register)
        {
            if (ModelState.IsValid)
            {
                _context.Add(register);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventName"] = new SelectList(_context.Event, "EventName", "EventName", register.EventName);
            ViewData["UserMainEmail"] = new SelectList(_context.User, "UserMainEmail", "UserMainEmail", register.UserMainEmail);
            return View(register);
        }

        // GET: Registers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var register = await _context.Register.FindAsync(id);
            if (register == null)
            {
                return NotFound();
            }
            ViewData["EventName"] = new SelectList(_context.Event, "EventName", "EventName", register.EventName);
            ViewData["UserMainEmail"] = new SelectList(_context.User, "UserMainEmail", "UserMainEmail", register.UserMainEmail);
            return View(register);
        }

        // POST: Registers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserMainEmail,EventName")] Register register)
        {
            if (id != register.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(register);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisterExists(register.Id))
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
            ViewData["EventName"] = new SelectList(_context.Event, "EventName", "EventName", register.EventName);
            ViewData["UserMainEmail"] = new SelectList(_context.User, "UserMainEmail", "UserMainEmail", register.UserMainEmail);
            return View(register);
        }

        // GET: Registers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var register = await _context.Register
                .Include(r => r.EventNameNavigation)
                .Include(r => r.UserMainEmailNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (register == null)
            {
                return NotFound();
            }

            return View(register);
        }

        // POST: Registers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var register = await _context.Register.FindAsync(id);
            _context.Register.Remove(register);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisterExists(int id)
        {
            return _context.Register.Any(e => e.Id == id);
        }
    }
}
