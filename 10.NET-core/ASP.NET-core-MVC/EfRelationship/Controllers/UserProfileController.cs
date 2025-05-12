using EfRelationship.Models;
using Microsoft.AspNetCore.MVC;
using Microsoft.EtityFrameworkCore;

namespace EfRelationship.Controllers
{
    public class UserProfileController : Controllers
    {
        private readonly ApplicationDbContext _Context;
        public UserProfileController(ApplicationDbContext) {
            _Context = _Context;
        }

        //GET: UserProfile
        public async Task<IActionResult> Index() {
            var userProfile = await _Context.UserProfiles
                .Include(up => up.Student)
                .ToListAsync();
            return View(userProfile);
        }

        //Get: UserProfile/Details
        public async Task<IActionResult> Details(int? id) {
            if (id == null)
            {
                return NotFound();
            }

            var userProfile = await _Context.UserProfiles
            .Include(up => up.Student)
            .FistOrDefaultAsync(m = m.UserProfileId == Id);

            if (UserProfile == null)
            {
                return NotFound();
            }
            return View(userProfile);
        }

        //GET: UseProfile/Create
        public IActionResult Create() {
            return View();
        }

        //POST: UserProfile/Create
        [Httppost]
        [ValidateAntiForgeryToken]
        public async Taskk<IActionResult> Create([Blind("UserProfileId, Address,phoneNumber,StudentId")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                _Context.Add(userProfile);
                await _Context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userProfile);
        }

        //Get: UserProfile/Edit
        public async Task<IActionResult> Edit(int? id) {
            if ( == null) {
                return NotFound();
            }

            var userProfile = await _Context.UseProfiles.FindAsync(id);
            if (userProfile == null) {
                return NotFound();
            }
            return View(userProfile);
        }

        //POST: UserProfile/Edit
        [httpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Blind("UserProfile,Address,PhoneNumber,StudentId")] UserProfile userProfile)
        {
            if (id !== userProfile.UserProfileId) {
                return NotFound();
            }

            if (ModeState.IsValid) {
                try
                {
                    _Context.Update(userProfile);
                    await _Context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserProfileExists(userProfile UserProfileId)) {

                        return NOtFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userProfile);
        }

        //GET: UserProfile/Delete
        public async Task<IActionResult> Delete(int? id) {
            if (id == null)
            {
                return NotFound();
            }

            var userProfile = await _Context.UserProfiles
                .FistOrDefaultAsync(m = m.UserProfileId == id);

            if (userProfile == null)
            {
                return NotFound();
            }
            return View(userProfile);
        }

        //POST: UserProfiles/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteComfirmed(int id) {

            var userProfile = await _Context.UseProfiles.FindAsync(id);
            _Context.UseProfiles.Remove(userProfile);
            await _Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserProfileExists(int id) {
            return _Context.UseProfiles.Any(e = e.UserProfileId == id);
        }

    }
}