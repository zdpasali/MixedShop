using Microsoft.EntityFrameworkCore.Migrations;

namespace MixedShop.Migrations
{
    public partial class testingitemdata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 4, "Over-Ear Wireless Headphones", "bose", "Bose Headphones 700", 649.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 10,
                columns: new[] { "Description", "Make", "Name", "Price" },
                values: new object[] { "Huntsman Tournament Edition", "razer", "Razer Gaming Keyboard", 249.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 1, "Curved UltraWide, 3440x1440, Borderless Display", "lg", "LG Curved Monitor", 2909.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 1, "Curved Gaming Monitor, 144Hz, Black", "asus", "Asus Curved Gaming Monitor", 1559.99m });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsRecommended", "Make", "Name", "Price" },
                values: new object[] { 13, 5, "Multifunction Wireless Laser Printer", "", "", false, "hp", "HP LaserJet Printer", 1799.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 2, "", "logitech", "prvi item", 99.90m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 10,
                columns: new[] { "Description", "Make", "Name", "Price" },
                values: new object[] { "testni podaci2", "make2", "drugi item", 10m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 3, "testni podaci3", "make1", "prvi item", 110m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 2, "testni podaci24", "make2", "drugi item", 310.99m });
        }
    }
}
