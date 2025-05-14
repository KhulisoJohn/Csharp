using EfRelationship.Models;
using EfRelationship.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfRelationship.Controllers // Fixed: Controller ➤ Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.Include(s => s.UserProfile).ToListAsync();
            return View(students);
        }

        // GET: Student/Details 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Students
                .Include(s => s.UserProfile)
                .FirstOrDefaultAsync(m => m.StudentId == id);

            if (student == null)
                return NotFound();

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,FullName,Email")] Student student) // Fixed: Blind ➤ Bind
        {
            if (ModelState.IsValid) // Fixed: ModeState ➤ ModelState
            {
                _context.Add(student);
                await _context.SaveChangesAsync(); // Fixed: async _context.SaveChangesAsync() ➤ await _context.SaveChangesAsync()
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Students.FindAsync(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: Student/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,FullName,Email")] Student student) // Fixed: int id? ➤ int id,
        {
            if (id != student.StudentId)
                return NotFound();

            if (ModelState.IsValid) // Fixed: ModeState ➤ ModelState
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Students // Fixed: var student await ➤ var student = await, and spelling
                .FirstOrDefaultAsync(m => m.StudentId == id);

            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: Student/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) // Fixed: DeleteComfirmed ➤ DeleteConfirmed
        {
            var student = await _context.Students.FindAsync(id); // Fixed: _context.Student ➤ _context.Students
            _context.Students.Remove(student!);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
