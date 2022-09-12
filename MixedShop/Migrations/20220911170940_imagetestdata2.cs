using Microsoft.EntityFrameworkCore.Migrations;

namespace MixedShop.Migrations
{
    public partial class imagetestdata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "Make", "Name", "Price" },
                values: new object[] { 4, "Black", "~/wwwroot/Images/Catalog/jblheadset.jpg", "~/wwwroot/Images/Catalog/jblheadset.jpg", "JBL", "JBL Headset", 499.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "Make", "Name", "Price" },
                values: new object[] { 1, "testni podaci", "~/Images/Catalog/jblheadset.jpg", "~/Images/Catalog/jblheadset.jpg", "make1", "prvi item", 10m });
        }
    }
}
