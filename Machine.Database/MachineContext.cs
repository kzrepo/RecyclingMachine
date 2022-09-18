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
        public DbSet<ItemParameter>? ItemParameter { get; set; }
        public DbSet<Voucher>? Voucher { get; set; }

        //Data Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ItemParameterSeed

            modelBuilder.Entity<ItemParameter>().HasData(
                new
                {
                    IdParameter = 1,
                    ItemType = "bottle",
                    ParameterType = "weight",
                    Value = "30",
                    Note = "Maximum bottle weight (g)"
                }, new
                {
                    IdParameter = 2,
                    ItemType = "can",
                    ParameterType = "weight",
                    Value = "20",
                    Note = "Maximum can weight (g)"
                }, new
                {
                    IdParameter = 3,
                    ItemType = "bottle",
                    ParameterType = "processing",
                    Value = "1000",
                    Note = "Plastic bottle processing time (milliseconds)"
                }, new
                {
                    IdParameter = 4,
                    ItemType = "can",
                    ParameterType = "processing",
                    Value = "500",
                    Note = "Plastic can processing time (milliseconds)"
                }, new
                {
                    IdParameter = 5,
                    ItemType = "bottle",
                    ParameterType = "price",
                    Value = "3",
                    Note = "Price of the returned bottle (NOK)"
                }
                , new
                {
                    IdParameter = 6,
                    ItemType = "can",
                    ParameterType = "price",
                    Value = "2",
                    Note = "Price of the returned can (NOK)"
                }, new
                {
                    IdParameter = 7,
                    ItemType = "bottle",
                    ParameterType = "manufacturer",
                    Value = "GoodSugar",
                    Note = "The manufacturer from which we accept the bottles"
                }, new
                {
                    IdParameter = 8,
                    ItemType = "can",
                    ParameterType = "manufacturer",
                    Value = "NaturalDrinks",
                    Note = "The manufacturer from which we accept the cans"
                }
                );

            #endregion
        }

    }
}
