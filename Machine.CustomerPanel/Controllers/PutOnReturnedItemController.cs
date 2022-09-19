using Machine.Database;
using Machine.Database.Data.AdminSite;
using Microsoft.AspNetCore.Mvc;

namespace Machine.CustomerPanel.Controllers
{
    public class PutOnReturnedItemController : Controller
    {
        private readonly MachineContext _context;

        public PutOnReturnedItemController(MachineContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: PutOnReturnedItem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PutOnReturnedItem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdParameter,ItemType,ParameterType,Value,Note")] ReturnedItem returnedItem)
        {
            if(ModelState.IsValid)
            {
                _context.Add(returnedItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(returnedItem);
        }
    }
}
