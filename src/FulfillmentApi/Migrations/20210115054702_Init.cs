using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FulfillmentApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Fulfillment");

            migrationBuilder.CreateTable(
                name: "tblOrderItem",
                schema: "Fulfillment",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderNo = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrderItem", x => x.OrderItemId);
                });

            migrationBuilder.InsertData(
                schema: "Fulfillment",
                table: "tblOrderItem",
                columns: new[] { "OrderItemId", "OrderNo", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, "shipped" },
                    { 2, 2, 1, "shipped" },
                    { 3, 2, 2, "pending" },
                    { 4, 2, 2, "pending" },
                    { 5, 3, 4, "canceled" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOrderItem",
                schema: "Fulfillment");
        }
    }
}
