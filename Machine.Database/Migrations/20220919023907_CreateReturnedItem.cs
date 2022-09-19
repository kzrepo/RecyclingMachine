using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Machine.Database.Migrations
{
    public partial class CreateReturnedItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReturnedItem",
                columns: table => new
                {
                    IdReturnedItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVoucher = table.Column<int>(type: "int", nullable: false),
                    VoucherIdVoucher = table.Column<int>(type: "int", nullable: true),
                    ItemType = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Price = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnedItem", x => x.IdReturnedItem);
                    table.ForeignKey(
                        name: "FK_ReturnedItem_Voucher_VoucherIdVoucher",
                        column: x => x.VoucherIdVoucher,
                        principalTable: "Voucher",
                        principalColumn: "IdVoucher");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedItem_VoucherIdVoucher",
                table: "ReturnedItem",
                column: "VoucherIdVoucher");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReturnedItem");
        }
    }
}
