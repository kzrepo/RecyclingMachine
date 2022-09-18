using Machine.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Machine.CustomerPanel.Controllers.Components
{
    public class TypeOfPackagingComponent : ViewComponent
    {
        private readonly MachineContext _context;
        public TypeOfPackagingComponent(MachineContext context) => _context = context;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("TypeOfPackagingComponent", await _context.ItemParameter!.ToListAsync());
        }
    }
}
