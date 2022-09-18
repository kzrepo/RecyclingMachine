using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Machine.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemParameter",
                columns: table => new
                {
                    IdParameter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    ParameterType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemParameter", x => x.IdParameter);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    IdVoucher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.IdVoucher);
                });

            migrationBuilder.InsertData(
                table: "ItemParameter",
                columns: new[] { "IdParameter", "ItemType", "Note", "ParameterType", "Value" },
                values: new object[,]
                {
                    { 1, "bottle", "Maximum bottle weight (g)", "weight", "30" },
                    { 2, "can", "Maximum can weight (g)", "weight", "20" },
                    { 3, "bottle", "Plastic bottle processing time (milliseconds)", "processing", "1000" },
                    { 4, "can", "Plastic can processing time (milliseconds)", "processing", "500" },
                    { 5, "bottle", "Price of the returned bottle (NOK)", "price", "3" },
                    { 6, "can", "Price of the returned can (NOK)", "price", "2" },
                    { 7, "bottle", "The manufacturer from which we accept the bottles", "manufacturer", "GoodSugar" },
                    { 8, "can", "The manufacturer from which we accept the cans", "manufacturer", "NaturalDrinks" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemParameter");

            migrationBuilder.DropTable(
                name: "Voucher");
        }
    }
}
