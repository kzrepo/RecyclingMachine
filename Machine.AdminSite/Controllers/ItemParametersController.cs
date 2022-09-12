using Machine.Database;
using Machine.Database.Data.AdminSite;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Machine.AdminSite.Controllers
{
    public class ItemParametersController : Controller
    {
        private readonly MachineContext _context;

        public ItemParametersController(MachineContext context)
        {
            _context = context;
        }

        // GET: ItemParameters
        public async Task<IActionResult> Index()
        {
            return _context.ItemParameter != null ?
                        View(await _context.ItemParameter.ToListAsync()) :
                        Problem("Entity set 'MachineAdminSiteContext.ItemParameter'  is null.");
        }

        // GET: ItemParameters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null || _context.ItemParameter == null)
            {
                return NotFound();
            }

            var itemParameter = await _context.ItemParameter
                .FirstOrDefaultAsync(m => m.IdParameter == id);
            if(itemParameter == null)
            {
                return NotFound();
            }

            return View(itemParameter);
        }

        // GET: ItemParameters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemParameters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdParameter,ItemType,ParameterType,Value,Note")] ItemParameter itemParameter)
        {
            if(ModelState.IsValid)
            {
                _context.Add(itemParameter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemParameter);
        }

        // GET: ItemParameters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null || _context.ItemParameter == null)
            {
                return NotFound();
            }

            var itemParameter = await _context.ItemParameter.FindAsync(id);
            if(itemParameter == null)
            {
                return NotFound();
            }
            return View(itemParameter);
        }

        // POST: ItemParameters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdParameter,ItemType,ParameterType,Value,Note")] ItemParameter itemParameter)
        {
            if(id != itemParameter.IdParameter)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemParameter);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!ItemParameterExists(itemParameter.IdParameter))
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
            return View(itemParameter);
        }

        // GET: ItemParameters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null || _context.ItemParameter == null)
            {
                return NotFound();
            }

            var itemParameter = await _context.ItemParameter
                .FirstOrDefaultAsync(m => m.IdParameter == id);
            if(itemParameter == null)
            {
                return NotFound();
            }

            return View(itemParameter);
        }

        // POST: ItemParameters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if(_context.ItemParameter == null)
            {
                return Problem("Entity set 'MachineAdminSiteContext.ItemParameter'  is null.");
            }
            var itemParameter = await _context.ItemParameter.FindAsync(id);
            if(itemParameter != null)
            {
                _context.ItemParameter.Remove(itemParameter);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemParameterExists(int id)
        {
            return (_context.ItemParameter?.Any(e => e.IdParameter == id)).GetValueOrDefault();
        }
    }
}
