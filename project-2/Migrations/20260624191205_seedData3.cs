using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project_2.Migrations
{
    /// <inheritdoc />
    public partial class seedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "Quantity", "Rate" },
                values: new object[,]
                {
                    { 1, 1, "A high-performance laptop", "Laptop", 1500, "10", 4 },
                    { 2, 2, "A sturdy table", "Table", 500, "5", 3 },
                    { 3, 3, "A comfortable t-shirt", "T-Shirt", 20, "10", 4 },
                    { 4, 4, "A book on history", "Book", 25, "10", 4 },
                    { 5, 5, "A basketball", "Basketball", 50, "10", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
