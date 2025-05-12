using EfRelationship.Models;
using EfRelationship.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfRelationship.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserProfileController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserProfile
        public async Task<IActionResult> Index()
        {
            var userProfiles = await _context.UserProfiles
                .Include(up => up.Student)
                .ToListAsync();
            return View(userProfiles);
        }

        // GET: UserProfile/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var userProfile = await _context.UserProfiles
                .Include(up => up.Student)
                .FirstOrDefaultAsync(m => m.UserProfileId == id);

            if (userProfile == null)
                return NotFound();

            return View(userProfile);
        }

        // GET: UserProfile/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserProfile/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserProfileId,Address,PhoneNumber,StudentId")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userProfile);
        }

        // GET: UserProfile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var userProfile = await _context.UserProfiles.FindAsync(id);
            if (userProfile == null)
                return NotFound();

            return View(userProfile);
        }

        // POST: UserProfile/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserProfileId,Address,PhoneNumber,StudentId")] UserProfile userProfile)
        {
            if (id != userProfile.UserProfileId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserProfileExists(userProfile.UserProfileId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userProfile);
        }

        // GET: UserProfile/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var userProfile = await _context.UserProfiles
                .FirstOrDefaultAsync(m => m.UserProfileId == id);

            if (userProfile == null)
                return NotFound();

            return View(userProfile);
        }

        // POST: UserProfile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userProfile = await _context.UserProfiles.FindAsync(id);
            if (userProfile != null)
            {
                _context.UserProfiles.Remove(userProfile);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool UserProfileExists(int id)
        {
            return _context.UserProfiles.Any(e => e.UserProfileId == id);
        }
    }
}
