using Microsoft.EntityFrameworkCore.Migrations;

namespace MixedShop.Migrations
{
    public partial class addingimagelinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Catalog\\canonprinter.jpg", "\\Images\\Catalog\\canonprinter.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Wireless Mouse, 3 Year Battery Life, Blue", "\\Images\\Catalog\\logitech-wireless-mouse.jpg", "\\Images\\Catalog\\logitech-wireless-mouse.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "\\Images\\Catalog\\Logitech Performance Mouse.jpg", "\\Images\\Catalog\\Logitech Performance Mouse.jpg", "Logitech High Performance Mouse" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Catalog\\Sony Headphones.jpg", "\\Images\\Catalog\\Sony Headphones.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Catalog\\Samsung Odyssey Montior.jpg", "\\Images\\Catalog\\Samsung Odyssey Montior.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Catalog\\Acer Full HD Monitor.jpg", "\\Images\\Catalog\\Acer Full HD Monitor.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Wireless", "\\Images\\Catalog\\Logitech Keyboard.jpg", "\\Images\\Catalog\\Logitech Keyboard.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "\\Images\\Catalog\\Bose Headphones.jpg", "\\Images\\Catalog\\Bose Headphones.jpg", "Bose Headphones" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Catalog\\Razer Gaming Keyboard.jpg", "\\Images\\Catalog\\Razer Gaming Keyboard.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Catalog\\LG Curved Monitor.jpg", "\\Images\\Catalog\\LG Curved Monitor.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Catalog\\Asus Curved Gaming Monitor.jpg", "\\Images\\Catalog\\Asus Curved Gaming Monitor.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 13,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Multifunction Wireless Laser Printer, White", "\\Images\\Catalog\\HP LaserJet Printer.jpg", "\\Images\\Catalog\\HP LaserJet Printer.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Wireless Mouse, 3 Year Battery Life, Black", "", "" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "", "", "Logitech G502 Hero High Performance Mouse" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Wired", "", "" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "", "", "Bose Headphones 700" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 13,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Multifunction Wireless Laser Printer", "", "" });
        }
    }
}
