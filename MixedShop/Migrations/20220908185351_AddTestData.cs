using Microsoft.EntityFrameworkCore.Migrations;

namespace MixedShop.Migrations
{
    public partial class AddTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Phone", "opis" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Keyboard", "opis" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Mouse", "opis" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsRecommended", "Make", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "testni podaci", "", "", false, "make1", "prvi item", 10 },
                    { 5, 1, "testni podaci", "", "", false, "make1", "5 item", 10 },
                    { 8, 1, "testni podaci24", "", "", false, "make2", "9 item", 10 },
                    { 9, 1, "testni podaci", "", "", false, "make1", "prvi item", 10 },
                    { 13, 1, "testni podaci", "", "", false, "make1", "5 item", 10 },
                    { 16, 1, "testni podaci24", "", "", false, "make2", "9 item", 10 },
                    { 2, 2, "testni podaci2", "", "", false, "make2", "drugi item", 10 },
                    { 4, 2, "testni podaci24", "", "", false, "make2", "drugi item", 310 },
                    { 10, 2, "testni podaci2", "", "", false, "make2", "drugi item", 10 },
                    { 12, 2, "testni podaci24", "", "", false, "make2", "drugi item", 310 },
                    { 3, 3, "testni podaci3", "", "", false, "make1", "prvi item", 110 },
                    { 6, 3, "testni podaci2", "", "", false, "make2", "7 item", 120 },
                    { 7, 3, "testni podaci3", "", "", false, "make1", "8 item", 110 },
                    { 11, 3, "testni podaci3", "", "", false, "make1", "prvi item", 110 },
                    { 14, 3, "testni podaci2", "", "", false, "make2", "7 item", 120 },
                    { 15, 3, "testni podaci3", "", "", false, "make1", "8 item", 110 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
