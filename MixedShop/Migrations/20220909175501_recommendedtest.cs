using Microsoft.EntityFrameworkCore.Migrations;

namespace MixedShop.Migrations
{
    public partial class recommendedtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "IsRecommended",
                value: true);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "IsRecommended",
                value: true);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "IsRecommended",
                value: true);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "IsRecommended",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "IsRecommended",
                value: false);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "IsRecommended",
                value: false);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "IsRecommended",
                value: false);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "IsRecommended",
                value: false);
        }
    }
}
