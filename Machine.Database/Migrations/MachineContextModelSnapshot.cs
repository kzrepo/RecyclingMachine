﻿// <auto-generated />
using Machine.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Machine.Database.Migrations
{
    [DbContext(typeof(MachineContext))]
    partial class MachineContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Machine.Database.Data.AdminSite.ItemParameter", b =>
                {
                    b.Property<int>("IdParameter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdParameter"), 1L, 1);

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParameterType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdParameter");

                    b.ToTable("ItemParameter");

                    b.HasData(
                        new
                        {
                            IdParameter = 1,
                            ItemType = "bottle",
                            Note = "Maximum bottle weight (g)",
                            ParameterType = "weight",
                            Value = "30"
                        },
                        new
                        {
                            IdParameter = 2,
                            ItemType = "can",
                            Note = "Maximum can weight (g)",
                            ParameterType = "weight",
                            Value = "20"
                        },
                        new
                        {
                            IdParameter = 3,
                            ItemType = "bottle",
                            Note = "Plastic bottle processing time (milliseconds)",
                            ParameterType = "processing",
                            Value = "1000"
                        },
                        new
                        {
                            IdParameter = 4,
                            ItemType = "can",
                            Note = "Plastic can processing time (milliseconds)",
                            ParameterType = "processing",
                            Value = "500"
                        },
                        new
                        {
                            IdParameter = 5,
                            ItemType = "bottle",
                            Note = "Price of the returned bottle (NOK)",
                            ParameterType = "price",
                            Value = "3"
                        },
                        new
                        {
                            IdParameter = 6,
                            ItemType = "can",
                            Note = "Price of the returned can (NOK)",
                            ParameterType = "price",
                            Value = "2"
                        },
                        new
                        {
                            IdParameter = 7,
                            ItemType = "bottle",
                            Note = "The manufacturer from which we accept the bottles",
                            ParameterType = "manufacturer",
                            Value = "GoodSugar"
                        },
                        new
                        {
                            IdParameter = 8,
                            ItemType = "can",
                            Note = "The manufacturer from which we accept the cans",
                            ParameterType = "manufacturer",
                            Value = "NaturalDrinks"
                        });
                });

            modelBuilder.Entity("Machine.Database.Data.AdminSite.Voucher", b =>
                {
                    b.Property<int>("IdVoucher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVoucher"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("IdVoucher");

                    b.ToTable("Voucher");
                });
#pragma warning restore 612, 618
        }
    }
}
