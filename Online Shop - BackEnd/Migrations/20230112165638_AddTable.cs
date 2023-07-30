using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Shop___BackEnd.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComent_AspNetUsers_AppUserId",
                table: "ProductComent");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComent_Products_ProductId",
                table: "ProductComent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductComent",
                table: "ProductComent");

            migrationBuilder.RenameTable(
                name: "ProductComent",
                newName: "ProductComents");

            migrationBuilder.RenameIndex(
                name: "IX_ProductComent_ProductId",
                table: "ProductComents",
                newName: "IX_ProductComents_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductComent_AppUserId",
                table: "ProductComents",
                newName: "IX_ProductComents_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductComents",
                table: "ProductComents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComents_AspNetUsers_AppUserId",
                table: "ProductComents",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComents_Products_ProductId",
                table: "ProductComents",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComents_AspNetUsers_AppUserId",
                table: "ProductComents");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComents_Products_ProductId",
                table: "ProductComents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductComents",
                table: "ProductComents");

            migrationBuilder.RenameTable(
                name: "ProductComents",
                newName: "ProductComent");

            migrationBuilder.RenameIndex(
                name: "IX_ProductComents_ProductId",
                table: "ProductComent",
                newName: "IX_ProductComent_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductComents_AppUserId",
                table: "ProductComent",
                newName: "IX_ProductComent_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductComent",
                table: "ProductComent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComent_AspNetUsers_AppUserId",
                table: "ProductComent",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComent_Products_ProductId",
                table: "ProductComent",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
