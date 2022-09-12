using Machine.Database.Data.AdminSite;
using Microsoft.EntityFrameworkCore;

namespace Machine.Database
{
    public class MachineContext : DbContext
    {
        public MachineContext(DbContextOptions<MachineContext> options)
            : base(options)
        {
        }

        //AdminSite
        public DbSet<ItemParameter> ItemParameter { get; set; } = default!;

        //CustomerPanel

    }
}
