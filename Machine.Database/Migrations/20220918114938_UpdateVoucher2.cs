using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Machine.Database.Migrations
{
    public partial class UpdateVoucher2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Session",
                table: "Voucher");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Session",
                table: "Voucher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
