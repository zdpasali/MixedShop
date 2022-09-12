using Microsoft.EntityFrameworkCore.Migrations;

namespace MixedShop.Migrations
{
    public partial class testingitemdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "Description",
                value: "Black, Noise Cancelling");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 5, "Wireless, Color All-in-One", "Canon", "Canon Printer", 2199.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "Description", "Make", "Name", "Price" },
                values: new object[] { "Wireless Mouse, 3 Year Battery Life, Black", "Logitech", "Logitech Wireless Mouse", 119.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 3, "Wired Gaming Mouse, 11 Programmable Buttons", "Logitech", "Logitech G502 Hero High Performance Mouse", 349.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 4, "Noise Cancelling Headphones, Black/Red", "Sony", "Sony Headphones", 599.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 1, "Gaming Monitor, 2560x1440, 144Hz, Curved", "Samsung", "Samsung Odyssey Montior", 899.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 1, "Zero Frame Monitor, 1920x1080", "acer", "Acer Full HD Monitor", 799.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 2, "Wired", "logitech", "Logitech Keyboard", 110.00m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Make", "Price" },
                values: new object[] { 2, "", "logitech", 99.90m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "Description",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 2, "testni podaci2", "make2", "drugi item", 10.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "Description", "Make", "Name", "Price" },
                values: new object[] { "testni podaci3", "make1", "prvi item", 110.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 2, "testni podaci24", "make2", "drugi item", 310m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 1, "testni podaci", "make1", "5 item", 10m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 3, "testni podaci2", "make2", "7 item", 120m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 3, "testni podaci3", "make1", "8 item", 110.99m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "Make", "Name", "Price" },
                values: new object[] { 1, "testni podaci24", "make2", "9 item", 10m });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Make", "Price" },
                values: new object[] { 1, "testni podaci", "make1", 10m });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsRecommended", "Make", "Name", "Price" },
                values: new object[,]
                {
                    { 13, 1, "testni podaci", "", "", false, "make1", "5 item", 10m },
                    { 14, 3, "testni podaci2", "", "", true, "make2", "7 item", 120m },
                    { 15, 3, "testni podaci3", "", "", false, "make1", "8 item", 110.99m },
                    { 16, 1, "testni podaci24", "", "", false, "make2", "9 item", 10m }
                });
        }
    }
}
