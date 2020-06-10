using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBaseTutorial.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductWeight = table.Column<double>(nullable: false),
                    ProductAddled = table.Column<bool>(nullable: false),
                    ProductBuyedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductAddled", "ProductBuyedDate", "ProductName", "ProductWeight" },
                values: new object[] { 1, true, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onion", 0.5 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductAddled", "ProductBuyedDate", "ProductName", "ProductWeight" },
                values: new object[] { 2, true, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salat", 1.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductAddled", "ProductBuyedDate", "ProductName", "ProductWeight" },
                values: new object[] { 3, true, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pickle", 2.5 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductAddled", "ProductBuyedDate", "ProductName", "ProductWeight" },
                values: new object[] { 4, true, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potato", 8.5600000000000005 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductAddled", "ProductBuyedDate", "ProductName", "ProductWeight" },
                values: new object[] { 5, false, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato", 0.050000000000000003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
