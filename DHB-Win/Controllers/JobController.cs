using System.Linq;
using System.Threading.Tasks;
using DHB_Win.Data;
using DHB_Win.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DHB_Win.Controllers
{
    public class JobController : Controller
    {
        private readonly dhbwinContext _context;

        public JobController(dhbwinContext context)
        {
            _context = context;
        }

        // GET: Job
        public async Task<IActionResult> Index()
        {
            //ViewBag.achievements = _context.Achievements.Select(x => x).ToList();

            var dhbwinContext = _context.Jobs.Include(j => j.Provider).Include(j => j.Worker);
            return View(await dhbwinContext.ToListAsync());
        }

        // GET: Job/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Jobs == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs
                .Include(j => j.Provider)
                .Include(j => j.Worker)
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // GET: Job/Create
        public IActionResult Create()
        {
            ViewData["ProviderId"] = new SelectList(_context.Users, "Uid", "Uid");
            ViewData["WorkerId"] = new SelectList(_context.Users, "Uid", "Uid");
            return View();
        }

        // POST: Job/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("JobId,ProviderId,WorkerId,Title,Description,Reward,ExpPoints,CreationDate,FinishDate")]
            Job job)
        {
            if (ModelState.IsValid)
            {
                _context.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["ProviderId"] = new SelectList(_context.Users, "Uid", "Uid", job.ProviderId);
            ViewData["WorkerId"] = new SelectList(_context.Users, "Uid", "Uid", job.WorkerId);
            return View(job);
        }

        // GET: Job/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Jobs == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }

            ViewData["ProviderId"] = new SelectList(_context.Users, "Uid", "Uid", job.ProviderId);
            ViewData["WorkerId"] = new SelectList(_context.Users, "Uid", "Uid", job.WorkerId);
            return View(job);
        }

        // POST: Job/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,
            [Bind("JobId,ProviderId,WorkerId,Title,Description,Reward,ExpPoints,CreationDate,FinishDate")]
            Job job)
        {
            if (id != job.JobId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(job);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobExists(job.JobId))
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

            ViewData["ProviderId"] = new SelectList(_context.Users, "Uid", "Uid", job.ProviderId);
            ViewData["WorkerId"] = new SelectList(_context.Users, "Uid", "Uid", job.WorkerId);
            return View(job);
        }

        // GET: Job/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.Jobs == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs
                .Include(j => j.Provider)
                .Include(j => j.Worker)
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Job/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Jobs == null)
            {
                return Problem("Entity set 'dhbwinContext.Jobs'  is null.");
            }

            var job = await _context.Jobs.FindAsync(id);
            if (job != null)
            {
                _context.Jobs.Remove(job);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobExists(string id)
        {
            return (_context.Jobs?.Any(e => e.JobId == id)).GetValueOrDefault();
        }
    }
}