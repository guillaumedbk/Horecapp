using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horecapp.Migrations
{
    public partial class relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Dish",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_OrderId",
                table: "Dish",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Order_OrderId",
                table: "Dish",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Order_OrderId",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_OrderId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Dish");
        }
    }
}
