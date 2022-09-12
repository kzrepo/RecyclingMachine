using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Machine.Database.Data.AdminSite;

namespace Machine.AdminSite.Data
{
    public class MachineAdminSiteContext : DbContext
    {
        public MachineAdminSiteContext (DbContextOptions<MachineAdminSiteContext> options)
            : base(options)
        {
        }

        public DbSet<Machine.Database.Data.AdminSite.ItemParameter> ItemParameter { get; set; } = default!;
    }
}
