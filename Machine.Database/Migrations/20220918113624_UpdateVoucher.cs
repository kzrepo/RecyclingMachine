using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Machine.Database.Migrations
{
    public partial class UpdateVoucher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "End",
                table: "Voucher");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Voucher");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Voucher",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Voucher");

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Voucher",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Voucher",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
