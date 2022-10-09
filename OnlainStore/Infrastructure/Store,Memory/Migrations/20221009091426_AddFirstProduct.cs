using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Memory.Migrations
{
    public partial class AddFirstProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "Link", "Name" },
                values: new object[] { 1, 125000m, "512 gb", "/images/image1.jpg", "Iphone 13 Pro Max" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "Link", "Name" },
                values: new object[] { 2, 55000m, "Video game console", "/images/image2.jpg", "Sony PS5" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "Link", "Name" },
                values: new object[] { 3, 1500m, "Literary work by the Russian author Leo Tolstoy", "/images/image3.jpg", "War and Peace" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
