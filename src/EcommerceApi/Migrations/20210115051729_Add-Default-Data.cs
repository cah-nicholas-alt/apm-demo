using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceApi.Migrations
{
    public partial class AddDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Ecommerce",
                table: "tblOrder",
                columns: new[] { "OrderId", "GrandTotal", "OrderTotal", "Taxes", "UserId" },
                values: new object[,]
                {
                    { 1, 10.7m, 10.0m, 0.70m, "nick" },
                    { 2, 21.2m, 20.0m, 1.2m, "bob" },
                    { 3, 0.00m, 0.0m, 0.00m, "bob" }
                });

            migrationBuilder.InsertData(
                schema: "Ecommerce",
                table: "tblProduct",
                columns: new[] { "ProductId", "Cost", "ProductName" },
                values: new object[,]
                {
                    { 1, 10m, "Product A" },
                    { 2, 5m, "Product B" },
                    { 3, 14m, "Product C" },
                    { 4, 76m, "Product D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ecommerce",
                table: "tblOrder",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Ecommerce",
                table: "tblOrder",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Ecommerce",
                table: "tblOrder",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Ecommerce",
                table: "tblProduct",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Ecommerce",
                table: "tblProduct",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Ecommerce",
                table: "tblProduct",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Ecommerce",
                table: "tblProduct",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
